-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 29, 2021 lúc 04:23 AM
-- Phiên bản máy phục vụ: 10.4.18-MariaDB
-- Phiên bản PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `champion_ship`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `doi_bong`
--

CREATE TABLE `doi_bong` (
  `ma` varchar(255) CHARACTER SET utf8 NOT NULL,
  `ten` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `hlv` varchar(255) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `doi_bong`
--

INSERT INTO `doi_bong` (`ma`, `ten`, `hlv`) VALUES
('A001', 'T2009A', 'Xuan Hung'),
('A002', 'T2008', 'Dang Van Hoa'),
('A004', 'T2009', 'Hong Luyen'),
('A005', 'T8686', 'Tran Duc'),
('A006', 'T2021', 'Dao Hung Xuan');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `lich_thi_dau`
--

CREATE TABLE `lich_thi_dau` (
  `ma_tran_dau` varchar(255) NOT NULL,
  `tran` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `ngay` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `gio` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `san` varchar(255) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `lich_thi_dau`
--

INSERT INTO `lich_thi_dau` (`ma_tran_dau`, `tran`, `ngay`, `gio`, `san`) VALUES
('2039', 'T2009A vs T8686', '01/01/2022', '18h', 'FPT Aptech'),
('9838', 'T2009 VS T2021', '01/01/2021', '18h', 'FPT Aptech'),
('9850', 'T2009 VS T2021', '01/01/2022', '18h', 'FPT Aptech');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `doi_bong`
--
ALTER TABLE `doi_bong`
  ADD PRIMARY KEY (`ma`);

--
-- Chỉ mục cho bảng `lich_thi_dau`
--
ALTER TABLE `lich_thi_dau`
  ADD PRIMARY KEY (`ma_tran_dau`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
