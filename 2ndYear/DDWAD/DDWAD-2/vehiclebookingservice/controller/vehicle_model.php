<?php
require_once "../model/vehicle_Model.php";
require_once "../model/dbaccess.php";

$Vehicle_ModelResults = getAllVehicle_Model();

require_once "../view/vehicle_view.php";