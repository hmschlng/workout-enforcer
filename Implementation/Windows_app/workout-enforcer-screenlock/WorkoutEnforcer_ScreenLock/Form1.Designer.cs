
namespace WorkoutEnforcer_ScreenLock {
	partial class Form1 {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.lbl_MainText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_MainText
			// 
			this.lbl_MainText.AutoSize = true;
			this.lbl_MainText.Font = new System.Drawing.Font("휴먼편지체", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lbl_MainText.ForeColor = System.Drawing.Color.OrangeRed;
			this.lbl_MainText.Location = new System.Drawing.Point(370, 339);
			this.lbl_MainText.Name = "lbl_MainText";
			this.lbl_MainText.Size = new System.Drawing.Size(1107, 291);
			this.lbl_MainText.TabIndex = 0;
			this.lbl_MainText.Text = "운동해라!!!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.lbl_MainText);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_MainText;
	}
}

