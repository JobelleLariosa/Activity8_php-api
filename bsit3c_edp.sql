-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 29, 2024 at 07:43 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bsit3c_edp`
--

-- --------------------------------------------------------

--
-- Table structure for table `credential`
--

CREATE TABLE `credential` (
  `idCredential` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `isActive` bit(1) DEFAULT NULL,
  `position` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `credential`
--

INSERT INTO `credential` (`idCredential`, `username`, `password`, `name`, `email`, `isActive`, `position`) VALUES
(1, 'belle', 'belle', 'Jobelle Lariosa', 'jobellelariosa@gmail.com', NULL, 'project manager'),
(2, 'joan', 'joan', 'Joan Gantan', 'joangantan@gmail.com', b'1', 'system analyst'),
(3, 'AaronJon', 'AaronJon', 'Aaron Jon Alberto', 'aaronjonalberto@gmail.com', b'1', 'UX/UI Desginer'),
(4, 'kirk', 'kirk', 'Kirk Owen Jesalva', 'kirkowenjesalva@gmail.com', b'1', 'Main Programmer'),
(5, 'Marky', 'Marky', 'Mark Angelo Mansion', 'markangelomansion@gmail.com', b'1', 'Technical Support'),
(6, 'Mark Joseph', 'markjoseph', 'Mark Joseph', 'markjoseph@gmail.com', b'1', 'Senior Developer'),
(7, 'Maribel Lariosa', 'mabellariosa', 'Maribel Lariosa', 'maribellariosa@gmail.com', b'1', 'CEO'),
(8, 'Maribel Lariosa', 'mabellariosa', 'Maribel Lariosa', 'maribellariosa@gmail.com', b'1', 'CEO'),
(9, 'Mia', 'MiaRossa', 'Mia Rossa', 'miarossa@gmail.com', b'1', 'COO'),
(10, 'erik', 'erik', 'erik avellano', 'avellanoerick@gmail.com', b'1', 'Main Developer'),
(11, 'sofia manao', 'smanao', 'smanao', 'sofiamanao@gmail.com', b'1', 'secretary');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(255) NOT NULL,
  `ContactNumber` varchar(15) NOT NULL,
  `Location` varchar(45) NOT NULL,
  `Payment` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`, `ContactNumber`, `Location`, `Payment`, `Email`) VALUES
(1, 'Mark Angelo', '+09501714500', 'Legaspi City', 'Cash on Delivery', 'markangelomansion@gmail.com'),
(2, 'Mariella Joy Job', '+0917502487', 'Pilar Sorsogon', 'Gcash', 'mariellajoyjob@gmail.com'),
(3, 'Jobelle', '5743875367', 'Casiguran Sorsogon', 'cash', 'jobelle@gmail.com'),
(4, 'Agnes Ogaban', '+4578247585', 'Rawis Albay', 'Cash', 'agesogaban@gmail.com'),
(5, 'Beatris Gomer', '59263596', 'Sorsogon City', 'Cash', 'bea@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `credential`
--
ALTER TABLE `credential`
  ADD PRIMARY KEY (`idCredential`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `credential`
--
ALTER TABLE `credential`
  MODIFY `idCredential` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
