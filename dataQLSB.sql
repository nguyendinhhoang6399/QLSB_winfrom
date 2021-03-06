USE [master]
GO
/****** Object:  Database [QuanLySanBong]    Script Date: 7/17/2020 2:04:29 PM ******/
CREATE DATABASE [QuanLySanBong]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySanBong', FILENAME = N'D:\Program File\SQL 2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLySanBong.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySanBong_log', FILENAME = N'D:\Program File\SQL 2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLySanBong_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLySanBong] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySanBong].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySanBong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySanBong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySanBong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySanBong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySanBong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySanBong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySanBong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySanBong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySanBong] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySanBong] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySanBong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySanBong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySanBong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySanBong] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySanBong] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySanBong] SET QUERY_STORE = OFF
GO
USE [QuanLySanBong]
GO
/****** Object:  Table [dbo].[BangGiaSan]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGiaSan](
	[GioBatDau] [time](7) NOT NULL,
	[GioKetThuc] [time](7) NOT NULL,
	[DonGia] [money] NULL,
	[MaLs] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GioBatDau] ASC,
	[GioKetThuc] ASC,
	[MaLs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[SoLuongBan] [int] NULL,
	[donGia] [money] NULL,
	[ThanhTien] [money] NULL,
	[MaHd] [int] NOT NULL,
	[MaHh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHh] ASC,
	[MaHd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPhieu] [int] NOT NULL,
	[DVT] [nvarchar](50) NULL,
	[SoLuongNhap] [int] NULL,
	[GiaNhap] [money] NULL,
	[MaHh] [int] NOT NULL,
	[MaNcc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatSan]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatSan](
	[MaDatSan] [int] IDENTITY(1,1) NOT NULL,
	[MaSan] [int] NULL,
	[MaKh] [int] NULL,
	[TuGio] [time](7) NULL,
	[DenGio] [time](7) NULL,
	[TuNgay] [date] NULL,
	[DenNgay] [date] NULL,
	[ThoiGian] [time](7) NULL,
	[Trangthai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDatSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHh] [int] IDENTITY(1,1) NOT NULL,
	[TenHh] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[DonGia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHd] [int] IDENTITY(1,1) NOT NULL,
	[NgayXuat] [date] NULL,
	[TongTien] [money] NULL,
	[trangThai] [nvarchar](50) NULL,
	[MaNv] [nvarchar](50) NULL,
	[MaKh] [int] NULL,
	[MaSan] [int] NULL,
	[GioBatDau] [datetime] NULL,
	[GioKetThuc] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKh] [int] IDENTITY(1,1) NOT NULL,
	[TenKh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSan]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSan](
	[MaLs] [int] IDENTITY(1,1) NOT NULL,
	[TenLs] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTK]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTK](
	[MaLoaiTK] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTK] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNcc] [int] IDENTITY(1,1) NOT NULL,
	[TenNcc] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNv] [nvarchar](50) NOT NULL,
	[TenNv] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgayVaoLam] [date] NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanViec]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanViec](
	[MaNv] [nvarchar](50) NOT NULL,
	[tenCv] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNv] ASC,
	[tenCv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [date] NULL,
	[ThanhTien] [money] NULL,
	[MaNcc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San](
	[MaSan] [int] IDENTITY(1,1) NOT NULL,
	[TenSan] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaLs] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[MaLoaiTK] [int] NULL,
	[MaNv] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'05:00:00' AS Time), CAST(N'11:00:00' AS Time), 70000.0000, 1)
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'05:00:00' AS Time), CAST(N'11:00:00' AS Time), 200000.0000, 2)
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'11:00:00' AS Time), CAST(N'16:00:00' AS Time), 50000.0000, 1)
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'11:00:00' AS Time), CAST(N'16:00:00' AS Time), 180000.0000, 2)
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'16:00:00' AS Time), CAST(N'23:59:00' AS Time), 100000.0000, 1)
INSERT [dbo].[BangGiaSan] ([GioBatDau], [GioKetThuc], [DonGia], [MaLs]) VALUES (CAST(N'16:00:00' AS Time), CAST(N'23:59:00' AS Time), 250000.0000, 2)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (1, 12000.0000, 12000.0000, 32, 1)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (1, 12000.0000, 12000.0000, 41, 4)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (1, 12000.0000, 12000.0000, 33, 5)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (2, 12000.0000, 24000.0000, 37, 5)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (1, 12000.0000, 12000.0000, 40, 5)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (1, 12000.0000, 12000.0000, 42, 5)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (4, 12000.0000, 48000.0000, 43, 7)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (2, 12000.0000, 24000.0000, 40, 8)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (2, 7000.0000, 14000.0000, 34, 9)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (3, 7000.0000, 21000.0000, 44, 9)
INSERT [dbo].[CTHoaDon] ([SoLuongBan], [donGia], [ThanhTien], [MaHd], [MaHh]) VALUES (5, 7000.0000, 35000.0000, 45, 9)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (7, N'Chai', 10, 8000.0000, 1, 2)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (8, N'Chai', 50, 7000.0000, 2, 2)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (9, N'Chai', 10, 13000.0000, 9, 3)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (10, N'Chai', 30, 7500.0000, 7, 1)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (11, N'Chai', 27, 8500.0000, 2, 2)
INSERT [dbo].[CTPhieuNhap] ([MaPhieu], [DVT], [SoLuongNhap], [GiaNhap], [MaHh], [MaNcc]) VALUES (12, N'Chai', 50, 7000.0000, 4, 1)
SET IDENTITY_INSERT [dbo].[DatSan] ON 

INSERT [dbo].[DatSan] ([MaDatSan], [MaSan], [MaKh], [TuGio], [DenGio], [TuNgay], [DenNgay], [ThoiGian], [Trangthai]) VALUES (1, 11, 1, CAST(N'16:00:00' AS Time), CAST(N'17:30:00' AS Time), CAST(N'2020-10-07' AS Date), CAST(N'2020-10-07' AS Date), CAST(N'01:30:00' AS Time), N'Đã Hủy')
INSERT [dbo].[DatSan] ([MaDatSan], [MaSan], [MaKh], [TuGio], [DenGio], [TuNgay], [DenNgay], [ThoiGian], [Trangthai]) VALUES (8, 15, 3, CAST(N'22:00:00' AS Time), CAST(N'23:00:00' AS Time), CAST(N'2020-07-13' AS Date), CAST(N'2020-07-13' AS Date), CAST(N'01:00:00' AS Time), N'Đang Đặt')
INSERT [dbo].[DatSan] ([MaDatSan], [MaSan], [MaKh], [TuGio], [DenGio], [TuNgay], [DenNgay], [ThoiGian], [Trangthai]) VALUES (11, 11, 1, CAST(N'12:30:00' AS Time), CAST(N'14:00:00' AS Time), CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), CAST(N'01:30:00' AS Time), N'Đang Đặt')
INSERT [dbo].[DatSan] ([MaDatSan], [MaSan], [MaKh], [TuGio], [DenGio], [TuNgay], [DenNgay], [ThoiGian], [Trangthai]) VALUES (12, 11, 1, CAST(N'14:01:00' AS Time), CAST(N'15:00:00' AS Time), CAST(N'2020-07-16' AS Date), CAST(N'2020-07-16' AS Date), CAST(N'01:00:00' AS Time), N'Đang Đặt')
INSERT [dbo].[DatSan] ([MaDatSan], [MaSan], [MaKh], [TuGio], [DenGio], [TuNgay], [DenNgay], [ThoiGian], [Trangthai]) VALUES (13, 23, 6, CAST(N'17:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(N'2020-07-17' AS Date), CAST(N'2020-07-17' AS Date), CAST(N'01:00:00' AS Time), N'Đang Đặt')
SET IDENTITY_INSERT [dbo].[DatSan] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (1, N'Revive', N'Chai', 27, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (2, N'Revive Chanh Muối', N'Chai', 71, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (3, N'Pepsi', N'Chai', 12, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (4, N'Coca', N'Chai', 61, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (5, N'Number One', N'Chai', 8, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (6, N'Red Bull', N'Lon', 20, 15000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (7, N'Fanta', N'Lon', 45, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (8, N'Mirinda', N'Lon', 13, 12000.0000)
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [DVT], [SoLuongTon], [DonGia]) VALUES (9, N'Lavie', N'Chai', 9, 7000.0000)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (32, CAST(N'2020-07-14' AS Date), 82000.0000, N'Đã thanh toán', N'A000', 1, 11, CAST(N'1900-01-01T09:00:00.000' AS DateTime), CAST(N'1900-01-01T10:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (33, CAST(N'2020-07-14' AS Date), 112000.0000, N'Đã thanh toán', N'A000', 3, 11, CAST(N'1900-01-01T16:00:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (34, CAST(N'2020-07-14' AS Date), 214000.0000, N'Đã thanh toán', N'A000', 2, 12, CAST(N'1900-01-01T16:00:00.000' AS DateTime), CAST(N'1900-01-01T18:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (35, CAST(N'2020-07-14' AS Date), 100000.0000, N'Đã thanh toán', N'A000', 2, 11, CAST(N'1900-01-01T12:00:00.000' AS DateTime), CAST(N'1900-01-01T14:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (36, CAST(N'2020-07-14' AS Date), 100000.0000, N'Đã thanh toán', N'A000', 5, 11, CAST(N'1900-01-01T15:00:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (37, CAST(N'2020-07-14' AS Date), 186000.0000, N'Đã thanh toán', N'A000', 2, 11, CAST(N'1900-01-01T20:00:00.000' AS DateTime), CAST(N'1900-01-01T21:30:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (40, CAST(N'2020-07-15' AS Date), 226000.0000, N'Đã thanh toán', N'A000', 4, 11, CAST(N'1900-01-01T18:06:00.000' AS DateTime), CAST(N'1900-01-01T20:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (41, CAST(N'2020-07-16' AS Date), 82000.0000, N'Đã thanh toán', N'A000', 6, 11, CAST(N'1900-01-01T10:30:00.000' AS DateTime), CAST(N'1900-01-01T11:30:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (42, CAST(N'2020-07-16' AS Date), 112000.0000, N'Đã thanh toán', N'A000', 8, 13, CAST(N'1900-01-01T17:00:00.000' AS DateTime), CAST(N'1900-01-01T18:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (43, CAST(N'2020-07-16' AS Date), 143000.0000, N'Đã thanh toán', N'A000', 8, 11, CAST(N'1900-01-01T16:03:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (44, CAST(N'2020-07-16' AS Date), 706000.0000, N'Đã thanh toán', N'A000', 6, 11, CAST(N'1900-01-01T17:09:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHd], [NgayXuat], [TongTien], [trangThai], [MaNv], [MaKh], [MaSan], [GioBatDau], [GioKetThuc]) VALUES (45, CAST(N'2020-07-16' AS Date), 703333.3333, N'Đã thanh toán', N'A000', 3, 14, CAST(N'1900-01-01T17:19:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (1, N'Lê Văn A', N'65 Lê Lai', N'0452787878', N'')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (2, N'Lê Văn B', N'45 Lê Lợi', N'0452474778', N'')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (3, N'Lê Văn C', N'15 Lê Thánh Tôn', N'0401257878', N'')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (4, N'Lê Văn D', N'115 Lê Thái Tông', N'0459696878', N'')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (5, N'Lê Văn E', N'205 Lê Văn Sĩ', N'0452741018', N'')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (6, N'Neymar Hoàng', N'65 đường 81', N'0938741741', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (7, N'Luis Hùng', N'15 Bùi Viện', N'789789798798', N'hung@xyza.com')
INSERT [dbo].[KhachHang] ([MaKh], [TenKh], [DiaChi], [SoDienThoai], [Email]) VALUES (8, N'Lionel Vũ', N'45 Tô Ký', N'74632595', N'anc@ayx')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiSan] ON 

INSERT [dbo].[LoaiSan] ([MaLs], [TenLs]) VALUES (1, N'Sân 5')
INSERT [dbo].[LoaiSan] ([MaLs], [TenLs]) VALUES (2, N'Sân 7')
SET IDENTITY_INSERT [dbo].[LoaiSan] OFF
SET IDENTITY_INSERT [dbo].[LoaiTK] ON 

INSERT [dbo].[LoaiTK] ([MaLoaiTK], [TenLoaiTK]) VALUES (1, N'Admin')
INSERT [dbo].[LoaiTK] ([MaLoaiTK], [TenLoaiTK]) VALUES (2, N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[LoaiTK] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNcc], [TenNcc], [DiaChi], [SoDienThoai]) VALUES (1, N'Tân Hiệp Phát', N'65 Tân Quy', N'0909164165')
INSERT [dbo].[NhaCungCap] ([MaNcc], [TenNcc], [DiaChi], [SoDienThoai]) VALUES (2, N'Suntory Pepsico', N'37 Tân Kiểng', N'0908119911')
INSERT [dbo].[NhaCungCap] ([MaNcc], [TenNcc], [DiaChi], [SoDienThoai]) VALUES (3, N'Lavie', N'44 Tân Phong', N'0909788977')
INSERT [dbo].[NhaCungCap] ([MaNcc], [TenNcc], [DiaChi], [SoDienThoai]) VALUES (4, N'Saka', N'75 Lê Văn Việt', N'789789789789')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A000', N'ADMIN', N'Nam', CAST(N'2020-01-02' AS Date), N'0365486987', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A001', N'Nguyễn Minh A', N'Nam', CAST(N'2020-01-02' AS Date), N'0365486987', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A002', N'Lê Văn B', N'Nữ', CAST(N'2020-01-02' AS Date), N'365487894', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A003', N'Nguyễn Minh C', N'Nữ', CAST(N'2020-01-02' AS Date), N'0365486214', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A004', N'Nguyễn Minh D', N'Nam', CAST(N'2020-01-02' AS Date), N'0365486111', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A005', N'Nguyễn Minh E', N'Nữ', CAST(N'2020-01-02' AS Date), N'0365486444', N'dinhhoangnguyen6399@gmail.com')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A006', N'Lê Thị Rô', N'Nữ', CAST(N'2020-07-01' AS Date), N'1641115255', N'ayx@ahw')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [GioiTinh], [NgayVaoLam], [SoDienThoai], [Email]) VALUES (N'A007', N'Phan Thị Hồng Bale', N'Nữ', CAST(N'2020-07-07' AS Date), N'12', N'hung')
INSERT [dbo].[PhanViec] ([MaNv], [tenCv]) VALUES (N'A003', N'Quản Lý Tính Tiền')
INSERT [dbo].[PhanViec] ([MaNv], [tenCv]) VALUES (N'A004', N'Quản Lý Hóa Đơn')
INSERT [dbo].[PhanViec] ([MaNv], [tenCv]) VALUES (N'A006', N'Quản Lý Đặt Sân')
INSERT [dbo].[PhanViec] ([MaNv], [tenCv]) VALUES (N'A007', N'Quản Lý Tính Tiền')
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (7, CAST(N'2020-07-14' AS Date), 80000.0000, 2)
INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (8, CAST(N'2020-07-15' AS Date), 350000.0000, 2)
INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (9, CAST(N'2020-07-15' AS Date), 130000.0000, 3)
INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (10, CAST(N'2020-07-15' AS Date), 225000.0000, 1)
INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (11, CAST(N'2020-07-15' AS Date), 229500.0000, 2)
INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayNhap], [ThanhTien], [MaNcc]) VALUES (12, CAST(N'2020-07-16' AS Date), 350000.0000, 1)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[San] ON 

INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (11, N'Sân 5-A', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (12, N'Sân 5-B', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (13, N'Sân 5-C', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (14, N'Sân 5-D', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (15, N'Sân 5-E', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (16, N'Sân 7-A', N'Trống', 2)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (17, N'Sân 7-B', N'Trống', 2)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (18, N'Sân 7-C', N'Trống', 2)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (19, N'Sân 7-D', N'Trống', 2)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (20, N'Sân 7-E', N'Trống', 2)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (21, N'Sân 5-F', N'Trống', 1)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai], [MaLs]) VALUES (23, N'sanas', N'Trống', 2)
SET IDENTITY_INSERT [dbo].[San] OFF
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'admin', N'lu0c+GqlVMQ=', 1, N'A000')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'NVA003', N'3AnNaGL2MBE=', 2, N'A003')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'NVA004', N'LzU52Bh9JDo=', 2, N'A004')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'nvA005', N'psdoZgCKfgo=', 2, N'A005')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'NVA006', N'kKIIgJUWB14=', 2, N'A006')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [MaLoaiTK], [MaNv]) VALUES (N'NVA007', N'p6K3VrIB+ig=', 2, N'A007')
ALTER TABLE [dbo].[BangGiaSan]  WITH CHECK ADD FOREIGN KEY([MaLs])
REFERENCES [dbo].[LoaiSan] ([MaLs])
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHd])
REFERENCES [dbo].[HoaDon] ([MaHd])
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHh])
REFERENCES [dbo].[HangHoa] ([MaHh])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNcc])
REFERENCES [dbo].[NhaCungCap] ([MaNcc])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaHh])
REFERENCES [dbo].[HangHoa] ([MaHh])
GO
ALTER TABLE [dbo].[DatSan]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KhachHang] ([MaKh])
GO
ALTER TABLE [dbo].[DatSan]  WITH CHECK ADD FOREIGN KEY([MaSan])
REFERENCES [dbo].[San] ([MaSan])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[KhachHang] ([MaKh])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNv])
REFERENCES [dbo].[NhanVien] ([MaNv])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaSan])
REFERENCES [dbo].[San] ([MaSan])
GO
ALTER TABLE [dbo].[PhanViec]  WITH CHECK ADD FOREIGN KEY([MaNv])
REFERENCES [dbo].[NhanVien] ([MaNv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNcc])
REFERENCES [dbo].[NhaCungCap] ([MaNcc])
GO
ALTER TABLE [dbo].[San]  WITH CHECK ADD FOREIGN KEY([MaLs])
REFERENCES [dbo].[LoaiSan] ([MaLs])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaLoaiTK])
REFERENCES [dbo].[LoaiTK] ([MaLoaiTK])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNv])
REFERENCES [dbo].[NhanVien] ([MaNv])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[getPhieuNhap]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[getPhieuNhap]
as begin
 select NH.maphieu, NCC.tenncc,NH.NgayNhap,HH.tenhh,PN.dvt,PN.soluongnhap,PN.gianhap, NH.thanhtien 
from PhieuNhap NH, NhaCungCap NCC, HangHoa HH, CTPhieuNhap PN 
where NH.mancc=NCC.mancc and PN.mahh = HH.mahh and NH.maphieu = PN.maphieu
end
GO
/****** Object:  StoredProcedure [dbo].[getTien]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getTien]
as begin 
select PARSENAME(CONVERT(varchar, CAST(sum(tongTien) AS money), 1), 2)as thanhTien from HoaDon
end
GO
/****** Object:  StoredProcedure [dbo].[LayNgay]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[LayNgay]
as begin
 select getdate()as tuNgay,getdate() as denNgay
end
GO
/****** Object:  StoredProcedure [dbo].[pr_HoaDon]    Script Date: 7/17/2020 2:04:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[pr_HoaDon]
as begin
 Select Mahd,MaNv,NgayXuat,MaKh,TongTien,TrangThai from HoaDon where NgayXuat betWeen N'2020-07-20' and N'2020-07-21'
end
GO
USE [master]
GO
ALTER DATABASE [QuanLySanBong] SET  READ_WRITE 
GO

Create trigger tg_HoaDon_in on HoaDon for Insert
 as begin
  Declare @maHd int,@gioBatDau datetime,@gioKetThuc datetime, @donGia money,
  @maSan int,@maLoaiSan int,@soGioDa float 
  select @maHd=maHd,@gioBatDau=GioBatDau,@gioKetThuc=gioKetThuc,@maSan=MaSan from inserted
  select @maLoaiSan=MaLs from San where MaSan=@maSan
  select @donGia=DonGia from BangGiaSan where MaLs=@maLoaiSan and GioBatDau<= CONVERT(time,@gioBatDau) and GioKetThuc>= CONVERT(time,@gioBatDau)
  set @soGioDa= cast(datepart(hour, @gioKetThuc -@gioBatDau) as float)+cast(datepart(MINUTE, @gioKetThuc -@gioBatDau) as float)/60
  update hoaDon set tongTien=@donGia*@soGioDa where maHd=@maHd
 end
 drop trigger tg_HoaDon_in
 select DonGia from BangGiaSan where MaLs=1 and GioBatDau<= CONVERT(time,'18:00:00') and GioKetThuc>= CONVERT(time,'18:00:00')

 ---Trigger CTHD------
CREATE trigger tr_CTHD_IN on CTHoaDon for insert
as begin
 Declare @maHd int, @soLuongBan int, @donGia money, @thanhTien Money,
@MaHh int
 select @maHd=Mahd, @soLuongBan=SoLuongBan,@donGia=donGia,@MaHh=MaHh from inserted
 print @soluongBan
 set @thanhTien=@soLuongBan*@donGia
 print @donGia
 update CTHoaDon set ThanhTien=@thanhTien where MaHd=@maHd and MaHh=@maHh
 update HoaDon set tongTien=tongTien + @thanhTien where mahd=@maHd
 Update HangHoa set soLuongTon=soLuongTon-@soLuongBan where maHh=@MaHh
end

Create trigger tg_THD_Up on CTHoaDon for update
as begin
  Declare @maHd int, @soLuongBan int, @donGia money,@soLuongBanCu int,
  @thanhTienCu Money,@thanhTienMoi Money, @MaHh int
  select @thanhTienCu=thanhTien,@soLuongBanCu=SoLuongBan from deleted
  select @maHd=Mahd, @soLuongBan=SoLuongBan,@donGia=donGia,@MaHh=MaHh from inserted
 set @thanhTienMoi=@soLuongBan*@donGia
if(@thanhTienCu !=0) begin
  update CTHoaDon set ThanhTien=@thanhTienMoi where MaHd=@maHd and MaHh=@maHh
  update HoaDon set tongTien=tongTien + @thanhTienMoi-@thanhTienCu where mahd=@maHd
  Update HangHoa Set soLuongTon=soLuongTon-@soLuongBan+@soLuongBanCu where maHh=@maHh
  end
end

Create trigger tg_CThd_de on CTHoaDon for delete
as begin
Declare @maHd int,@thanhTien money,@maHh int,@soLuongBan int
select @maHd=maHd, @thanhTien=thanhTien,@maHh=MaHh,@soLuongBan=SoLuongBan from deleted
update HoaDon set tongTien=tongTien-@thanhTien where mahd=@maHd
  Update HangHoa Set soLuongTon=soLuongTon+@soLuongBan where maHh=@maHh
end


---Trigger CTPhieuNhap-----
Create trigger Tg_CTPhieuNhap_in on CTPhieuNhap for Insert
as begin
Declare @MaPhieu int,@soLuongNhap int,@giaNhap Money,@maHh int
 Select @MaPhieu=maPhieu,@soLuongNhap=SoLuongNhap,@giaNhap=GiaNhap,@maHh=maHh from inserted
 update PhieuNhap set thanhTien=ThanhTien+(@soLuongNhap*@giaNhap) where maPhieu=@MaPhieu
 update HangHoa set SoLuongTon=soLuongTon + @soLuongNhap where maHh=@maHh
end

Create trigger Tg_CTPhieuNhap_Up on CTPhieuNhap for Update
as begin
Declare @MaPhieu int,@soLuongNhapCu int,@giaNhapCu Money,@maHh int,
@soLuongNhapMoi int,@GiaNhapMoi money
select @soLuongNhapCu=SoLuongNhap,@giaNhapCu=GiaNhap from deleted
Select @soLuongNhapMoi=SoLuongNhap,@GiaNhapMoi=GiaNhap,@MaPhieu=maPhieu,@maHh=MaHh from inserted
Update PhieuNhap set thanhTien=ThanhTien+(@soLuongNhapMoi*@GiaNhapMoi)-(@soLuongNhapCu*@giaNhapCu) where maPhieu=@MaPhieu
update HangHoa set soLuongTon=soLuongTon+@soLuongNhapMoi-@soLuongNhapCu where maHh=@maHh
end

Create trigger Tg_CTPhieuNhap_dele on CTPhieuNhap for delete
as begin
Declare @MaPhieu int,@soLuongNhap int,@giaNhap Money,@maHh int
select @MaPhieu=maPhieu,@soLuongNhap=soLuongNhap,@giaNhap=giaNhap from deleted
update PhieuNhap set thanhTien=thanhTien-(@soLuongNhap*@giaNhap) where maPhieu=@MaPhieu
Update HangHoa set soLuongTon=soLuongTon-@soLuongNhap where maHh=@maHh
SELECT FORMAT(123456789, 'C0')
end



select * from San
Select FORMAT(sum(ThanhTien),'C0')as thanhTien from CTHoaDon
update hoadon set trangThai=N'Chưa Thanh Toán'
select * from HoaDon