-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 02, 2023 at 05:49 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mahalle_marketi`
--

-- --------------------------------------------------------

--
-- Table structure for table `satış`
--

CREATE TABLE `satış` (
  `kullaniciAdi` varchar(50) NOT NULL,
  `SatışId` varchar(255) NOT NULL,
  `SMüşteriAdıSoyadı` varchar(100) NOT NULL,
  `StoplamTutar` int(255) NOT NULL,
  `Södenen` int(255) NOT NULL,
  `Sborç` int(255) NOT NULL,
  `Starih` varchar(19) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `satış`
--
ALTER TABLE `satış`
  ADD PRIMARY KEY (`SatışId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
