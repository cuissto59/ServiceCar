-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : Dim 20 juin 2021 à 19:42
-- Version du serveur :  10.4.17-MariaDB
-- Version de PHP : 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `servicecar`
--
drop database if exists serviceCar;
create database serviceCar;
use serviceCar;
-- --------------------------------------------------------

--
-- Structure de la table `conductor`
--

CREATE TABLE `conductor` (
  `user` int(11) NOT NULL,
  `cin` varchar(20) NOT NULL,
  `telephone_number` int(10) NOT NULL,
  `adress` varchar(100) NOT NULL,
  `active` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id_user` int(5) NOT NULL,
  `f_name` varchar(20) NOT NULL,
  `l_name` varchar(20) NOT NULL,
  `login` varchar(20) NOT NULL,
  `password` varchar(64) NOT NULL,
  `is_admin` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id_user`, `f_name`, `l_name`, `login`, `password`, `is_admin`) VALUES
(1, 'Ahmed', 'mahmoud', 'ahmedken111@gmail.co', 'password', b'1'),
(2, 'Ahmed', 'mahmoud', 'ahmedken111@gmail.co', 'password', b'0'),
(3, 'Ahmed', 'mahmoud', 'ahmedken111@gmail.co', 'password', b'0');

-- --------------------------------------------------------

--
-- Structure de la table `vehicle`
--

