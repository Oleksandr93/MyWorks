CREATE DATABASE  IF NOT EXISTS `utos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `utos`;
-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: utos
-- ------------------------------------------------------
-- Server version	5.6.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `members` (
  `id` bigint(16) NOT NULL AUTO_INCREMENT,
  `fname` varchar(64) NOT NULL,
  `lname` varchar(64) NOT NULL,
  `mname` varchar(64) DEFAULT NULL,
  `ticket_number` varchar(64) NOT NULL,
  `reg_date` date NOT NULL,
  `foto` longblob,
  `idcode` varchar(16) DEFAULT NULL,
  `nationality` varchar(64) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `education` varchar(64) DEFAULT NULL,
  `speciality` varchar(64) DEFAULT NULL,
  `point_system` varchar(64) DEFAULT NULL,
  `disability_group` varchar(64) DEFAULT NULL,
  `disability_cause` varchar(64) DEFAULT NULL,
  `extra_injury` varchar(256) DEFAULT NULL,
  `martial_status` varchar(64) DEFAULT NULL,
  `welfare` decimal(16,2) DEFAULT NULL,
  `employer` varchar(64) DEFAULT NULL,
  `position` varchar(64) DEFAULT NULL,
  `employer_last` varchar(64) DEFAULT NULL,
  `position_last` varchar(64) DEFAULT NULL,
  `passport_sn` varchar(8) DEFAULT NULL,
  `passport_number` varchar(16) DEFAULT NULL,
  `passport_date` date DEFAULT NULL,
  `passport_issuer` varchar(128) DEFAULT NULL,
  `address` varchar(128) DEFAULT NULL,
  `phone` varchar(16) DEFAULT NULL,
  `pension_card_number` varchar(32) DEFAULT NULL,
  `pension_card_date` date DEFAULT NULL,
  `social_impact` varchar(1024) DEFAULT NULL,
  `affiliation_fee` decimal(16,2) DEFAULT NULL,
  `affiliation_date` date DEFAULT NULL,
  `sign_date` date DEFAULT NULL,
  `id_org` bigint(16) DEFAULT NULL,
  `family_members` blob,
  `org_relations` blob,
  `payments` blob,
  `welfare_assistance` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COMMENT='UTOS Members';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `organizations`
--

DROP TABLE IF EXISTS `organizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `organizations` (
  `id` bigint(16) NOT NULL AUTO_INCREMENT,
  `name` varchar(64) NOT NULL,
  `chief_name` varchar(64) DEFAULT NULL,
  `secretary_name` varchar(64) DEFAULT NULL,
  `staff` blob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-24  8:22:57
