USE [master]
GO
/****** Object:  Database [Muhasebe]    Script Date: 16.06.2021 18:46:03 ******/
CREATE DATABASE [Muhasebe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Muhasebe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Muhasebe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Muhasebe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Muhasebe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Muhasebe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Muhasebe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Muhasebe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Muhasebe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Muhasebe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Muhasebe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Muhasebe] SET ARITHABORT OFF 
GO
ALTER DATABASE [Muhasebe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Muhasebe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Muhasebe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Muhasebe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Muhasebe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Muhasebe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Muhasebe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Muhasebe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Muhasebe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Muhasebe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Muhasebe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Muhasebe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Muhasebe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Muhasebe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Muhasebe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Muhasebe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Muhasebe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Muhasebe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Muhasebe] SET  MULTI_USER 
GO
ALTER DATABASE [Muhasebe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Muhasebe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Muhasebe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Muhasebe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Muhasebe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Muhasebe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Muhasebe] SET QUERY_STORE = OFF
GO
USE [Muhasebe]
GO
/****** Object:  User [Egemen]    Script Date: 16.06.2021 18:46:03 ******/
CREATE USER [Egemen] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Current]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Current](
	[CurrentID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Debt] [money] NULL,
	[Payee] [money] NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](20) NULL,
	[District] [nvarchar](20) NULL,
	[Phone1] [bigint] NULL,
	[Phone2] [bigint] NULL,
	[MobilPhone] [bigint] NULL,
	[TaxNo] [nvarchar](50) NULL,
	[PersonalID] [int] NULL,
	[DateTime] [datetime] NULL,
	[Explain] [nvarchar](max) NULL,
 CONSTRAINT [PK_Current] PRIMARY KEY CLUSTERED 
