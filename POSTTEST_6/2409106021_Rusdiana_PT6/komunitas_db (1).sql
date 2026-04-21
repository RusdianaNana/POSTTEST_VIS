-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Apr 2026 pada 16.34
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `komunitas_db`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `anggota`
--

CREATE TABLE `anggota` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `id_anggota` varchar(50) NOT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `jenis_kelamin` varchar(20) DEFAULT NULL,
  `komunitas` varchar(50) DEFAULT NULL,
  `no_hp` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `alamat` text DEFAULT NULL,
  `peran` varchar(50) DEFAULT NULL,
  `hobby` text DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbbuku`
--

CREATE TABLE `tbbuku` (
  `kodeBuku` varchar(5) NOT NULL,
  `kodeJenis` varchar(5) DEFAULT NULL,
  `judul` varchar(50) DEFAULT NULL,
  `pengarang` varchar(50) DEFAULT NULL,
  `penerbit` varchar(50) DEFAULT NULL,
  `jumlahBuku` int(11) DEFAULT NULL,
  `deskripsi` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbjenis`
--

CREATE TABLE `tbjenis` (
  `kodeJenis` varchar(5) NOT NULL,
  `jenis` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbjenis`
--

INSERT INTO `tbjenis` (`kodeJenis`, `jenis`) VALUES
('J001', 'Programming'),
('J002', 'Design'),
('J003', 'Gaming'),
('J004', 'Multimedia');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD PRIMARY KEY (`kodeBuku`),
  ADD KEY `kodeJenis` (`kodeJenis`);

--
-- Indeks untuk tabel `tbjenis`
--
ALTER TABLE `tbjenis`
  ADD PRIMARY KEY (`kodeJenis`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `anggota`
--
ALTER TABLE `anggota`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbbuku`
--
ALTER TABLE `tbbuku`
  ADD CONSTRAINT `tbbuku_ibfk_1` FOREIGN KEY (`kodeJenis`) REFERENCES `tbjenis` (`kodeJenis`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
