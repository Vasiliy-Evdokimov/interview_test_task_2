USE [master]
GO

/****** Object:  Database [test_db]    Script Date: 26.02.2021 7:40:32 ******/
CREATE DATABASE [test_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test_db', FILENAME = N'C:\test_task\db\test_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_db_log', FILENAME = N'C:\test_task\db\test_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [test_db] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [test_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [test_db] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [test_db] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [test_db] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [test_db] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [test_db] SET ARITHABORT OFF 
GO

ALTER DATABASE [test_db] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [test_db] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [test_db] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [test_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [test_db] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [test_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [test_db] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [test_db] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [test_db] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [test_db] SET  DISABLE_BROKER 
GO

ALTER DATABASE [test_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [test_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [test_db] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [test_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [test_db] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [test_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [test_db] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [test_db] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [test_db] SET  MULTI_USER 
GO

ALTER DATABASE [test_db] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [test_db] SET DB_CHAINING OFF 
GO

ALTER DATABASE [test_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [test_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [test_db] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [test_db] SET QUERY_STORE = OFF
GO

USE [test_db]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [test_db] SET  READ_WRITE 
GO


USE [test_db]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 26.02.2021 7:41:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[INN] [char](12) NOT NULL,
	[Address] [varchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [test_db]
GO

/****** Object:  Table [dbo].[Account]    Script Date: 26.02.2021 7:42:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Account] [char](20) NOT NULL,
	[Name] [varchar](100) NULL,
	[BIK] [char](9) NOT NULL,
	[Balance] [numeric](14, 2) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO

ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Customer]
GO


INSERT INTO Customer ([Name], INN, [Address]) VALUES
('ИП Иванов И.И.', '290109993663', 'Адрес №1'),
('ИП Петров П.П.', '290106606860', 'Адрес №2');

INSERT INTO Account (CustomerID, Account, Name, BIK, Balance) VALUES 
(1, '11111222223333344444', 'Счет №1', '123123123', 10000),
(1, '12345123451234512345', 'Счет №2', '234234234', 15000),
(2, '44444555556666677777', 'Счет №1', '123123123', 20000),
(2, '12345123451234512345', 'Счет №2', '234234234', 30000);