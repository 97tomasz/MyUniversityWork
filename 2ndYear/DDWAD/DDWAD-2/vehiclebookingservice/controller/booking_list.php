<?php
require_once "../model/booking.php";
require_once "../model/dbaccess.php";

$results = getAllBooking();

require_once "../view/booking_view.php";