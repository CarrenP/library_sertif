-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 10, 2026 at 07:13 PM
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
-- Database: `library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `title` varchar(100) DEFAULT NULL,
  `author` varchar(100) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `stock`) VALUES
(1, 'Clean Code', 'Robert C. Martin', 5),
(2, 'Introduction to Java', 'Herbert Schildt', 2),
(3, 'Database Systems', 'Raghu Ramakrishnan', 4),
(4, 'Design Patterns', 'Erich Gamma', 2),
(5, 'Operating Systems', 'Silberschatz', 6),
(6, 'Computer Networks', 'Andrew S. Tanenbaum', 3),
(7, 'Software Engineering', 'Ian Sommerville', 4),
(9, 'Data Structures', 'Mark Allen Weiss', 4),
(10, 'Artificial Intelligence', 'Stuart Russell', 2),
(11, 'Scandalicious Sibling ', 'Jennifer Core', 3),
(12, 'Web Programming', 'John Doe', 1);

-- --------------------------------------------------------

--
-- Table structure for table `loans`
--

CREATE TABLE `loans` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `book_id` int(11) DEFAULT NULL,
  `loan_date` date DEFAULT NULL,
  `due_date` date DEFAULT NULL,
  `returned_date` date DEFAULT NULL,
  `is_returned` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loans`
--

INSERT INTO `loans` (`id`, `user_id`, `book_id`, `loan_date`, `due_date`, `returned_date`, `is_returned`) VALUES
(31, 3, NULL, '2025-12-31', '2026-01-07', NULL, 0),
(32, 4, NULL, '2026-01-05', '2026-01-12', NULL, 0),
(33, 5, NULL, '2026-01-08', '2026-01-15', NULL, 0),
(34, 6, NULL, '2026-01-02', '2026-01-09', NULL, 0),
(35, 7, NULL, '2026-01-09', '2026-01-16', NULL, 0),
(36, 8, NULL, '2026-01-04', '2026-01-11', NULL, 0),
(37, 9, NULL, '2026-01-01', '2026-01-08', NULL, 0),
(38, 10, NULL, '2026-01-07', '2026-01-14', NULL, 0),
(39, 11, NULL, '2026-01-06', '2026-01-13', NULL, 0),
(40, 12, NULL, '2026-01-10', '2026-01-17', NULL, 0),
(41, 4, 1, '2026-01-10', '2026-01-17', '2026-01-10', 1),
(42, 4, 2, '2026-01-10', '2026-01-17', NULL, 0),
(43, 4, 7, '2026-01-10', '2026-01-17', NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `member_id` varchar(10) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(10) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `address` text DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `sex` enum('M','F') DEFAULT NULL,
  `age` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `member_id`, `password`, `role`, `name`, `address`, `email`, `sex`, `age`) VALUES
(3, 'MEM0001', 'user123', 'USER', 'carren', 'surabaya', 'carren@gmai.com', 'F', 21),
(4, 'MEM0002', 'user345', 'USER', 'cathlin', 'kediri', 'cath@gmail.com', '', 23),
(5, 'MEM0003', '123', 'USER', 'Charlie', 'Surabaya', 'charlie@mail.com', 'M', 23),
(6, 'MEM0004', '123', 'USER', 'Diana', 'Malang', 'diana@mail.com', 'F', 20),
(7, 'MEM0005', '123', 'USER', 'Evan', 'Solo', 'evan@mail.com', 'M', 24),
(8, 'MEM0006', '123', 'USER', 'Fiona', 'Jogja', 'fiona@mail.com', 'F', 22),
(9, 'MEM0007', '123', 'USER', 'Gilang', 'Semarang', 'gilang@mail.com', 'M', 21),
(10, 'MEM0008', '123', 'USER', 'Hana', 'Depok', 'hana@mail.com', 'F', 23),
(11, 'MEM0009', '123', 'USER', 'Ivan', 'Bekasi', 'ivan@mail.com', 'M', 25),
(12, 'ADM0001', 'admin', 'ADMIN', 'Admin', 'Office', 'admin@mail.com', 'M', 30);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `loans`
--
ALTER TABLE `loans`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `book_id` (`book_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `member_id` (`member_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `loans`
--
ALTER TABLE `loans`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `loans`
--
ALTER TABLE `loans`
  ADD CONSTRAINT `loans_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `loans_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `books` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
