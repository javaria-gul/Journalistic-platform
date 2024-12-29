-- MySQL dump 10.13  Distrib 8.0.37, for Win64 (x86_64)
--
-- Host: localhost    Database: trendzzdb
-- ------------------------------------------------------
-- Server version	8.0.37

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `comments`
--

DROP TABLE IF EXISTS `comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comments` (
  `CommentID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `PostID` int NOT NULL,
  `CommentText` text NOT NULL,
  `CommentedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`CommentID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `comments_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comments`
--

LOCK TABLES `comments` WRITE;
/*!40000 ALTER TABLE `comments` DISABLE KEYS */;
/*!40000 ALTER TABLE `comments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `likes`
--

DROP TABLE IF EXISTS `likes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `likes` (
  `LikeID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `PostID` int NOT NULL,
  `LikedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`LikeID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `likes_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `likes`
--

LOCK TABLES `likes` WRITE;
/*!40000 ALTER TABLE `likes` DISABLE KEYS */;
/*!40000 ALTER TABLE `likes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useractivitylogs`
--

DROP TABLE IF EXISTS `useractivitylogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `useractivitylogs` (
  `LogID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `Activity` varchar(255) NOT NULL,
  `Timestamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`LogID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `useractivitylogs_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useractivitylogs`
--

LOCK TABLES `useractivitylogs` WRITE;
/*!40000 ALTER TABLE `useractivitylogs` DISABLE KEYS */;
/*!40000 ALTER TABLE `useractivitylogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Role` varchar(20) DEFAULT 'User',
  `CompanyName` varchar(255) DEFAULT NULL,
  `TermsAccepted` tinyint(1) NOT NULL DEFAULT '0',
  `AccountStatus` varchar(20) NOT NULL DEFAULT 'Pending',
  `ProfilePicture` varchar(255) DEFAULT NULL,
  `Bio` text,
  `CreatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `UpdatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','749f09bade8aca755660eeb17792da880218d4fbdc4e25fbec279d7fe9f65d70','admin@example.com','Admin',NULL,0,'Pending',NULL,NULL,'2024-11-24 17:22:06','2024-11-26 16:06:55'),(2,'javaria','ba6617abd2b6dea510ab95f539d72a8dd323868814210d81eb8eba8338d710d9','javariagul73@gmail.com','Admin',NULL,0,'Pending',NULL,NULL,'2024-11-26 13:28:41','2024-11-26 13:28:41'),(3,'javaria_gul','00fa627aa061fa023d354540df7cb11f538f73ff46996c657097f26f38cad3d6','javariagul76@gmail.com','Journalist','geo news',1,'Pending',NULL,NULL,'2024-11-26 14:04:39','2024-11-26 14:04:39'),(4,'journalist1','13bcf23aff63fafa6a616df734b63fcad9a4233cbd4536eb44dc1f05d2ee007a','journalist1@gmail.com','Journalist','geo news',1,'Pending',NULL,NULL,'2024-11-26 14:06:13','2024-11-26 14:06:13'),(5,'Mariakhan','8d65b839036f2d642bb52cb512ed0c9f7685f1b92ac3dc3cd7b954d4a9d1fa50','mariakhan@gmail.com','Journalist','dawn news',1,'Pending',NULL,NULL,'2024-11-26 15:20:37','2024-11-26 15:20:37');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-09 21:39:47



CREATE DATABASE trendzz;
USE trendzz;
-- Modified Database Schema for Trendzz

-- Drop existing tables if needed for a fresh start
DROP TABLE IF EXISTS `notifications`;
DROP TABLE IF EXISTS `trendingtags`;
DROP TABLE IF EXISTS `followers`;
DROP TABLE IF EXISTS `posts`;
DROP TABLE IF EXISTS `comments`;
DROP TABLE IF EXISTS `likes`;
DROP TABLE IF EXISTS `useractivitylogs`;
DROP TABLE IF EXISTS `users`;

-- Users Table
CREATE TABLE `users` (
  `UserID` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(50) NOT NULL,
  `PasswordHash` VARCHAR(255) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  `Role` ENUM('Admin', 'Journalist', 'User') NOT NULL DEFAULT 'User',
  `CompanyName` VARCHAR(255) DEFAULT NULL,
  `TermsAccepted` TINYINT(1) NOT NULL DEFAULT '0',
  `AccountStatus` VARCHAR(20) NOT NULL DEFAULT 'Active',
  `ProfilePicture` VARCHAR(255) DEFAULT NULL,
  `Bio` TEXT,
  `ArticlesCount` INT DEFAULT 0, -- Tracks number of articles posted
  `FollowersCount` INT DEFAULT 0, -- Tracks followers count
  `FollowingCount` INT DEFAULT 0, -- Tracks following count
  `CreatedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  `UpdatedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Posts Table
CREATE TABLE `posts` (
  `PostID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `Title` VARCHAR(255) NOT NULL,
  `Content` TEXT NOT NULL,
  `IsDraft` TINYINT(1) DEFAULT 1, -- 1 for draft, 0 for published
  `PublishedAt` TIMESTAMP NULL DEFAULT NULL,
  `CreatedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`PostID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Comments Table
CREATE TABLE `comments` (
  `CommentID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `PostID` INT NOT NULL,
  `CommentText` TEXT NOT NULL,
  `CommentedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`CommentID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  FOREIGN KEY (`PostID`) REFERENCES `posts` (`PostID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Likes Table
CREATE TABLE `likes` (
  `LikeID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `PostID` INT NOT NULL,
  `LikedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`LikeID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  FOREIGN KEY (`PostID`) REFERENCES `posts` (`PostID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Followers Table
CREATE TABLE `followers` (
  `FollowerID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `FollowedUserID` INT NOT NULL,
  `FollowedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`FollowerID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  FOREIGN KEY (`FollowedUserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Notifications Table
CREATE TABLE `notifications` (
  `NotificationID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `Message` TEXT NOT NULL,
  `IsRead` TINYINT(1) DEFAULT 0, -- 0 for unread, 1 for read
  `CreatedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`NotificationID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Trending Tags Table
CREATE TABLE `trendingtags` (
  `TagID` INT NOT NULL AUTO_INCREMENT,
  `TagName` VARCHAR(50) NOT NULL,
  `PopularityScore` INT DEFAULT 0, -- Algorithm-driven score
  `CreatedAt` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`TagID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- User Activity Logs Table
CREATE TABLE `useractivitylogs` (
  `LogID` INT NOT NULL AUTO_INCREMENT,
  `UserID` INT NOT NULL,
  `Activity` VARCHAR(255) NOT NULL,
  `Timestamp` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`LogID`),
  FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

ALTER TABLE `users` 
ADD COLUMN `LastLogin` TIMESTAMP NULL DEFAULT NULL,
ADD COLUMN `Preferences` JSON DEFAULT NULL;
ALTER TABLE `posts` 
ADD COLUMN `Tags` VARCHAR(255) DEFAULT NULL,
ADD COLUMN `ViewCount` INT DEFAULT 0;
ALTER TABLE `comments`
ADD COLUMN `ParentCommentID` INT DEFAULT NULL,
ADD FOREIGN KEY (`ParentCommentID`) REFERENCES `comments`(`CommentID`);
ALTER TABLE `followers` 
ADD COLUMN `EdgeWeight` INT DEFAULT 1;
ALTER TABLE `notifications` 
ADD COLUMN `Type` VARCHAR(50) DEFAULT NULL,
ADD COLUMN `SourceUserID` INT DEFAULT NULL,
ADD FOREIGN KEY (`SourceUserID`) REFERENCES `users`(`UserID`);
ALTER TABLE `trendingtags`
ADD COLUMN `ParentTagID` INT DEFAULT NULL,
ADD FOREIGN KEY (`ParentTagID`) REFERENCES `trendingtags`(`TagID`);


