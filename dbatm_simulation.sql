-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 16, 2025 at 03:22 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbatm_simulation`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblaccountbalance`
--

CREATE TABLE `tblaccountbalance` (
  `Account_id` int(11) NOT NULL,
  `AccountNumber` int(11) NOT NULL,
  `BalanceAmount` decimal(12,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblaccountbalance`
--

INSERT INTO `tblaccountbalance` (`Account_id`, `AccountNumber`, `BalanceAmount`) VALUES
(1001, 12345678, 5985.50),
(1002, 12345679, 101000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbladmin_users`
--

CREATE TABLE `tbladmin_users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Staff') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbladmin_users`
--

INSERT INTO `tbladmin_users` (`UserID`, `Username`, `FullName`, `Password`, `Role`) VALUES
(10001, 'RV1cente', 'Ronnel John Vicente', 'Shish', 'Staff'),
(10002, 'Jblogs', 'Jb Lobrico', 'jblogs', 'Admin'),
(10003, 'xyhehe', 'Xyrylle Claire Matiga', 'xyxyxy', 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `tblreports`
--

CREATE TABLE `tblreports` (
  `ReportID` int(11) NOT NULL,
  `Status` enum('Completed','Failed','Pending') NOT NULL,
  `Description` varchar(255) NOT NULL,
  `CreatedAt` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `SettingID` int(11) NOT NULL,
  `SettingName` varchar(50) NOT NULL,
  `SettingValue` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction_history`
--

CREATE TABLE `tbltransaction_history` (
  `transaction_number` int(11) NOT NULL,
  `sender_AccountNumber` int(11) NOT NULL,
  `receiver_AccountNumber` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinfo`
--

CREATE TABLE `tbluserinfo` (
  `AccountNumber` int(20) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) NOT NULL,
  `EmailAddress` varchar(255) NOT NULL,
  `ContactNumber` int(11) NOT NULL,
  `PIN` int(11) NOT NULL,
  `attempts` int(11) NOT NULL,
  `Role` enum('Admin','User') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinfo`
--

INSERT INTO `tbluserinfo` (`AccountNumber`, `FirstName`, `LastName`, `MiddleName`, `EmailAddress`, `ContactNumber`, `PIN`, `attempts`, `Role`) VALUES
(1111, 'Admin', '  ', '  ', 'admin@gmail.com', 90900909, 11, 0, 'Admin'),
(12345678, 'Sean', 'Dope', 'Ty', 'SeanTyDope@gmail.com', 99999992, 0, 3, 'User'),
(12345679, 'Shoyou', 'Shish', 'Sho', 'shoyou@gmail.com', 90900909, 111111, 3, 'User');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblaccountbalance`
--
ALTER TABLE `tblaccountbalance`
  ADD PRIMARY KEY (`Account_id`),
  ADD KEY `AccountNumber` (`AccountNumber`);

--
-- Indexes for table `tbladmin_users`
--
ALTER TABLE `tbladmin_users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `tblreports`
--
ALTER TABLE `tblreports`
  ADD PRIMARY KEY (`ReportID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`SettingID`),
  ADD UNIQUE KEY `SettingName` (`SettingName`);

--
-- Indexes for table `tbltransaction_history`
--
ALTER TABLE `tbltransaction_history`
  ADD PRIMARY KEY (`transaction_number`),
  ADD KEY `receiver_AccountNumber` (`receiver_AccountNumber`),
  ADD KEY `sender_AccountNumber` (`sender_AccountNumber`);

--
-- Indexes for table `tbluserinfo`
--
ALTER TABLE `tbluserinfo`
  ADD PRIMARY KEY (`AccountNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbladmin_users`
--
ALTER TABLE `tbladmin_users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10004;

--
-- AUTO_INCREMENT for table `tblreports`
--
ALTER TABLE `tblreports`
  MODIFY `ReportID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `SettingID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbluserinfo`
--
ALTER TABLE `tbluserinfo`
  MODIFY `AccountNumber` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12345680;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblaccountbalance`
--
ALTER TABLE `tblaccountbalance`
  ADD CONSTRAINT `tblaccountbalance_ibfk_1` FOREIGN KEY (`AccountNumber`) REFERENCES `tbluserinfo` (`AccountNumber`);

--
-- Constraints for table `tbltransaction_history`
--
ALTER TABLE `tbltransaction_history`
  ADD CONSTRAINT `tbltransaction_history_ibfk_1` FOREIGN KEY (`receiver_AccountNumber`) REFERENCES `tbluserinfo` (`AccountNumber`),
  ADD CONSTRAINT `tbltransaction_history_ibfk_2` FOREIGN KEY (`sender_AccountNumber`) REFERENCES `tbluserinfo` (`AccountNumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
