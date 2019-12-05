<?php

$db = "mysql:host=kunet;dbname=db_k1524638";

$userName = "k1524638";

$password = "k1524638";

$pdo = new PDO($db, $userName, $password, [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]);

function getAllVehicles() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Vehicles");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Vehicles");
    return $results;
}
function getAllVehicle_Model() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Vehicle_Model");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Vehicle_Model");
    return $results;
}
function getAllCustomer() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Customer");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Customer");
    return $results;
}
function getAllDriver() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Driver");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Driver");
    return $results;
}
function getAllBooking() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Booking");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Booking");
    return $results;
}
function getAllAdmin() {
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Admins");
    $statement->execute();
    $results = $statement->fetchAll(PDO::FETCH_CLASS, "Admin");
    return $results;
}
function getVehiclebyCost($minCost, $maxCost)
{
    global $pdo;
    $statement = $pdo->prepare("SELECT * FROM Vehicle_Model WHERE HourlyRate<? HourlyRate>? ");
    $statement->execute([$minCost, $maxCost]);
    $result=$statement->fetchAll(PDO::FETCH_CLASS, "Vehicle_Model");
    return $results;
}