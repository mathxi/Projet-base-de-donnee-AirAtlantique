USE [master]
GO

/****** Object:  Database [AirAtlantique]    Script Date: 29/04/2019 08:25:18 ******/
CREATE DATABASE [AirAtlantique]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AirAtlantique', FILENAME = N'C:\SQL\DATA\AirAtlantique.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AirAtlantique_log', FILENAME = N'C:\SQL\DATA\AirAtlantique_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [AirAtlantique] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AirAtlantique].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AirAtlantique] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AirAtlantique] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AirAtlantique] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AirAtlantique] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AirAtlantique] SET ARITHABORT OFF 
GO

ALTER DATABASE [AirAtlantique] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AirAtlantique] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AirAtlantique] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AirAtlantique] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AirAtlantique] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AirAtlantique] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AirAtlantique] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AirAtlantique] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AirAtlantique] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AirAtlantique] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AirAtlantique] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AirAtlantique] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AirAtlantique] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AirAtlantique] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AirAtlantique] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AirAtlantique] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AirAtlantique] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AirAtlantique] SET RECOVERY FULL 
GO

ALTER DATABASE [AirAtlantique] SET  MULTI_USER 
GO

ALTER DATABASE [AirAtlantique] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AirAtlantique] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AirAtlantique] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AirAtlantique] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AirAtlantique] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AirAtlantique] SET QUERY_STORE = OFF
GO

USE [AirAtlantique]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [AirAtlantique] SET  READ_WRITE 
GO


