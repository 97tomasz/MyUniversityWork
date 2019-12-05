-- phpMyAdmin SQL Dump
-- version 4.4.13.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 10, 2019 at 08:59 PM
-- Server version: 10.0.21-MariaDB
-- PHP Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_k1524638`
--

-- --------------------------------------------------------

--
-- Table structure for table `Admin`
--

CREATE TABLE IF NOT EXISTS `Admin` (
  `id` int(8) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Priviledges` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Admin`
--

INSERT INTO `Admin` (`id`, `Username`, `Password`, `Priviledges`) VALUES
(1, 'admin', 'admin', 'FULL');

-- --------------------------------------------------------

--
-- Table structure for table `Booking`
--

CREATE TABLE IF NOT EXISTS `Booking` (
  `BookingID` int(7) NOT NULL,
  `CustomerID` int(10) NOT NULL,
  `VehicleID` int(10) NOT NULL,
  `DateRequired` date NOT NULL,
  `Passengers` int(3) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Booking`
--

INSERT INTO `Booking` (`BookingID`, `CustomerID`, `VehicleID`, `DateRequired`, `Passengers`) VALUES
(1, 1, 1, '2019-02-14', 4),
(2, 1, 1, '2019-02-15', 3),
(3, 3, 3, '2019-01-05', 2),
(4, 4, 4, '2019-01-09', 3),
(5, 5, 5, '2019-01-10', 4),
(6, 6, 6, '2019-01-17', 2),
(7, 7, 7, '2019-01-18', 2);

-- --------------------------------------------------------

--
-- Table structure for table `Customer`
--

CREATE TABLE IF NOT EXISTS `Customer` (
  `CustomerID` int(10) NOT NULL,
  `CustomerName` varchar(36) NOT NULL,
  `CustomerContactDetails` varchar(36) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Customer`
--

INSERT INTO `Customer` (`CustomerID`, `CustomerName`, `CustomerContactDetails`) VALUES
(1, 'Bob Ross', '07413063255'),
(2, 'Jane', '07427588224'),
(3, 'Malik', '071234567891'),
(4, 'Mehjabin', '07432678911'),
(5, 'Andrew', '07659753015'),
(6, 'Josh', '074321769012'),
(7, 'John', '0786543210');

-- --------------------------------------------------------

--
-- Table structure for table `Driver`
--

CREATE TABLE IF NOT EXISTS `Driver` (
  `DriverID` int(10) NOT NULL,
  `DriverName` varchar(36) NOT NULL,
  `DriverLicense` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Driver`
--

INSERT INTO `Driver` (`DriverID`, `DriverName`, `DriverLicense`) VALUES
(101, 'Johny', 'Basic'),
(102, 'Paul', 'Basic'),
(103, 'Ahmed', 'Basic'),
(104, 'Adam', 'Basic'),
(105, 'Gabril', 'Basic');

-- --------------------------------------------------------

--
-- Table structure for table `Vehicles`
--

CREATE TABLE IF NOT EXISTS `Vehicles` (
  `VehicleID` int(10) NOT NULL,
  `ModelID` int(10) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1000 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Vehicles`
--

INSERT INTO `Vehicles` (`VehicleID`, `ModelID`) VALUES
(1, 111),
(4, 111),
(5, 111),
(2, 112),
(6, 112),
(7, 112),
(8, 112),
(3, 113),
(9, 113),
(10, 113),
(13, 114),
(14, 114),
(15, 114),
(16, 114);

-- --------------------------------------------------------

--
-- Table structure for table `Vehicle_Model`
--

CREATE TABLE IF NOT EXISTS `Vehicle_Model` (
  `ModelID` int(10) NOT NULL,
  `VehicleModel` varchar(36) NOT NULL,
  `NumberOfVehicles` int(3) NOT NULL,
  `Passengers` int(3) NOT NULL,
  `DrivingLicense` varchar(36) NOT NULL,
  `HourlyRate` int(3) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Vehicle_Model`
--

INSERT INTO `Vehicle_Model` (`ModelID`, `VehicleModel`, `NumberOfVehicles`, `Passengers`, `DrivingLicense`, `HourlyRate`) VALUES
(111, 'Standard 6 Seat MPV', 5, 6, 'Basic', 55),
(112, 'Executive 8 Seat MPV', 3, 8, 'Basic', 65),
(113, '10 Seat VIP Coach', 4, 10, 'Basic', 55),
(114, '10-14 Seat Standard Minibus', 4, 14, 'Basic', 65),
(115, '15-16 Seat Standard Minibus', 5, 16, 'Basic', 85),
(116, '10-16 Seat Standard Coach', 7, 16, 'Basic', 70),
(117, '17-24 Seat Standard Coach', 6, 24, 'Basic', 80),
(118, '25-33 Seat Standard Coach', 3, 33, 'Basic', 120),
(119, '34-49 Seat Standard Coach', 4, 49, 'Basic', 130),
(120, '70-73 Seat Double Deck Coach', 1, 73, 'Basic', 150),
(121, '72 Seat Bus', 2, 72, 'Basic', 140),
(122, '14-16 Seat Executive Mini Coach', 3, 16, 'Basic', 90),
(123, '17-24 Seat Executive Mini Coach', 3, 24, 'Basic', 100),
(124, '34-49 Seat VIP Coach', 2, 49, 'Full', 140);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Admin`
--
ALTER TABLE `Admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Booking`
--
ALTER TABLE `Booking`
  ADD PRIMARY KEY (`BookingID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `VehicleID` (`VehicleID`);

--
-- Indexes for table `Customer`
--
ALTER TABLE `Customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `Driver`
--
ALTER TABLE `Driver`
  ADD PRIMARY KEY (`DriverID`);

--
-- Indexes for table `Vehicles`
--
ALTER TABLE `Vehicles`
  ADD PRIMARY KEY (`VehicleID`),
  ADD KEY `ModelID` (`ModelID`);

--
-- Indexes for table `Vehicle_Model`
--
ALTER TABLE `Vehicle_Model`
  ADD PRIMARY KEY (`ModelID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Admin`
--
ALTER TABLE `Admin`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Booking`
--
ALTER TABLE `Booking`
  MODIFY `BookingID` int(7) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `Customer`
--
ALTER TABLE `Customer`
  MODIFY `CustomerID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `Driver`
--
ALTER TABLE `Driver`
  MODIFY `DriverID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=106;
--
-- AUTO_INCREMENT for table `Vehicles`
--
ALTER TABLE `Vehicles`
  MODIFY `VehicleID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=1000;
--
-- AUTO_INCREMENT for table `Vehicle_Model`
--
ALTER TABLE `Vehicle_Model`
  MODIFY `ModelID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=125;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Booking`
--
ALTER TABLE `Booking`
  ADD CONSTRAINT `Booking_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `Customer` (`CustomerID`),
  ADD CONSTRAINT `Booking_ibfk_2` FOREIGN KEY (`VehicleID`) REFERENCES `Vehicles` (`VehicleID`);

--
-- Constraints for table `Vehicles`
--
ALTER TABLE `Vehicles`
  ADD CONSTRAINT `Vehicles_ibfk_1` FOREIGN KEY (`ModelID`) REFERENCES `Vehicle_Model` (`ModelID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
