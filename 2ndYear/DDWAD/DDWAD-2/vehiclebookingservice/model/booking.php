<?php
class Booking {
    private $BookingID;
    private $CustomerID;
    private $VehicleID;
    private $DateRequired;
    private $Passengers;

    function __get($booking) {
        return $this->$booking;
    }

    function __set($booking, $value) {
        return $this->$booking = $value;
    }

    function displayVehicle() {
        return "$this->BookingID, $this->CustomerID, $this->VehicleID, $this->DateRequired, $this->Passengers";
    }
}