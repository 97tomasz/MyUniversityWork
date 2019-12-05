#Heater
from time import sleep
import RPi.GPIO as GPIO

GPIO.setwarnings(False)
GPIO.cleanup

GPIO.setmode(GPIO.BCM)
GPIO.setup(10, GPIO.OUT)
GPIO.setup(4, GPIO.IN)

for i in range(0,5) :
    
    if GPIO.input(4) == 1 :
        print("Switch is on")
        GPIO.output(10, 0)
        sleep(5)
        GPIO.output(10, 1)
    elif GPIO.input(4) == 0 :
        print("Switch is off")
    sleep(1)
        
