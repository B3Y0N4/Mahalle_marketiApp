-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 02, 2023 at 09:29 PM
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
-- Table structure for table `kullanıcılar`
--

CREATE TABLE `kullanıcılar` (
  `kullanıcıAdı` varchar(50) NOT NULL,
  `kullanıcıŞifresi` varchar(50) NOT NULL,
  `kaydolmaTarihi` varchar(19) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Dumping data for table `kullanıcılar`
--

INSERT INTO `kullanıcılar` (`kullanıcıAdı`, `kullanıcıŞifresi`, `kaydolmaTarihi`) VALUES
('bizim market', 'market55', '2023-01-02 10:30:50'),
('usama market', 'oussama', '2023-01-02 12:30:28'),
('jalal market', 'jalal55', '2023-01-02 12:35:49'),
('hacer market', 'hacer55', '2023-01-02 12:45:07');

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

-- --------------------------------------------------------

--
-- Table structure for table `satışürün`
--

CREATE TABLE `satışürün` (
  `kullaniciAdi` varchar(50) NOT NULL,
  `Sid` varchar(50) NOT NULL,
  `ÜrünBk` int(255) NOT NULL,
  `MüşteriAdıSoyadı` varchar(50) NOT NULL,
  `ÜrünAdı` varchar(50) NOT NULL,
  `Miktar` int(255) NOT NULL,
  `ToplamTutar` int(255) NOT NULL,
  `Ödenen` int(255) NOT NULL,
  `borç` int(255) NOT NULL,
  `Starih` varchar(19) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `ürünler`
--

CREATE TABLE `ürünler` (
  `kullaniciAdi` varchar(50) NOT NULL,
  `Ükodu` int(255) NOT NULL,
  `Üadı` varchar(50) NOT NULL,
  `Ütürü` varchar(50) NOT NULL,
  `Ümiktarbirimi` varchar(50) NOT NULL,
  `Ümiktar` int(255) NOT NULL,
  `ÜalışFıyatı` int(255) NOT NULL,
  `ÜsatışFıyatı` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Dumping data for table `ürünler`
--

INSERT INTO `ürünler` (`kullaniciAdi`, `Ükodu`, `Üadı`, `Ütürü`, `Ümiktarbirimi`, `Ümiktar`, `ÜalışFıyatı`, `ÜsatışFıyatı`) VALUES
('jalal market', 1123456, 'portakal', 'meyve', 'kg', 100, 10, 12),
('usama market', 1123456, 'elma', 'meyve', 'kg', 100, 10, 12),
('usama market', 1123654, 'şampuan', 'vücut bakımı', 'adet', 300, 20, 24);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `satış`
--
ALTER TABLE `satış`
  ADD PRIMARY KEY (`SatışId`);

--
-- Indexes for table `satışürün`
--
ALTER TABLE `satışürün`
  ADD PRIMARY KEY (`kullaniciAdi`,`Sid`,`ÜrünBk`);

--
-- Indexes for table `ürünler`
--
ALTER TABLE `ürünler`
  ADD PRIMARY KEY (`kullaniciAdi`,`Ükodu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
