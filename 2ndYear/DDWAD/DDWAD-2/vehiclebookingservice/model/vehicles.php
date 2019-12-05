<?php
class Vehicles {
    private $VehicleID;
    private $ModelID;

    function __get($vehicle) {
        return $this->$vehicle;
    }

    function __set($vehicle, $value) {
        return $this->$vehicle = $value;
    }

    function displayVehicle() {
        return "$this->VehicleID, $this->ModelID";
    }
}
?>