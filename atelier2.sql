-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le : mar. 13 mai 2025 à 10:53
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelier2`
--
CREATE DATABASE IF NOT EXISTS `atelier2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `atelier2`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(10, '2024-06-01 04:10:58', '2025-11-24 14:10:08', 1),
(9, '2024-05-24 19:00:50', '2024-05-08 20:35:56', 1),
(8, '2025-04-01 21:35:03', '2026-02-19 21:26:49', 2),
(7, '2025-08-10 08:50:37', '2024-06-06 23:31:49', 2),
(9, '2024-08-02 01:04:07', '2025-10-03 12:28:26', 1),
(4, '2025-11-13 02:38:57', '2026-01-21 19:44:42', 1),
(5, '2025-08-14 17:13:55', '2025-06-14 07:42:23', 2),
(9, '2026-01-16 14:26:58', '2024-12-23 21:01:43', 3),
(10, '2025-05-04 13:02:29', '2025-01-22 17:39:15', 4),
(5, '2025-03-30 22:15:36', '2025-03-20 19:41:54', 1),
(7, '2024-05-12 06:45:01', '2025-01-14 00:32:51', 2),
(1, '2026-01-13 18:53:41', '2024-08-03 22:36:49', 1),
(3, '2025-12-21 20:21:25', '2024-05-04 11:24:27', 2),
(10, '2026-01-31 18:19:30', '2025-10-21 20:31:40', 2),
(3, '2026-03-26 01:42:05', '2024-07-23 19:34:15', 2),
(3, '2026-02-01 11:15:18', '2025-04-15 09:23:01', 2),
(4, '2025-12-10 09:09:47', '2024-12-23 22:35:04', 1),
(5, '2026-01-01 04:13:49', '2025-08-01 08:48:22', 4),
(5, '2025-05-26 18:34:29', '2025-04-06 19:06:45', 1),
(6, '2025-08-23 23:04:52', '2025-03-10 00:09:33', 3),
(1, '2024-10-03 15:06:07', '2024-10-16 09:46:04', 2),
(3, '2025-02-15 02:36:11', '2025-07-21 11:12:45', 4),
(10, '2024-04-16 10:31:06', '2026-03-14 21:54:47', 2),
(7, '2026-04-02 09:26:24', '2026-01-20 16:57:51', 2),
(6, '2025-05-16 13:24:58', '2024-12-26 21:47:07', 2),
(7, '2024-11-08 06:06:32', '2025-06-19 03:42:13', 4),
(7, '2024-12-14 09:19:02', '2025-09-06 19:45:57', 1),
(1, '2025-07-15 08:27:29', '2024-08-20 04:06:06', 3),
(10, '2025-10-01 09:39:16', '2024-05-15 05:49:22', 3),
(5, '2026-04-12 18:02:32', '2025-07-30 05:37:06', 2),
(6, '2024-09-26 23:51:04', '2024-12-09 12:45:44', 3),
(2, '2026-01-15 17:36:33', '2025-05-11 03:15:48', 1),
(1, '2024-07-11 04:20:44', '2025-09-19 12:46:20', 4),
(9, '2025-12-11 20:41:12', '2024-11-16 21:02:28', 3),
(10, '2024-07-28 08:23:53', '2024-05-28 00:32:46', 4),
(10, '2024-08-23 21:10:47', '2024-04-25 16:14:06', 3),
(10, '2025-03-13 07:01:20', '2025-10-16 14:49:47', 2),
(3, '2024-07-13 15:31:39', '2025-11-30 10:40:29', 2),
(8, '2025-01-05 18:06:41', '2025-01-26 05:03:15', 4),
(3, '2024-07-05 11:06:48', '2025-11-07 23:51:52', 4),
(3, '2026-04-10 08:43:26', '2026-02-13 13:11:40', 2),
(7, '2024-10-05 22:59:39', '2025-02-23 13:42:48', 2),
(8, '2024-12-16 15:24:12', '2025-02-15 13:23:04', 2),
(6, '2025-07-18 21:53:04', '2026-02-07 17:18:30', 3),
(9, '2025-08-09 03:01:06', '2025-03-01 01:20:19', 2),
(4, '2026-04-10 16:04:02', '2025-03-11 07:14:53', 3),
(8, '2024-05-12 14:34:08', '2025-06-15 00:53:21', 3),
(1, '2026-02-14 13:30:46', '2024-06-20 00:09:08', 2),
(8, '2025-06-05 20:01:42', '2024-06-24 22:32:46', 3),
(9, '2024-10-14 04:37:34', '2024-07-23 19:26:09', 2),
(10, '2025-05-01 00:00:00', '2025-05-05 00:00:00', 1),
(10, '2025-05-03 00:00:00', '2025-05-09 00:00:00', 3),
(10, '2025-04-01 00:00:00', '2025-04-30 00:00:00', 1),
(1, '2025-05-01 00:00:00', '2025-05-08 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Hyacinth', 'Lang', '09 15 97 55 61', 'pharetra.ut.pharetra@yahoo.net', 1),
(2, 'Philip', 'Becker', '04 53 83 69 19', 'enim@hotmail.ca', 2),
(3, 'Larissa', 'Hawkins', '08 86 67 61 99', 'erat.volutpat@aol.edu', 3),
(4, 'Tiger', 'Justice', '07 70 65 53 33', 'suspendisse.eleifend@yahoo.com', 1),
(5, 'Travis', 'Rosales', '02 24 17 82 56', 'tincidunt.donec@icloud.couk', 3),
(6, 'Indira', 'Elliott', '01 98 02 14 86', 'curae.phasellus.ornare@outlook.com', 2),
(7, 'Zeus', 'Sosa', '04 32 56 37 36', 'placerat.cras@protonmail.org', 3),
(8, 'Karina', 'Dickerson', '09 26 73 91 86', 'proin@icloud.com', 2),
(9, 'Lance', 'Winters', '02 18 25 46 95', 'gravida.aliquam@protonmail.net', 1),
(10, 'Beverly', 'Harmon', '04 27 59 22 35', 'commodo.auctor@outlook.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('HCAtelier2', 'b909c6702e754e2401640e5f77739027c0c9dd32c871bf8ccf31bc16f8334552');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


-- Création de l'utilisateur avec un mot de passe
CREATE USER 'HCAtelier2'@'localhost' IDENTIFIED BY 'azerty1234';

-- Autorise l'utilisation de MySQL
GRANT USAGE ON *.* TO 'HCAtelier2'@'localhost';

-- Donne tous les privilèges sur la base `atelier2`
GRANT ALL PRIVILEGES ON `atelier2`.* TO 'HCAtelier2'@'localhost';

-- Applique les changements
FLUSH PRIVILEGES;