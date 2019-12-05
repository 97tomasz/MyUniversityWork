import RPi.GPIO as GPIO
from time import sleep
GPIO.setwarnings(False)
GPIO.cleanup()

GPIO.setmode(GPIO.BCM)
GPIO.setup(11, GPIO.OUT)
choice = "n"

GPIO.output(11, 1)
while choice != "e":
    
    while choice != "y" :
        
        GPIO.output(11, 1)
        
        choice = input("Do you wish to stop?")
           
    choice = "n"

    while choice != "y" :

        GPIO.output(11,0)

        choice = input("Do you wish to start?")

    choice = "n"
    
    

    

    

