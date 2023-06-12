import paho.mqtt.client as mqtt
import sys

mqtt_broker_address = "192.168.31.157"

mqtt = mqtt.Client("workout-enforcer")
mqtt.connect(mqtt_broker_address, 1883)

mqtt.publish("hmschlng", "-1")
mqtt.loop(2)
