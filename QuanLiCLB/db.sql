USE [master]
GO
/****** Object:  Database [QLCLB]    Script Date: 4/6/2019 12:07:55 PM ******/
CREATE DATABASE [QLCLB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCLB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCLB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCLB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLCLB_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLCLB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCLB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCLB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCLB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCLB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCLB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCLB] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCLB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCLB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCLB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCLB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCLB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCLB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCLB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCLB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCLB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCLB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLCLB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCLB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCLB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCLB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCLB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCLB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCLB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCLB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCLB] SET  MULTI_USER 
GO
ALTER DATABASE [QLCLB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCLB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCLB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCLB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLCLB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCLB', N'ON'
GO
USE [QLCLB]
GO
/****** Object:  Table [dbo].[Clb]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clb](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenClb] [nvarchar](200) NULL,
	[MucHocPhi] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Clb] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKy](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LopID] [bigint] NULL,
	[HocSinhID] [bigint] NULL,
	[NgayDky] [date] NULL,
	[HocPhi] [decimal](18, 0) NULL,
	[TaiKhoanID] [bigint] NULL,
	[NguoiDangKy] [nvarchar](100) NULL,
 CONSTRAINT [PK_DangKy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenHS] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[Lophc] [bigint] NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHC]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHC](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](200) NULL,
 CONSTRAINT [PK_LopHC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenLp] [nvarchar](200) NULL,
	[LichHoc] [nvarchar](500) NULL,
	[ClbID] [bigint] NULL,
	[NgayBatDau] [date] NULL,
	[CaHoc] [varchar](50) NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/6/2019 12:07:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[Quyen] [varchar](10) NULL,
 CONSTRAINT [PK_TaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clb] ON 

INSERT [dbo].[Clb] ([ID], [TenClb], [MucHocPhi]) VALUES (1, N'câu lạc bộ 1', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[Clb] ([ID], [TenClb], [MucHocPhi]) VALUES (2, N'câu lạc bộ 2', CAST(150000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Clb] OFF
SET IDENTITY_INSERT [dbo].[DangKy] ON 

INSERT [dbo].[DangKy] ([ID], [LopID], [HocSinhID], [NgayDky], [HocPhi], [TaiKhoanID], [NguoiDangKy]) VALUES (1, 4, 3, CAST(N'2019-03-20' AS Date), CAST(150000 AS Decimal(18, 0)), 1, N'kkkk')
INSERT [dbo].[DangKy] ([ID], [LopID], [HocSinhID], [NgayDky], [HocPhi], [TaiKhoanID], [NguoiDangKy]) VALUES (2, 3, 3, CAST(N'2019-02-13' AS Date), CAST(150000 AS Decimal(18, 0)), 1, N'ngươi 2')
INSERT [dbo].[DangKy] ([ID], [LopID], [HocSinhID], [NgayDky], [HocPhi], [TaiKhoanID], [NguoiDangKy]) VALUES (3, 2, 6, CAST(N'2019-03-20' AS Date), CAST(500000 AS Decimal(18, 0)), 1, N'người 1')
INSERT [dbo].[DangKy] ([ID], [LopID], [HocSinhID], [NgayDky], [HocPhi], [TaiKhoanID], [NguoiDangKy]) VALUES (4, 4, 3, CAST(N'2019-03-20' AS Date), CAST(150000 AS Decimal(18, 0)), 1, N'Thử 1')
SET IDENTITY_INSERT [dbo].[DangKy] OFF
SET IDENTITY_INSERT [dbo].[HocSinh] ON 

INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (3, N'Dũng', 1, CAST(N'2019-03-13' AS Date), 1)
INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (4, N'Hương', 0, CAST(N'2019-03-13' AS Date), 1)
INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (6, N'test1', 0, CAST(N'2019-03-13' AS Date), 2)
INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (7, N'Dũng', 1, CAST(N'2019-03-14' AS Date), 3)
INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (8, N'Hùng', 0, CAST(N'2019-03-28' AS Date), 2)
INSERT [dbo].[HocSinh] ([ID], [TenHS], [GioiTinh], [NgaySinh], [Lophc]) VALUES (9, N'Hùng', 1, CAST(N'2019-03-11' AS Date), 2)
SET IDENTITY_INSERT [dbo].[HocSinh] OFF
SET IDENTITY_INSERT [dbo].[LopHC] ON 

INSERT [dbo].[LopHC] ([ID], [Ten]) VALUES (1, N'Lớp 1')
INSERT [dbo].[LopHC] ([ID], [Ten]) VALUES (2, N'Lớp hành chính 2')
INSERT [dbo].[LopHC] ([ID], [Ten]) VALUES (3, N'Lớp 3')
INSERT [dbo].[LopHC] ([ID], [Ten]) VALUES (4, N'Lớp hành chính 4')
SET IDENTITY_INSERT [dbo].[LopHC] OFF
SET IDENTITY_INSERT [dbo].[LopHoc] ON 

INSERT [dbo].[LopHoc] ([ID], [TenLp], [LichHoc], [ClbID], [NgayBatDau], [CaHoc]) VALUES (1, N'lớp clb 1', N'không nè', 2, CAST(N'2019-03-20' AS Date), N'1')
INSERT [dbo].[LopHoc] ([ID], [TenLp], [LichHoc], [ClbID], [NgayBatDau], [CaHoc]) VALUES (2, N'lớp n', N'ok', 1, CAST(N'2019-03-20' AS Date), N'2')
INSERT [dbo].[LopHoc] ([ID], [TenLp], [LichHoc], [ClbID], [NgayBatDau], [CaHoc]) VALUES (3, N'Lớp clb 2', N'noi nào có dây', 2, CAST(N'2019-03-20' AS Date), N'4')
INSERT [dbo].[LopHoc] ([ID], [TenLp], [LichHoc], [ClbID], [NgayBatDau], [CaHoc]) VALUES (4, N'Lớp 3', N'th? cái nè', 2, CAST(N'2019-03-20' AS Date), N'4')
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (1, N'diagru', N'1', N'Admin')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (2, N'user1', N'1', N'User')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (3, N'user2', NULL, N'User')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (4, N'user3', NULL, N'User')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (5, N'user4', N'1', N'User')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (6, N'user5', N'1', N'User')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MatKhau], [Quyen]) VALUES (7, N'User6', N'123456', N'User')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_HocSinh] FOREIGN KEY([HocSinhID])
REFERENCES [dbo].[HocSinh] ([ID])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_HocSinh]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_LopHoc] FOREIGN KEY([LopID])
REFERENCES [dbo].[LopHoc] ([ID])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_LopHoc]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_TaiKhoan1] FOREIGN KEY([TaiKhoanID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_TaiKhoan1]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_LopHC] FOREIGN KEY([Lophc])
REFERENCES [dbo].[LopHC] ([ID])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_LopHC]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_Clb] FOREIGN KEY([ClbID])
REFERENCES [dbo].[Clb] ([ID])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_Clb]
GO
USE [master]
GO
ALTER DATABASE [QLCLB] SET  READ_WRITE 
GO
