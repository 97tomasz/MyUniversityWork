import RPi.GPIO as GPIO
from time import sleep


GPIO.setwarnings(False)
GPIO.cleanup
LED_ON = 0
LED_OFF = 1

GPIO.setmode(GPIO.BCM)
GPIO.setup(7, GPIO.OUT)
GPIO.output(7, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(8, GPIO.OUT)
GPIO.output(8, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(25, GPIO.OUT)
GPIO.output(25, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(24, GPIO.OUT)
GPIO.output(24, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(23, GPIO.OUT)
GPIO.output(23, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(18, GPIO.OUT)
GPIO.output(18, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(15, GPIO.OUT)
GPIO.output(15, LED_ON)

GPIO.setmode(GPIO.BCM)
GPIO.setup(14, GPIO.OUT)
GPIO.output(14, LED_ON)

GPIO.output(7, LED_OFF)
GPIO.output(8, LED_OFF)
GPIO.output(25, LED_OFF)
GPIO.output(24, LED_OFF)
GPIO.output(23, LED_OFF)
GPIO.output(18, LED_OFF)
GPIO.output(15, LED_OFF)
GPIO.output(14, LED_OFF)

R1=14
A1=15
G1=18
R2=24
A2=25
G2=8

#1
GPIO.output(R1, LED_ON)
sleep(0.5)
GPIO.output(R1, LED_OFF)
sleep(0.5)
GPIO.output(R1, LED_ON)
sleep(0.5)
GPIO.output(R1, LED_OFF)
sleep(0.5)
GPIO.output(R1, LED_ON)
sleep(0.5)
GPIO.output(R1, LED_OFF)
sleep(0.5)
GPIO.output(R1, LED_ON)
sleep(0.5)
GPIO.output(R1, LED_OFF)
sleep(0.5)

#2
GPIO.output(R1, LED_ON)
GPIO.output(A1, LED_ON)
GPIO.output(R2, LED_ON)
sleep(1)
GPIO.output(R1, LED_OFF)
GPIO.output(A1, LED_OFF)
GPIO.output(G1, LED_ON)
sleep(5)
GPIO.output(G1, LED_OFF)
GPIO.output(A1, LED_ON)
sleep(1)
GPIO.output(A1, LED_OFF)
GPIO.output(R1, LED_ON)
sleep(1)
GPIO.output(A2, LED_ON)
sleep(1)
GPIO.output(A2, LED_OFF)
GPIO.output(R2, LED_OFF)
GPIO.output(G2, LED_ON)
sleep(5)
GPIO.output(G2, LED_OFF)
GPIO.output(A2, LED_ON)
sleep(1)
GPIO.output(A2, LED_OFF)
GPIO.output(R2, LED_ON)
