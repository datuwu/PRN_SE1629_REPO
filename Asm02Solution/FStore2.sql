USE [master]
GO
/****** Object:  Database [FStore2]    Script Date: 06/27/2022 7:43:15 PM ******/
CREATE DATABASE [FStore2]
ALTER DATABASE [FStore2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FStore2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FStore2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FStore2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FStore2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FStore2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FStore2] SET ARITHABORT OFF 
GO
ALTER DATABASE [FStore2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FStore2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FStore2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FStore2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FStore2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FStore2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FStore2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FStore2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FStore2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FStore2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FStore2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FStore2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FStore2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FStore2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FStore2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FStore2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FStore2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FStore2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FStore2] SET  MULTI_USER 
GO
ALTER DATABASE [FStore2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FStore2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FStore2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FStore2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FStore2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FStore2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FStore2] SET QUERY_STORE = OFF
GO
USE [FStore2]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 06/27/2022 7:43:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[City] [nvarchar](15) NOT NULL,
	[Country] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 06/27/2022 7:43:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 06/27/2022 7:43:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 06/27/2022 7:43:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[Weight] [nvarchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'admin@fstore.com', N'FStore', N'Ho Chi Minh', N'Viet Nam', N'admin@@')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'abcxyz@gmail.com', N'FPT', N'Ho Chi Minh', N'Viet Nam', N'@123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'hellobaby@gmail.com', N'FSoft', N'Ho Chi Minh', N'Viet Nam', N'@123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N's1@gmail.com', N'Canva', N'Berlin', N'Germany', N'@123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N's2@gmail.com', N'Nestle', N'Washington', N'USA', N'@123')
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 4000.0000, 2, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 1000.0000, 3, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 4, 20000.0000, 2, 0.1)
GO
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2022-06-27T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 1, CAST(N'2022-06-28T00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 2, CAST(N'2022-06-15T00:00:00.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Instant Ramen', N'0.3', 3000.0000, 20)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Instant Pho', N'0.25', 4000.0000, 15)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 2, N'Cookie', N'0.1', 1000.0000, 50)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Tiramisu', N'0.8', 20000.0000, 3)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 3, N'Baking Soda', N'1', 25000.0000, 5)
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Orders]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Member]
GO
USE [master]
GO
ALTER DATABASE [FStore2] SET  READ_WRITE 
GO
