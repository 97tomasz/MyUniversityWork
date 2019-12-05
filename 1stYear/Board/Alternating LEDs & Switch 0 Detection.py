#Alternating LEDs
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

GPIO.setmode(GPIO.BCM)
GPIO.setup(7, GPIO.OUT)
GPIO.setup(2, GPIO.IN)

for i in range (0,5):
    GPIO.output(7, LED_OFF)
    GPIO.output(8, LED_OFF)
    GPIO.output(25, LED_OFF)
    GPIO.output(24, LED_OFF)
    GPIO.output(23, LED_OFF)
    GPIO.output(18, LED_OFF)
    GPIO.output(15, LED_OFF)
    GPIO.output(14, LED_OFF)
    sleep(0.6)
    GPIO.output(7, LED_ON)
    GPIO.output(8, LED_ON)
    GPIO.output(24, LED_ON)
    GPIO.output(25, LED_ON)
    GPIO.output(23, LED_ON)
    GPIO.output(18, LED_ON)
    GPIO.output(15, LED_ON)
    GPIO.output(14, LED_ON)
    sleep(0.6)
if GPIO.input(2):
    print("====== Input from Switch S0 Detected =======")
    GPIO.output(7, LED_OFF)
    GPIO.output(8, LED_OFF)
    GPIO.output(25, LED_OFF)
    GPIO.output(24, LED_OFF)
    GPIO.output(23, LED_OFF)
    GPIO.output(18, LED_OFF)
    GPIO.output(15, LED_OFF)
    GPIO.output(14, LED_OFF)
    GPIO.setmode(GPIO.BCM)
    GPIO.setup(11, GPIO.OUT)
    GPIO.output(11, 1)
    sleep(3)
    GPIO.output(11, 0)
    GPIO.output(7, LED_ON)
    GPIO.output(8, LED_ON)
    GPIO.output(24, LED_ON)
    GPIO.output(25, LED_ON)
    GPIO.output(23, LED_ON)
    GPIO.output(18, LED_ON)
    GPIO.output(15, LED_ON)
    GPIO.output(14, LED_ON)
    
    
    
