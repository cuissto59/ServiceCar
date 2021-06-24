CREATE DATABASE  IF NOT EXISTS `servicecar` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `servicecar`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: servicecar
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `conductor`
--

DROP TABLE IF EXISTS `conductor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conductor` (
  `user` int NOT NULL,
  `cin` varchar(20) NOT NULL,
  `telephone_number` int NOT NULL,
  `adress` varchar(100) NOT NULL,
  `active` bit(1) NOT NULL,
  PRIMARY KEY (`user`) USING BTREE,
  CONSTRAINT `conductor_ibfk_1` FOREIGN KEY (`user`) REFERENCES `user` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conductor`
--

LOCK TABLES `conductor` WRITE;
/*!40000 ALTER TABLE `conductor` DISABLE KEYS */;
INSERT INTO `conductor` VALUES (2,'AE2039343',615553583,'Kenitra',_binary ''),(5,'AB12620',661394430,'salé',_binary '');
/*!40000 ALTER TABLE `conductor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `f_name` varchar(20) NOT NULL,
  `l_name` varchar(20) NOT NULL,
  `login` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL,
  `is_admin` bit(1) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Ahmed','mahmoud','admin','admin',_binary ''),(2,'Ahmed','mahmoud','conductor2','conductor2',_binary '\0'),(3,'Ahmed','mahmoud','ahmedken111@gmail.co','password',_binary '\0'),(5,'taha','lahrizi','conductor1','conductor1',_binary '\0');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `id_vehicle` int NOT NULL AUTO_INCREMENT,
  `vehicle_conductor` int NOT NULL,
  `img` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `in_use` bit(1) NOT NULL,
  PRIMARY KEY (`id_vehicle`),
  KEY `vehicle_conductor` (`vehicle_conductor`),
  CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`vehicle_conductor`) REFERENCES `conductor` (`user`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (2,5,'test.jpg','Yaris city',_binary ''),(4,2,'7.png','suzuki',_binary '\0'),(6,2,'trest.jpg','Dacia sandero',_binary '');
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_accident`
--

DROP TABLE IF EXISTS `vehicle_accident`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_accident` (
  `id_vehicle_ac` int NOT NULL,
  `type` varchar(50) NOT NULL,
  `damage_description` text NOT NULL,
  `was_insured` bit(1) DEFAULT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id_vehicle_ac`) USING BTREE,
  CONSTRAINT `vehicle_accident_ibfk_1` FOREIGN KEY (`id_vehicle_ac`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_accident`
--

LOCK TABLES `vehicle_accident` WRITE;
/*!40000 ALTER TABLE `vehicle_accident` DISABLE KEYS */;
INSERT INTO `vehicle_accident` VALUES (2,'moyenne','parchoc et led far endomagees',_binary '\0','2021-06-25 05:54:29'),(4,'grave','chasis et moteurs detruit',_binary '','2011-09-15 03:14:39');
/*!40000 ALTER TABLE `vehicle_accident` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_breakdown`
--

DROP TABLE IF EXISTS `vehicle_breakdown`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_breakdown` (
  `id_breakdown` int NOT NULL AUTO_INCREMENT,
  `id_vehicle_bd` int NOT NULL,
  `problem` varchar(50) NOT NULL,
  `description` text NOT NULL,
  PRIMARY KEY (`id_breakdown`),
  KEY `id_vehicle_bd` (`id_vehicle_bd`),
  CONSTRAINT `vehicle_breakdown_ibfk_1` FOREIGN KEY (`id_vehicle_bd`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_breakdown`
--

LOCK TABLES `vehicle_breakdown` WRITE;
/*!40000 ALTER TABLE `vehicle_breakdown` DISABLE KEYS */;
INSERT INTO `vehicle_breakdown` VALUES (1,4,'signal de contact en panne','le signal a ete endommager'),(2,2,'probleme de vidange','depassement du cota du vidange');
/*!40000 ALTER TABLE `vehicle_breakdown` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_buy_contract`
--

DROP TABLE IF EXISTS `vehicle_buy_contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_buy_contract` (
  `id_vehicle_bc` int NOT NULL,
  `provider` varchar(30) DEFAULT NULL,
  `buy_date` date DEFAULT NULL,
  `contract_number` varchar(50) DEFAULT NULL,
  `warranty_years` int DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `tva` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_vehicle_bc`) USING BTREE,
  CONSTRAINT `vehicle_buy_contract_ibfk_1` FOREIGN KEY (`id_vehicle_bc`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_buy_contract`
--

LOCK TABLES `vehicle_buy_contract` WRITE;
/*!40000 ALTER TABLE `vehicle_buy_contract` DISABLE KEYS */;
INSERT INTO `vehicle_buy_contract` VALUES (2,'toyota house','2014-06-09','145',5,120000.00,2.00),(4,'3rd party seller','2010-06-04','14597',2,200000.00,0.40),(6,'reanult-dacia maison','2007-09-20','2367',5,145200.00,2.00);
/*!40000 ALTER TABLE `vehicle_buy_contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_fuel`
--

DROP TABLE IF EXISTS `vehicle_fuel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_fuel` (
  `id_sp_fu` int NOT NULL,
  `quantity` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id_sp_fu`) USING BTREE,
  CONSTRAINT `vehicle_fuel_ibfk_1` FOREIGN KEY (`id_sp_fu`) REFERENCES `vehicle_spending` (`id_sp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_fuel`
--

LOCK TABLES `vehicle_fuel` WRITE;
/*!40000 ALTER TABLE `vehicle_fuel` DISABLE KEYS */;
INSERT INTO `vehicle_fuel` VALUES (1,15.00);
/*!40000 ALTER TABLE `vehicle_fuel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_general_info`
--

DROP TABLE IF EXISTS `vehicle_general_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_general_info` (
  `id_vehicle_gi` int NOT NULL,
  `matricul_number` varchar(30) NOT NULL,
  `code` varchar(20) NOT NULL,
  `grey_card` varchar(20) NOT NULL,
  `chassis_number` varchar(20) NOT NULL,
  `vehicle_type` enum('Voiture','Camion') NOT NULL,
  `acquisition` enum('ACHAT') NOT NULL,
  `mark` varchar(20) NOT NULL,
  `model` varchar(20) NOT NULL,
  `model_year` int NOT NULL,
  `in_use_yr` int NOT NULL,
  `km` int NOT NULL,
  `body_type` varchar(30) NOT NULL,
  `fuel_type` enum('DIESEL','ESSENCE','HYBRIDE','ELECTRIQUE') NOT NULL,
  PRIMARY KEY (`id_vehicle_gi`) USING BTREE,
  CONSTRAINT `vehicle_general_info_ibfk_1` FOREIGN KEY (`id_vehicle_gi`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_general_info`
--

LOCK TABLES `vehicle_general_info` WRITE;
/*!40000 ALTER TABLE `vehicle_general_info` DISABLE KEYS */;
INSERT INTO `vehicle_general_info` VALUES (2,'17458-أ-2','123','11111','148799','Voiture','ACHAT','toyota','yaris ',2014,2015,123000,'chasis','DIESEL'),(4,'15697-أ-59','111','78945','1220','Camion','ACHAT','suzuki','pick up',2011,2017,1456000,'chasis','DIESEL');
/*!40000 ALTER TABLE `vehicle_general_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_maintenance_plan`
--

DROP TABLE IF EXISTS `vehicle_maintenance_plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_maintenance_plan` (
  `id_vehicle_mp` int NOT NULL,
  `description` text NOT NULL,
  PRIMARY KEY (`id_vehicle_mp`) USING BTREE,
  CONSTRAINT `vehicle_maintenance_plan_ibfk_1` FOREIGN KEY (`id_vehicle_mp`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_maintenance_plan`
--

LOCK TABLES `vehicle_maintenance_plan` WRITE;
/*!40000 ALTER TABLE `vehicle_maintenance_plan` DISABLE KEYS */;
INSERT INTO `vehicle_maintenance_plan` VALUES (2,'lorem ipsum'),(4,'cogito decarte');
/*!40000 ALTER TABLE `vehicle_maintenance_plan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_reparation`
--

DROP TABLE IF EXISTS `vehicle_reparation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_reparation` (
  `id_vehicle_re` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id_vehicle_re`) USING BTREE,
  CONSTRAINT `vehicle_reparation_ibfk_1` FOREIGN KEY (`id_vehicle_re`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_reparation`
--

LOCK TABLES `vehicle_reparation` WRITE;
/*!40000 ALTER TABLE `vehicle_reparation` DISABLE KEYS */;
INSERT INTO `vehicle_reparation` VALUES (2,2000.00,'2021-06-23 12:36:37');
/*!40000 ALTER TABLE `vehicle_reparation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_services`
--

DROP TABLE IF EXISTS `vehicle_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_services` (
  `id_vehicle_se` int NOT NULL,
  `type` varchar(20) NOT NULL,
  `km` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  PRIMARY KEY (`id_vehicle_se`) USING BTREE,
  CONSTRAINT `vehicle_services_ibfk_1` FOREIGN KEY (`id_vehicle_se`) REFERENCES `vehicle` (`id_vehicle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_services`
--

LOCK TABLES `vehicle_services` WRITE;
/*!40000 ALTER TABLE `vehicle_services` DISABLE KEYS */;
INSERT INTO `vehicle_services` VALUES (2,'vacant',120000,1405.00,'2021-06-23 12:31:06','2021-06-23 12:31:10'),(4,'vacant',14022,1470.00,'2021-06-23 12:31:48','2021-06-23 12:31:54');
/*!40000 ALTER TABLE `vehicle_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_spending`
--

DROP TABLE IF EXISTS `vehicle_spending`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_spending` (
  `id_sp` int NOT NULL AUTO_INCREMENT,
  `id_vehicle_sp` int NOT NULL,
  `id_conductor_sp` int NOT NULL,
  `date_sp` date NOT NULL,
  `time_sp` time NOT NULL,
  `type` varchar(20) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id_sp`) USING BTREE,
  KEY `id_vehicle_sp` (`id_vehicle_sp`),
  KEY `id_conductor_sp` (`id_conductor_sp`),
  CONSTRAINT `vehicle_spending_ibfk_1` FOREIGN KEY (`id_vehicle_sp`) REFERENCES `vehicle` (`id_vehicle`),
  CONSTRAINT `vehicle_spending_ibfk_2` FOREIGN KEY (`id_conductor_sp`) REFERENCES `conductor` (`user`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_spending`
--

LOCK TABLES `vehicle_spending` WRITE;
/*!40000 ALTER TABLE `vehicle_spending` DISABLE KEYS */;
INSERT INTO `vehicle_spending` VALUES (1,2,5,'2021-06-02','02:00:00','vacant',200.00),(2,4,2,'2020-04-02','01:00:00','vacant',450.00);
/*!40000 ALTER TABLE `vehicle_spending` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-24 19:15:14
