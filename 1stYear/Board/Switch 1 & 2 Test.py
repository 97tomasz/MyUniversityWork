import RPi.GPIO as GPIO
from time import sleep

GPIO.setmode(GPIO.BCM)
GPIO.setup(2, GPIO.IN)
GPIO.setup(3, GPIO.IN)

print(GPIO.input(2))
if GPIO.input(2) == 1 :
    print("True")
else:
    print("False")
print(GPIO.input(3))
if GPIO.input(3) == 1 :
    print("True")
else:
    print("False")
