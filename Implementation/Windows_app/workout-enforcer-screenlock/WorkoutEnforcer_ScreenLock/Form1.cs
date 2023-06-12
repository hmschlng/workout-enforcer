using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace WorkoutEnforcer_ScreenLock {
	public partial class Form1 : Form {
		MqttClient client;
		string clientID;

		public Form1() {
			DateTime dt = new DateTime(2022,6,5,16,04,30);
			while(DateTime.Now < dt) { }

			InitializeComponent();
			//Get a bare, black form to cover the entire screen
			this.BackColor = Color.Cornsilk;
/*			this.CausesValidation = false;*/
			this.StartPosition = FormStartPosition.Manual;
			this.WindowState = FormWindowState.Maximized;
/*			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;*/
		}

		private void Form1_Load(object sender, EventArgs e) {
			string BrokerAddress = "192.168.31.157";

			this.client = new MqttClient(BrokerAddress);
			this.client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

			client.Publish("hmschlng", Encoding.UTF8.GetBytes("10"), 0, false);

			this.client.Subscribe(
				new string[] { "hmschlng" }, 
				new byte[] { 0 });

			this.clientID = Guid.NewGuid().ToString();
			this.client.Connect(this.clientID);
		}

		void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {
			string receivedMessage = Encoding.UTF8.GetString(e.Message);
			if(receivedMessage.Equals("-1"))
				Application.Exit();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			client.Disconnect();
		}
	}
}
