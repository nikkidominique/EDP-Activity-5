CREATE DATABASE  IF NOT EXISTS `employee_sys` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `employee_sys`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: employee_sys
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `assignment`
--

DROP TABLE IF EXISTS `assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assignment` (
  `AssID` varchar(45) NOT NULL,
  `Title` varchar(45) DEFAULT NULL,
  `StartDate` datetime DEFAULT NULL,
  `StopDate` datetime DEFAULT NULL,
  PRIMARY KEY (`AssID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assignment`
--

LOCK TABLES `assignment` WRITE;
/*!40000 ALTER TABLE `assignment` DISABLE KEYS */;
INSERT INTO `assignment` VALUES ('Ads3','Advertisement','2015-08-20 00:00:00','2016-12-12 00:00:00'),('Bus2','Business Planning','2022-05-06 00:00:00','2023-05-09 00:00:00'),('Cyb2','Cyber Security','2020-02-02 00:00:00','2023-02-05 00:00:00'),('Fin','Accounting and Auditing','2015-02-02 00:00:00','2017-03-03 00:00:00'),('IT5','Emerency Recovery','2020-09-09 00:00:00','2020-12-17 00:00:00'),('Law2','Law Enforcement','2020-03-28 00:00:00','2025-03-28 00:00:00'),('Law5','Blockchain','2023-01-01 00:00:00','2024-12-30 00:00:00'),('Mar1','Digital Marketing Agency','2018-09-18 00:00:00','2022-03-28 00:00:00'),('Net1','Network Address Translator','2019-01-01 00:00:00','2022-12-30 00:00:00'),('Net3','Network Configuration','2022-12-03 00:00:00','2022-12-30 00:00:00');
/*!40000 ALTER TABLE `assignment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EmployeeID` varchar(45) NOT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `AssID` varchar(45) DEFAULT NULL,
  `SupervisorID` int DEFAULT NULL,
  `JobID` int DEFAULT NULL,
  `Salary` decimal(10,0) DEFAULT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`EmployeeID`),
  KEY `SupervisorID_idx` (`SupervisorID`),
  KEY `AssID_idx` (`AssID`),
  KEY `JobID_idx` (`JobID`),
  CONSTRAINT `AssID` FOREIGN KEY (`AssID`) REFERENCES `assignment` (`AssID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `JobID` FOREIGN KEY (`JobID`) REFERENCES `job_type` (`JobID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `SupervisorID` FOREIGN KEY (`SupervisorID`) REFERENCES `supervisor` (`SupervisorID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('emp1','Abogadie','Nikki','Law2',3,44,200000,'emp1Nikki'),('emp10','Hadid','Gigi','Net1',2,11,4500,'emp10Gigi'),('emp1000','Hadid','Gigi','Net1',2,11,4500,'emp10Gigi'),('emp11','Hadid','Gigi','Net1',2,11,4500,'emp10Gigi'),('emp2','Kim','Jennie','Ads3',2,33,10000,'emp2Jennie'),('emp21','Sample','Lang','Law2',3,44,200000,'Sample'),('emp22','Kim','Jennie','Ads3',2,33,10000,'emp2Jennie'),('emp221','Sample','Lang','Law2',3,44,200000,'Sample'),('emp246','Sample','Lang','Law2',3,44,200000,'Sample'),('emp3','Kim','Jisoo','Ads3',2,33,7000,'emp3Jisoo'),('emp33','Kim','Jisoo','Ads3',2,33,7000,'emp3Jisoo'),('emp4','Manoban','Lalisa','Bus2',1,22,12000,'emp4Lalisa'),('emp44','Manoban','Lalisa','Bus2',1,22,12000,'emp4Lalisa'),('emp5','Park','Roseanne','Bus2',1,22,12000,'emp5Roseanne'),('emp55','Park','Roseanne','Bus2',1,22,12000,'emp5Roseanne'),('emp6','Malik','Zayn','Law2',3,44,200000,'emp6Zayn'),('emp66','Malik','Zayn','Law2',3,44,200000,'emp6Zayn'),('emp7','Styles','Harry','Net1',2,11,12000,'emp7Harry'),('emp77','Styles','Harry','Net1',2,11,12000,'emp7Harry'),('emp8','Swift','Taylor','Ads3',3,33,55000,'emp8Taylor'),('emp88','Swift','Taylor','Ads3',3,33,55000,'emp8Taylor'),('emp9','Jenner','Kendal','Net1',2,11,3000,'emp9Kendal'),('emp99','Jenner','Kendal','Net1',2,11,3000,'emp9Kendal');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`nikki`@`%`*/ /*!50003 TRIGGER `employee_BEFORE_DELETE` BEFORE DELETE ON `employee` FOR EACH ROW BEGIN
	insert into employee_archive (LastName, FirstName)
    values (OLD.LastName, OLD.FirstName);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `employee_archive`
--

DROP TABLE IF EXISTS `employee_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_archive` (
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_archive`
--

LOCK TABLES `employee_archive` WRITE;
/*!40000 ALTER TABLE `employee_archive` DISABLE KEYS */;
INSERT INTO `employee_archive` VALUES ('Robredo','Leni'),('Aquino','Benigno');
/*!40000 ALTER TABLE `employee_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_info`
--

DROP TABLE IF EXISTS `employee_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_info` (
  `EmployeeID` varchar(45) NOT NULL,
  `EmpTitle` varchar(45) NOT NULL,
  `home_address` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`),
  CONSTRAINT `EmployeeID` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_info`
--

LOCK TABLES `employee_info` WRITE;
/*!40000 ALTER TABLE `employee_info` DISABLE KEYS */;
INSERT INTO `employee_info` VALUES ('emp1','Attorney','Philippines'),('emp10','Database Administrator','Australia'),('emp2','Recruiter','Korea'),('emp3','Recruiter','Korea'),('emp4','Advertiser','Thailand'),('emp5','Sales Manager','China'),('emp6','Detective','India '),('emp7','Web Developer','USA'),('emp8','Influencer','USA'),('emp9','Researcher','USA');
/*!40000 ALTER TABLE `employee_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job_type`
--

DROP TABLE IF EXISTS `job_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `job_type` (
  `JobID` int NOT NULL,
  `Title` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`JobID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job_type`
--

LOCK TABLES `job_type` WRITE;
/*!40000 ALTER TABLE `job_type` DISABLE KEYS */;
INSERT INTO `job_type` VALUES (11,'Information Technology'),(12,'Safety'),(22,'Business and Finance'),(33,'Marketing'),(44,'Law'),(55,'Architecture'),(66,'Agriculture'),(77,'Construction'),(88,'Health Science'),(99,'Engineering');
/*!40000 ALTER TABLE `job_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supervisor`
--

DROP TABLE IF EXISTS `supervisor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supervisor` (
  `SupervisorID` int NOT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`SupervisorID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supervisor`
--

LOCK TABLES `supervisor` WRITE;
/*!40000 ALTER TABLE `supervisor` DISABLE KEYS */;
INSERT INTO `supervisor` VALUES (1,'Zuckerberg','Mark'),(2,'Musk','Elon'),(3,'Hastings','Reed'),(4,'Cook','Tim'),(5,'Huang','Jensen'),(6,'Dimon','Jamie'),(7,'Huateng','Ma'),(8,'Catz','Safra'),(9,'Su','Lisa'),(10,'Zhang','Daniel');
/*!40000 ALTER TABLE `supervisor` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`nikki`@`%`*/ /*!50003 TRIGGER `supervisor_BEFORE_INSERT` BEFORE INSERT ON `supervisor` FOR EACH ROW BEGIN
	if NEW.SupervisorID > 10 THEN
    signal sqlstate '45000' set message_text = 'Supervisor position is full.';
    end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `view_address`
--

DROP TABLE IF EXISTS `view_address`;
/*!50001 DROP VIEW IF EXISTS `view_address`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_address` AS SELECT 
 1 AS `EmployeeID`,
 1 AS `home_address`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_salary`
--

DROP TABLE IF EXISTS `view_salary`;
/*!50001 DROP VIEW IF EXISTS `view_salary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_salary` AS SELECT 
 1 AS `LastName`,
 1 AS `FirstName`,
 1 AS `Salary`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_workdetails`
--

DROP TABLE IF EXISTS `view_workdetails`;
/*!50001 DROP VIEW IF EXISTS `view_workdetails`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_workdetails` AS SELECT 
 1 AS `LastName`,
 1 AS `AssID`,
 1 AS `JobID`,
 1 AS `Salary`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'employee_sys'
--

--
-- Dumping routines for database 'employee_sys'
--
/*!50003 DROP FUNCTION IF EXISTS `func_GetEmployeeLevel` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`nikki`@`%` FUNCTION `func_GetEmployeeLevel`(
	Salary DECIMAL(10,0)) RETURNS varchar(45) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
	DECLARE EmployeeLevel VARCHAR(45);
    
    IF Salary > 50000 THEN
		SET EmployeeLevel = 'Promoted';
	ELSEIF Salary <= 50000 THEN
		SET EmployeeLevel = 'Not Promoted';
	END IF;
RETURN (EmployeeLevel);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_GetEmployees` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`nikki`@`%` PROCEDURE `sp_GetEmployees`()
BEGIN
	select EmployeeID, LastName, AssID, JobID from employee;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `view_address`
--

/*!50001 DROP VIEW IF EXISTS `view_address`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`nikki`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_address` AS select `employee_info`.`EmployeeID` AS `EmployeeID`,`employee_info`.`home_address` AS `home_address` from `employee_info` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_salary`
--

/*!50001 DROP VIEW IF EXISTS `view_salary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`nikki`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_salary` AS select `employee`.`LastName` AS `LastName`,`employee`.`FirstName` AS `FirstName`,`employee`.`Salary` AS `Salary` from `employee` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_workdetails`
--

/*!50001 DROP VIEW IF EXISTS `view_workdetails`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`nikki`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `view_workdetails` AS select `employee`.`LastName` AS `LastName`,`employee`.`AssID` AS `AssID`,`employee`.`JobID` AS `JobID`,`employee`.`Salary` AS `Salary` from `employee` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-17  2:21:47