CREATE TABLE `vehicle` (
  `id_vehicle` int(5) NOT NULL,
  `vehicle_conductor` int(11) NOT NULL,
  `img` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `in_use` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_accident`
--

CREATE TABLE `vehicle_accident` (
  `id_vehicle_ac` int(5) NOT NULL,
  `type` varchar(50) NOT NULL,
  `damage_description` text NOT NULL,
  `was_insured` bit(1) DEFAULT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_breakdown`
--

CREATE TABLE `vehicle_breakdown` (
  `id_breakdown` int(5) NOT NULL,
  `id_vehicle_bd` int(5) NOT NULL,
  `problem` varchar(50) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_buy_contract`
--

CREATE TABLE `vehicle_buy_contract` (
  `id_vehicle_bc` int(11) NOT NULL,
  `provider` varchar(30) DEFAULT NULL,
  `buy_date` date DEFAULT NULL,
  `contract_number` varchar(50) DEFAULT NULL,
  `warranty_years` int(2) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `tva` decimal(2,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_fuel`
--

CREATE TABLE `vehicle_fuel` (
  `id_sp_fu` int(5) NOT NULL,
  `quantity` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_general_info`
--

CREATE TABLE `vehicle_general_info` (
  `id_vehicle_gi` int(11) NOT NULL,
  `matricul_number` varchar(30) NOT NULL,
  `code` varchar(20) NOT NULL,
  `grey_card` varchar(20) NOT NULL,
  `chassis_number` varchar(20) NOT NULL,
  `vehicle_type` enum('Voiture','Camion') NOT NULL,
  `acquisition` enum('ACHAT') NOT NULL,
  `mark` varchar(20) NOT NULL,
  `model` varchar(20) NOT NULL,
  `model_year` int(4) NOT NULL,
  `in_use_yr` int(4) NOT NULL,
  `km` int(11) NOT NULL,
  `body_type` varchar(30) NOT NULL,
  `fuel_type` enum('DIESEL','ESSENCE','HYBRIDE','ELECTRIQUE') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_maintenance_plan`
--

CREATE TABLE `vehicle_maintenance_plan` (
  `id_vehicle_mp` int(5) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_reparation`
--

CREATE TABLE `vehicle_reparation` (
  `id_vehicle_re` int(5) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_services`
--

CREATE TABLE `vehicle_services` (
  `id_vehicle_se` int(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `km` int(11) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `vehicle_spending`
--

CREATE TABLE `vehicle_spending` (
  `id_sp` int(5) NOT NULL,
  `id_vehicle_sp` int(5) NOT NULL,
  `id_conductor_sp` int(5) NOT NULL,
  `date_sp` date NOT NULL,
  `time_sp` time NOT NULL,
  `type` varchar(20) NOT NULL,
  `amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `conductor`
--
ALTER TABLE `conductor`
  ADD PRIMARY KEY (`user`) USING BTREE;

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- Index pour la table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`id_vehicle`),
  ADD KEY `vehicle_conductor` (`vehicle_conductor`);

--
-- Index pour la table `vehicle_accident`
--
ALTER TABLE `vehicle_accident`
  ADD PRIMARY KEY (`id_vehicle_ac`) USING BTREE;

--
-- Index pour la table `vehicle_breakdown`
--
ALTER TABLE `vehicle_breakdown`
  ADD PRIMARY KEY (`id_breakdown`),
  ADD KEY `id_vehicle_bd` (`id_vehicle_bd`);

--
-- Index pour la table `vehicle_buy_contract`
--
ALTER TABLE `vehicle_buy_contract`
  ADD PRIMARY KEY (`id_vehicle_bc`) USING BTREE;

--
-- Index pour la table `vehicle_fuel`
--
ALTER TABLE `vehicle_fuel`
  ADD PRIMARY KEY (`id_sp_fu`) USING BTREE;

--
-- Index pour la table `vehicle_general_info`
--
ALTER TABLE `vehicle_general_info`
  ADD PRIMARY KEY (`id_vehicle_gi`) USING BTREE;

--
-- Index pour la table `vehicle_maintenance_plan`
--
ALTER TABLE `vehicle_maintenance_plan`
  ADD PRIMARY KEY (`id_vehicle_mp`) USING BTREE;

--
-- Index pour la table `vehicle_reparation`
--
ALTER TABLE `vehicle_reparation`
  ADD PRIMARY KEY (`id_vehicle_re`) USING BTREE;

--
-- Index pour la table `vehicle_services`
--
ALTER TABLE `vehicle_services`
  ADD PRIMARY KEY (`id_vehicle_se`) USING BTREE;

--
-- Index pour la table `vehicle_spending`
--
ALTER TABLE `vehicle_spending`
  ADD PRIMARY KEY (`id_sp`) USING BTREE,
  ADD KEY `id_vehicle_sp` (`id_vehicle_sp`),
  ADD KEY `id_conductor_sp` (`id_conductor_sp`);

--
-- Index pour la table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `vehicle`
--
ALTER TABLE `vehicle`
  MODIFY `id_vehicle` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `vehicle_breakdown`
--
ALTER TABLE `vehicle_breakdown`
  MODIFY `id_breakdown` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `vehicle_spending`
--
ALTER TABLE `vehicle_spending`
  MODIFY `id_sp` int(5) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `conductor`
--
ALTER TABLE `conductor`
  ADD CONSTRAINT `conductor_ibfk_1` FOREIGN KEY (`user`) REFERENCES `user` (`id_user`);

--
-- Contraintes pour la table `vehicle`
--
ALTER TABLE `vehicle`
  ADD CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`vehicle_conductor`) REFERENCES `conductor` (`user`);

--
-- Contraintes pour la table `vehicle_accident`
--
ALTER TABLE `vehicle_accident`
  ADD CONSTRAINT `vehicle_accident_ibfk_1` FOREIGN KEY (`id_vehicle_ac`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_breakdown`
--
ALTER TABLE `vehicle_breakdown`
  ADD CONSTRAINT `vehicle_breakdown_ibfk_1` FOREIGN KEY (`id_vehicle_bd`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_buy_contract`
--
ALTER TABLE `vehicle_buy_contract`
  ADD CONSTRAINT `vehicle_buy_contract_ibfk_1` FOREIGN KEY (`id_vehicle_bc`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_fuel`
--
ALTER TABLE `vehicle_fuel`
  ADD CONSTRAINT `vehicle_fuel_ibfk_1` FOREIGN KEY (`id_sp_fu`) REFERENCES `vehicle_spending` (`id_sp`);

--
-- Contraintes pour la table `vehicle_general_info`
--
ALTER TABLE `vehicle_general_info`
  ADD CONSTRAINT `vehicle_general_info_ibfk_1` FOREIGN KEY (`id_vehicle_gi`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_maintenance_plan`
--
ALTER TABLE `vehicle_maintenance_plan`
  ADD CONSTRAINT `vehicle_maintenance_plan_ibfk_1` FOREIGN KEY (`id_vehicle_mp`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_reparation`
--
ALTER TABLE `vehicle_reparation`
  ADD CONSTRAINT `vehicle_reparation_ibfk_1` FOREIGN KEY (`id_vehicle_re`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_services`
--
ALTER TABLE `vehicle_services`
  ADD CONSTRAINT `vehicle_services_ibfk_1` FOREIGN KEY (`id_vehicle_se`) REFERENCES `vehicle` (`id_vehicle`);

--
-- Contraintes pour la table `vehicle_spending`
--
ALTER TABLE `vehicle_spending`
  ADD CONSTRAINT `vehicle_spending_ibfk_1` FOREIGN KEY (`id_vehicle_sp`) REFERENCES `vehicle` (`id_vehicle`),
  ADD CONSTRAINT `vehicle_spending_ibfk_2` FOREIGN KEY (`id_conductor_sp`) REFERENCES `conductor` (`user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
