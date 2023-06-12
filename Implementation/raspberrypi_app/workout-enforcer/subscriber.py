import paho.mqtt.client as mqtt
import os

mqtt_broker_server = "192.168.31.157"


def on_connect(client, userdata, flags, rc):
    print("---Connected with broker server (" + mqtt_broker_server + ") ---")
    print("- Result code : " + str(rc))
    client.subscribe("hmschlng")
    print("- Topic : hmschlng")
    print("\n Listening...\n")


def on_message(client, userdata, msg):
    # recieve publisher's messege
    msg = str(msg.payload)
    print(msg)
    payload = int(msg[2:-1])
    if payload > 0:
        print("recieved msg -> {0}".format(payload))
        goal = payload

        for i in range(0, 2):
            os.system('mpg123 -q ./audio/yeahbuddy.mp3')

        print('Start running program..')
        os.system("sudo python3 program.py {0}".format(goal))


try:
    client = mqtt.Client()
    client.on_connect = on_connect
    client.on_message = on_message

    client.connect(mqtt_broker_server, 1883, 60)

    client.loop_forever()

except KeyboardInterrupt:
    print("\nKeyboard interrupt detected.")
    print("End listening..")
    print("Terminate Workout Enforcer..")
