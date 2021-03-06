/****** Object:  Database [Book_Sale_Manager]    Script Date: 8/2/2016 12:35:10 PM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Book_Sale_Manager')
BEGIN
CREATE DATABASE [Book_Sale_Manager] ON  PRIMARY 
( NAME = N'Project', FILENAME = N'D:\Project.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Project_log', FILENAME = N'D:\Project_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Book_Sale_Manager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Book_Sale_Manager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET ARITHABORT OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Book_Sale_Manager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Book_Sale_Manager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Book_Sale_Manager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Book_Sale_Manager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Book_Sale_Manager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Book_Sale_Manager] SET  MULTI_USER 
GO
ALTER DATABASE [Book_Sale_Manager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Book_Sale_Manager] SET DB_CHAINING OFF 
GO
USE [Book_Sale_Manager]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](50) NULL,
	[phone] [char](11) NULL,
	[email] [varchar](250) NULL,
	[type] [varchar](10) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Author]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Author](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Book]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Book](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [varchar](250) NULL,
	[name] [nvarchar](1000) NULL,
	[description] [nvarchar](max) NULL,
	[thumbnail] [varchar](500) NULL,
	[quantity] [int] NULL,
	[price] [float] NULL,
	[status] [varchar](10) NULL,
	[year] [char](4) NULL,
	[publisher_ID] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book_Author]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Book_Author]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Book_Author](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [int] NULL,
	[author_ID] [int] NULL,
 CONSTRAINT [PK_Book_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Book_Category]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Book_Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Book_Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [int] NULL,
	[category_ID] [int] NULL,
 CONSTRAINT [PK_Book_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](350) NULL,
	[status] [varchar](10) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[status] [varchar](10) NULL,
	[account_ID] [int] NULL,
	[customer_name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order_Detail]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order_Detail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [int] NULL,
	[order_ID] [int] NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_Order_Detail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 8/2/2016 12:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Publisher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Publisher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Book]    Script Date: 8/2/2016 12:35:10 PM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND name = N'IX_Book')
CREATE UNIQUE NONCLUSTERED INDEX [IX_Book] ON [dbo].[Book]
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book]'))
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Publisher] FOREIGN KEY([publisher_ID])
REFERENCES [dbo].[Publisher] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book]'))
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Publisher]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Author_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Author]'))
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_Author] FOREIGN KEY([author_ID])
REFERENCES [dbo].[Author] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Author_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Author]'))
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_Book_Author_Author]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Author_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Author]'))
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_Book] FOREIGN KEY([book_ID])
REFERENCES [dbo].[Book] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Author_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Author]'))
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_Book_Author_Book]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Category_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Category]'))
ALTER TABLE [dbo].[Book_Category]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category_Book] FOREIGN KEY([book_ID])
REFERENCES [dbo].[Book] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Category_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Category]'))
ALTER TABLE [dbo].[Book_Category] CHECK CONSTRAINT [FK_Book_Category_Book]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Category_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Category]'))
ALTER TABLE [dbo].[Book_Category]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category_Category] FOREIGN KEY([category_ID])
REFERENCES [dbo].[Category] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Book_Category_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Book_Category]'))
ALTER TABLE [dbo].[Book_Category] CHECK CONSTRAINT [FK_Book_Category_Category]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Account]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Account] FOREIGN KEY([account_ID])
REFERENCES [dbo].[Account] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Account]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Account]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Detail_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order_Detail]'))
ALTER TABLE [dbo].[Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_Detail_Book] FOREIGN KEY([book_ID])
REFERENCES [dbo].[Book] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Detail_Book]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order_Detail]'))
ALTER TABLE [dbo].[Order_Detail] CHECK CONSTRAINT [FK_Order_Detail_Book]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Detail_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order_Detail]'))
ALTER TABLE [dbo].[Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Order_Detail_Order] FOREIGN KEY([order_ID])
REFERENCES [dbo].[Order] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Detail_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order_Detail]'))
ALTER TABLE [dbo].[Order_Detail] CHECK CONSTRAINT [FK_Order_Detail_Order]
GO
USE [master]
GO
ALTER DATABASE [Book_Sale_Manager] SET  READ_WRITE 
GO
