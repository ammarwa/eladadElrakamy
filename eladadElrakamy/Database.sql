USE [master]
GO
/****** Object:  Database [adadrakamy]    Script Date: Sunday 15 Apr 18 11:05:02 PM ******/
CREATE DATABASE [adadrakamy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'adadrakamy', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\adadrakamy.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'adadrakamy_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\adadrakamy_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [adadrakamy] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [adadrakamy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [adadrakamy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [adadrakamy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [adadrakamy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [adadrakamy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [adadrakamy] SET ARITHABORT OFF 
GO
ALTER DATABASE [adadrakamy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [adadrakamy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [adadrakamy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [adadrakamy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [adadrakamy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [adadrakamy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [adadrakamy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [adadrakamy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [adadrakamy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [adadrakamy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [adadrakamy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [adadrakamy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [adadrakamy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [adadrakamy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [adadrakamy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [adadrakamy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [adadrakamy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [adadrakamy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [adadrakamy] SET  MULTI_USER 
GO
ALTER DATABASE [adadrakamy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [adadrakamy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [adadrakamy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [adadrakamy] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [adadrakamy] SET DELAYED_DURABILITY = DISABLED 
GO
USE [adadrakamy]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[id] [int] NOT NULL,
	[description] [varchar](max) NULL,
	[Quantity] [varchar](50) NOT NULL,
	[price] [varchar](50) NOT NULL,
	[notes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventoryReports]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventoryReports](
	[invID] [int] NOT NULL,
	[qty] [varchar](50) NOT NULL,
	[price] [varchar](50) NOT NULL,
	[discount] [varchar](50) NOT NULL,
	[VAT] [varchar](50) NOT NULL,
	[total] [varchar](50) NOT NULL,
	[sentto] [varchar](max) NULL,
	[notes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[optional]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[optional](
	[id] [int] NOT NULL,
	[text] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projectReports]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projectReports](
	[id] [int] NOT NULL,
	[description] [varchar](max) NULL,
	[value] [varchar](50) NOT NULL,
	[VAT] [varchar](50) NOT NULL,
	[total] [varchar](50) NOT NULL,
	[spent] [varchar](50) NULL,
	[sentto] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spentReport]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spentReport](
	[id] [int] NOT NULL,
	[description] [varchar](max) NULL,
	[VAT] [varchar](50) NOT NULL,
	[total] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[type] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: Sunday 15 Apr 18 11:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[id] [int] NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[IqamaNo] [varchar](50) NOT NULL,
	[IqamaExpiry] [varchar](50) NOT NULL,
	[salary] [varchar](50) NOT NULL,
	[allowances] [varchar](50) NULL,
	[total] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Users] ([username], [password], [type]) VALUES (N'admin', N'admin', 0)
INSERT [dbo].[Users] ([username], [password], [type]) VALUES (N'abdallah', N'abdallah', 1)
USE [master]
GO
ALTER DATABASE [adadrakamy] SET  READ_WRITE 
GO