(
	[CurrentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[GroupID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[ProductID] [int] NOT NULL,
	[GroupNo] [int] NULL,
	[StockCode] [int] NULL,
	[Barcode] [nvarchar](50) NULL,
	[Name] [nvarchar](max) NULL,
	[Quantity_In] [int] NULL,
	[Quantity_Out] [int] NULL,
	[Quantity_Remaining] [int] NULL,
	[Status] [bit] NULL,
	[Price_Buy] [money] NULL,
	[Price_Sale] [money] NULL,
	[Price_Retail] [money] NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[isAdmin] [bit] NULL,
	[Remember] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Stock] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Stock] ([ProductID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Stock]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Group] FOREIGN KEY([GroupNo])
REFERENCES [dbo].[Group] ([GroupID])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Group]
GO
/****** Object:  StoredProcedure [dbo].[Current_Delete]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Current_Delete]
	@PrimaryKey int ,
	@CurrentID int ,
	@Code nvarchar(max) ,
	@Title nvarchar(max) ,
	@Debt int ,
	@Payee int ,
	@Address nvarchar(max) ,
	@City nvarchar(20) ,
	@District nvarchar(20) ,
	@Phone1 int ,
	@Phone2 int ,
	@MobilPhone int ,
	@TaxNo nvarchar(50) ,
	@PersonalID int ,
	@DateTime datetime,
	@Explain nvarchar(max)
AS
	BEGIN
		Delete From [Current] where CurrentID = @CurrentID
	END
GO
/****** Object:  StoredProcedure [dbo].[Current_Insert]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Current_Insert]
	@PrimaryKey int ,
	@CurrentID int ,
	@Code nvarchar(max) ,
	@Title nvarchar(max) ,
	@Debt int ,
	@Payee int ,
	@Address nvarchar(max) ,
	@City nvarchar(20) ,
	@District nvarchar(20) ,
	@Phone1 int ,
	@Phone2 int ,
	@MobilPhone int ,
	@TaxNo nvarchar(50) ,
	@PersonalID int ,
	@DateTime datetime,
	@Explain nvarchar(max)
AS
BEGIN
	INSERT INTO [Current](Code,Title,Debt,Payee,[Address],City,District,Phone1,Phone2,MobilPhone,TaxNo,PersonalID,[DateTime],Explain) 
	Values(@Code,@Title,@Debt,@Payee,@Address,@City,@District,@Phone1,@Phone2,@MobilPhone,@TaxNo,@PersonalID,@DateTime,@Explain)
END
GO
/****** Object:  StoredProcedure [dbo].[Current_Select]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Current_Select]
AS
BEGIN
	SELECT
		[Current].CurrentID,
		[Current].Code,
		[Current].Title,
		[Current].Debt,
		[Current].Payee,
		[Current].Address,
		[Current].City,
		[Current].District,
		[Current].Phone1,
		[Current].Phone2,
		[Current].MobilPhone,
		[Current].TaxNo,
		[Current].PersonalID
	FROM [Current]
END
GO
/****** Object:  StoredProcedure [dbo].[Current_Update]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Current_Update]
	@PrimaryKey int ,
	@CurrentID int ,
	@Code nvarchar(max) ,
	@Title nvarchar(max) ,
	@Debt int ,
	@Payee int ,
	@Address nvarchar(max) ,
	@City nvarchar(20) ,
	@District nvarchar(20) ,
	@Phone1 int ,
	@Phone2 int ,
	@MobilPhone int ,
	@TaxNo nvarchar(50) ,
	@PersonalID int ,
	@DateTime datetime,
	@Explain nvarchar(max)
AS
	BEGIN
		Update [Current] SET
			Code = @Code ,
			Title = @Title ,
			Debt = @Debt ,
			Payee = @Payee ,
			[Address] = @Address ,
			City = @City ,
			District = @District ,
			Phone1 = @Phone1 ,
			Phone2 = @Phone2 ,
			MobilPhone = @MobilPhone ,
			TaxNo = @TaxNo ,
			PersonalID = @PersonalID ,
			[DateTime] = @DateTime,
			Explain = @Explain 
			Where CurrentID = @CurrentID
	END
GO
/****** Object:  StoredProcedure [dbo].[TryingSomething]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TryingSomething]
	@CurrentID int null,
	@Code nvarchar(max) null,
	@Title nvarchar(max) null
AS
BEGIN
	INSERT INTO [Current](Code,Title) 
	Values(@Code,@Title)
END
GO
/****** Object:  StoredProcedure [dbo].[User_Delete]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[User_Delete]
@UserID int,
@Name nvarchar(50),
@Password nvarchar(50),
@isAdmin bit
as
Begin
	DELETE From Users Where UserID = @UserID
End
GO
/****** Object:  StoredProcedure [dbo].[User_Insert]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[User_Insert]
@PrimaryKey nvarchar(30),
@UserID int,
@Name nvarchar(100),
@Password nvarchar(100),
@isAdmin bit,
@Remember bit
AS
BEGIN
	INSERT INTO [User]([Name],[Password],isAdmin,Remember)
	VALUES(@Name,@Password,@isAdmin,@Remember)
END
GO
/****** Object:  StoredProcedure [dbo].[User_Select]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[User_Select]
as
Begin
	Select 
		[User].UserID,
		[User].Name,
		[User].Password,
		[User].isAdmin,
		[User].Remember
	From [User]
End
GO
/****** Object:  StoredProcedure [dbo].[User_Update]    Script Date: 16.06.2021 18:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[User_Update]
@PrimaryKey nvarchar(50),
@UserID int,
@Name nvarchar(50),
@Password nvarchar(50),
@isAdmin bit,
@Remember bit
as
Begin
	Update [User] Set 
		[Name]=@Name, 
		[Password]=@Password, 
		isAdmin=@isAdmin,
		Remember=@Remember
	Where UserID = @UserID
END
GO
USE [master]
GO
ALTER DATABASE [Muhasebe] SET  READ_WRITE 
GO
