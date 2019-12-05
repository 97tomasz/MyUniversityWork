<?php
require_once "../model/vehicles.php";
require_once "../model/dbaccess.php";

$VehicleResults = getAllVehicles();

require_once "../view/vehicle_view.php";