USE [master]
GO
/****** Object:  Database [dbQLKS]    Script Date: 6/13/2022 11:39:49 PM ******/
CREATE DATABASE [dbQLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbQLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HUNGTRAN\MSSQL\DATA\dbQLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbQLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HUNGTRAN\MSSQL\DATA\dbQLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbQLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbQLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbQLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbQLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbQLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbQLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbQLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbQLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbQLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbQLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbQLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbQLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbQLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbQLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbQLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbQLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbQLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbQLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbQLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbQLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbQLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbQLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbQLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbQLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [dbQLKS] SET  MULTI_USER 
GO
ALTER DATABASE [dbQLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbQLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbQLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbQLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbQLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbQLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbQLKS', N'ON'
GO
ALTER DATABASE [dbQLKS] SET QUERY_STORE = OFF
GO
USE [dbQLKS]
GO
/****** Object:  Table [dbo].[tb_CTDatPhong]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTDatPhong](
	[MaCTDatPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuDat] [varchar](7) NULL,
	[MaPhong] [varchar](7) NULL,
	[SoLuongNguoiLon] [int] NULL,
	[SoLuongTreEm] [int] NULL,
	[CheckIn] [datetime] NULL,
	[CheckOut] [datetime] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CTDatPhong_SanPham]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTDatPhong_SanPham](
	[MaCTDatPhong] [int] NOT NULL,
	[MaSanPham] [varchar](7) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [pk_CTDatPhong_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaCTDatPhong] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Gia]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Gia](
	[MaLoaiGia] [int] NOT NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[DonGiaNgay] [money] NOT NULL,
	[DonGiaDem] [money] NOT NULL,
	[DonGiaGio] [money] NOT NULL,
 CONSTRAINT [pk_Gia] PRIMARY KEY CLUSTERED 
(
	[MaLoaiGia] ASC,
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HoaDon]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HoaDon](
	[MaHD] [varchar](7) NOT NULL,
	[MaPhieuDat] [varchar](7) NULL,
	[TongTien] [money] NULL,
	[GiamTru] [money] NULL,
	[ThanhTien] [money] NULL,
	[NgayLap] [datetime] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Identify]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Identify](
	[Phong] [int] NULL,
	[NhanVien] [int] NULL,
	[SanPham] [int] NULL,
	[PhieuDatPhong] [int] NULL,
	[HoaDon] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_KhachHang](
	[CCCD] [varchar](12) NOT NULL,
	[HoTen] [nvarchar](60) NOT NULL,
	[DienThoai] [varchar](10) NULL,
	[Email] [varchar](60) NULL,
	[DiaChi] [nvarchar](120) NULL,
	[GioiTinh] [char](1) NULL,
	[NgaySinh] [date] NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](120) NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [pk_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_LoaiGia]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LoaiGia](
	[MaLoaiGia] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiGia] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_LoaiPhong]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LoaiPhong](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](60) NOT NULL,
	[SoLuongNguoiLon] [int] NOT NULL,
	[SoLuongTreEm] [int] NOT NULL,
	[GhiChu] [nvarchar](240) NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [varchar](7) NOT NULL,
	[HoTen] [nvarchar](60) NOT NULL,
	[DienThoai] [varchar](10) NULL,
	[Email] [varchar](60) NULL,
	[DiaChi] [nvarchar](120) NULL,
	[GioiTinh] [char](1) NULL,
	[NgaySinh] [date] NULL,
	[CCCD] [varchar](12) NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](120) NULL,
	[TenDangNhap] [varchar](25) NOT NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhomSanPham]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhomSanPham](
	[MaNSP] [int] IDENTITY(1,1) NOT NULL,
	[TenNSP] [nvarchar](60) NOT NULL,
	[DaXoa] [bit] NULL,
 CONSTRAINT [pk_NhomSanPham] PRIMARY KEY CLUSTERED 
(
	[MaNSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_PhieuDatPhong]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PhieuDatPhong](
	[MaPhieuDat] [varchar](7) NOT NULL,
	[CCCD] [varchar](12) NULL,
	[TraTruoc] [money] NULL,
	[MaNV] [varchar](7) NULL,
	[NgayLap] [datetime] NULL,
	[LoaiHinh] [nvarchar](10) NULL,
	[DaHuy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Phong]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Phong](
	[MaPhong] [varchar](7) NOT NULL,
	[TenPhong] [nvarchar](60) NOT NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[MaTang] [int] NOT NULL,
	[TrangThai] [nvarchar](25) NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SanPham]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SanPham](
	[MaSanPham] [varchar](7) NOT NULL,
	[TenSanPham] [nvarchar](60) NOT NULL,
	[DonGia] [money] NOT NULL,
	[DonViTinh] [nvarchar](15) NOT NULL,
	[MaNSP] [int] NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TaiKhoan]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TaiKhoan](
	[TenDangNhap] [varchar](25) NOT NULL,
	[MatKhau] [varchar](1000) NULL,
	[IsAdmin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TangLau]    Script Date: 6/13/2022 11:39:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TangLau](
	[MaTang] [int] IDENTITY(1,1) NOT NULL,
	[TenTang] [nvarchar](60) NOT NULL,
	[SoLuongPhong] [int] NOT NULL,
	[GhiChu] [nvarchar](240) NULL,
	[SapXep] [int] NULL,
	[DaDay] [bit] NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_CTDatPhong] ON 

INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1004, N'PD00016', N'PHG0001', 2, 1, CAST(N'2022-05-19T00:36:19.450' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1005, N'PD00018', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:01:40.113' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1006, N'PD00019', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:02:16.473' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1007, N'PD00020', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:02:46.480' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1008, N'PD00021', N'PHG0002', 2, 1, CAST(N'2022-05-19T01:24:17.147' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 540000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1009, N'PD00022', N'PHG0003', 2, 1, CAST(N'2022-05-19T01:25:51.410' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 540000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1010, N'PD00023', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:29:20.707' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1011, N'PD00024', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:32:29.827' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1012, N'PD00025', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:33:36.863' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1013, N'PD00026', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:36:12.280' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1014, N'PD00027', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:39:06.870' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (1015, N'PD00028', N'PHG0001', 2, 1, CAST(N'2022-05-19T01:41:08.950' AS DateTime), CAST(N'2022-05-20T14:00:00.000' AS DateTime), 600000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2002, N'PD00029', N'PHG0001', 2, 1, CAST(N'2022-05-22T12:00:00.000' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2003, N'PD00030', N'PHG0001', 2, 1, CAST(N'2022-05-21T21:57:12.297' AS DateTime), CAST(N'2022-05-22T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2004, N'PD00031', N'PHG0001', 2, 1, CAST(N'2022-05-21T22:00:31.290' AS DateTime), CAST(N'2022-05-22T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2005, N'PD00032', N'PHG0001', 2, 1, CAST(N'2022-05-21T23:23:11.380' AS DateTime), CAST(N'2022-05-22T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2006, N'PD00033', N'PHG0001', 2, 1, CAST(N'2022-05-21T23:33:17.497' AS DateTime), CAST(N'2022-05-22T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2007, N'PD00034', N'PHG0004', 2, 1, CAST(N'2022-05-22T02:40:00.867' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 270000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2008, N'PD00035', N'PHG0001', 2, 1, CAST(N'2022-05-22T02:54:55.863' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2009, N'PD00036', N'PHG0001', 2, 1, CAST(N'2022-05-22T02:56:45.050' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2010, N'PD00037', N'PHG0001', 2, 1, CAST(N'2022-05-22T02:59:10.860' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2011, N'PD00038', N'PHG0001', 2, 1, CAST(N'2022-05-22T03:01:13.937' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2012, N'PD00039', N'PHG0001', 2, 1, CAST(N'2022-05-22T03:04:59.220' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2013, N'PD00040', N'PHG0001', 2, 1, CAST(N'2022-05-22T09:25:04.540' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2014, N'PD00041', N'PHG0001', 2, 1, CAST(N'2022-05-22T12:25:34.627' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2015, N'PD00042', N'PHG0001', 2, 1, CAST(N'2022-05-22T13:40:19.773' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2016, N'PD00043', N'PHG0001', 2, 1, CAST(N'2022-05-22T14:08:48.193' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2017, N'PD00044', N'PHG0001', 2, 1, CAST(N'2022-05-22T14:09:59.850' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2018, N'PD00045', N'PHG0001', 2, 1, CAST(N'2022-05-22T15:01:49.770' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2019, N'PD00046', N'PHG0002', 2, 1, CAST(N'2022-05-22T18:06:59.077' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 270000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2020, N'PD00047', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:09:13.743' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2021, N'PD00048', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:20:49.190' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2022, N'PD00049', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:21:31.847' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2023, N'PD00050', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:26:24.623' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2024, N'PD00051', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:28:07.400' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2025, N'PD00052', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:36:58.900' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2026, N'PD00053', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:39:11.230' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2027, N'PD00054', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:43:42.720' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2028, N'PD00055', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:47:43.817' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2029, N'PD00056', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:51:28.173' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2030, N'PD00057', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:54:28.773' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2031, N'PD00058', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:57:28.347' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2032, N'PD00059', N'PHG0001', 2, 1, CAST(N'2022-05-22T18:59:58.773' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2033, N'PD00060', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:01:09.397' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2034, N'PD00061', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:02:40.833' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2035, N'PD00062', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:04:21.097' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2036, N'PD00063', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:06:50.847' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2037, N'PD00064', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:07:24.290' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2038, N'PD00065', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:10:41.663' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2039, N'PD00066', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:17:23.110' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2040, N'PD00067', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:17:50.263' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2041, N'PD00068', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:20:37.163' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2042, N'PD00069', N'PHG0001', 2, 1, CAST(N'2022-05-22T19:43:04.350' AS DateTime), CAST(N'2022-05-23T14:00:00.000' AS DateTime), 300000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2043, N'PD00070', N'PHG0004', 2, 1, CAST(N'2022-05-24T23:30:59.987' AS DateTime), CAST(N'2022-05-25T14:00:00.000' AS DateTime), 270000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (2044, N'PD00071', N'PHG0005', 2, 1, CAST(N'2022-05-24T23:32:54.390' AS DateTime), CAST(N'2022-05-25T14:00:00.000' AS DateTime), 270000.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (3015, N'PD00072', N'PHG0003', 2, 1, CAST(N'2022-05-31T12:45:10.680' AS DateTime), CAST(N'2022-05-31T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (3016, N'PD00073', N'PHG0003', 2, 1, CAST(N'2022-06-10T12:00:00.000' AS DateTime), CAST(N'2022-06-10T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (4016, N'PD00074', N'PHG0001', 2, 1, CAST(N'2022-06-13T20:55:02.467' AS DateTime), CAST(N'2022-06-13T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (4017, N'PD00075', N'PHG0001', 2, 1, CAST(N'2022-06-13T21:18:30.167' AS DateTime), CAST(N'2022-06-13T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (4018, N'PD00076', N'PHG0002', 2, 1, CAST(N'2022-06-13T21:31:45.937' AS DateTime), CAST(N'2022-06-13T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (4019, N'PD00077', N'PHG0003', 2, 1, CAST(N'2022-06-13T21:32:09.060' AS DateTime), CAST(N'2022-06-13T14:00:00.000' AS DateTime), 0.0000)
INSERT [dbo].[tb_CTDatPhong] ([MaCTDatPhong], [MaPhieuDat], [MaPhong], [SoLuongNguoiLon], [SoLuongTreEm], [CheckIn], [CheckOut], [ThanhTien]) VALUES (4020, N'PD00077', N'PHG0005', 2, 1, CAST(N'2022-06-13T21:32:09.060' AS DateTime), CAST(N'2022-06-13T14:00:00.000' AS DateTime), 0.0000)
SET IDENTITY_INSERT [dbo].[tb_CTDatPhong] OFF
GO
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1004, N'SP00001', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1004, N'SP00002', 1, 20000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1006, N'SP00002', 1, 20000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1006, N'SP00004', 2, 50000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1006, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1006, N'SP00006', 1, 15000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1010, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1010, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1011, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1011, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (1012, N'SP00004', 2, 50000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2004, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2004, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2006, N'SP00002', 1, 20000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2006, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2006, N'SP00006', 1, 15000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2007, N'SP00001', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2007, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2007, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2019, N'SP00001', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2019, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2044, N'SP00002', 3, 60000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (2044, N'SP00005', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (3016, N'SP00002', 1, 20000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (3016, N'SP00004', 1, 25000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (3016, N'SP8738', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (4018, N'SP00001', 1, 10000.0000)
INSERT [dbo].[tb_CTDatPhong_SanPham] ([MaCTDatPhong], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (4018, N'SP2758', 1, 25000.0000)
GO
INSERT [dbo].[tb_Gia] ([MaLoaiGia], [MaLoaiPhong], [DonGiaNgay], [DonGiaDem], [DonGiaGio]) VALUES (1, 1, 270000.0000, 170000.0000, 70000.0000)
INSERT [dbo].[tb_Gia] ([MaLoaiGia], [MaLoaiPhong], [DonGiaNgay], [DonGiaDem], [DonGiaGio]) VALUES (1, 2, 300000.0000, 200000.0000, 70000.0000)
INSERT [dbo].[tb_Gia] ([MaLoaiGia], [MaLoaiPhong], [DonGiaNgay], [DonGiaDem], [DonGiaGio]) VALUES (1, 3, 250000.0000, 150000.0000, 60000.0000)
GO
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00016', N'PD00016', 630000.0000, NULL, NULL, CAST(N'2022-05-19T00:36:19.457' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00018', N'PD00018', 630000.0000, NULL, NULL, CAST(N'2022-05-19T01:01:40.123' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00019', N'PD00019', 695000.0000, NULL, NULL, CAST(N'2022-05-19T01:02:16.483' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00020', N'PD00020', 0.0000, NULL, NULL, CAST(N'2022-05-19T01:02:46.487' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00023', N'PD00023', 635000.0000, NULL, NULL, CAST(N'2022-05-19T01:29:20.717' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00024', N'PD00024', 2587086.6972, 0.0000, 2586586.6972, CAST(N'2022-05-19T01:32:29.847' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00025', N'PD00025', 650000.0000, 200.0000, 649800.0000, CAST(N'2022-05-19T01:33:36.873' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00026', N'PD00026', 600000.0000, 600000.0000, 0.0000, CAST(N'2022-05-19T01:36:12.300' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00027', N'PD00027', 600000.0000, 100000.0000, 499600.0000, CAST(N'2022-05-19T01:39:06.873' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00028', N'PD00028', 600000.0000, 100000.0000, 500000.0000, CAST(N'2022-05-19T01:41:08.957' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00030', N'PD00030', 300000.0000, 2.0000, 299798.0000, CAST(N'2022-04-21T21:57:12.307' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00031', N'PD00031', 335000.0000, 334800.0000, 0.0000, CAST(N'2022-05-21T22:00:31.307' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00032', N'PD00032', 300000.0000, 50000.0000, 249700.0000, CAST(N'2022-05-21T23:23:11.397' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00033', N'PD00033', 345000.0000, 100000.0000, 245000.0000, CAST(N'2022-05-21T23:33:17.510' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00034', N'PD00034', 315000.0000, 3.0000, 314697.0000, CAST(N'2022-04-22T02:40:00.877' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00035', N'PD00035', 300000.0000, 10000.0000, 289700.0000, CAST(N'2022-05-22T02:54:55.917' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00036', N'PD00036', 300000.0000, 2.0000, 299998.0000, CAST(N'2022-05-22T02:56:45.053' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00037', N'PD00037', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T02:59:10.863' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00038', N'PD00038', 300000.0000, 1000.0000, 299000.0000, CAST(N'2022-05-22T03:01:13.940' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00039', N'PD00039', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T03:04:59.223' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00040', N'PD00040', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T09:25:04.550' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00041', N'PD00041', 300000.0000, 100000.0000, 199800.0000, CAST(N'2022-04-22T12:25:34.690' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00042', N'PD00042', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T13:40:19.830' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00043', N'PD00043', 300000.0000, 100000.0000, 199700.0000, CAST(N'2022-05-22T14:08:48.200' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00044', N'PD00044', 300000.0000, 100000.0000, 199700.0000, CAST(N'2022-05-22T14:09:59.853' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00045', N'PD00045', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T15:01:49.823' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00046', N'PD00046', 305000.0000, 2.0000, 304998.0000, CAST(N'2022-04-22T18:06:59.087' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00047', N'PD00047', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T18:09:13.747' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00048', N'PD00048', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T18:20:49.197' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00049', N'PD00049', 300000.0000, 100000.0000, 197700.0000, CAST(N'2022-05-22T18:21:31.850' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00050', N'PD00050', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T18:26:24.627' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00051', N'PD00051', 300000.0000, 100000.0000, 200000.0000, CAST(N'2022-05-22T18:28:07.403' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00052', N'PD00052', 300000.0000, 30000.0000, 269700.0000, CAST(N'2022-05-22T18:36:58.917' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00053', N'PD00053', 300000.0000, 30000.0000, 270000.0000, CAST(N'2022-05-22T18:39:11.233' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00054', N'PD00054', 300000.0000, 30000.0000, 270000.0000, CAST(N'2022-05-22T18:43:42.720' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00055', N'PD00055', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-05-22T18:47:43.820' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00056', N'PD00056', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-05-22T18:51:28.177' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00057', N'PD00057', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-05-22T18:54:28.777' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00058', N'PD00058', 300000.0000, 3000.0000, 297000.0000, CAST(N'2022-05-22T18:57:28.350' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00059', N'PD00059', 300000.0000, 3.0000, 299997.0000, CAST(N'2022-05-22T18:59:58.773' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00060', N'PD00060', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-06-01T19:01:09.397' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00061', N'PD00061', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-05-22T19:02:40.837' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00062', N'PD00062', 300000.0000, 40000.0000, 260000.0000, CAST(N'2022-06-02T19:04:21.100' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00063', N'PD00063', 300000.0000, 24000.0000, 276000.0000, CAST(N'2022-05-22T19:06:50.850' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00064', N'PD00064', 300000.0000, 24000.0000, 276000.0000, CAST(N'2022-05-22T19:07:24.290' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00065', N'PD00065', 300000.0000, 97751.0000, 202249.0000, CAST(N'2022-05-22T19:10:41.667' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00066', N'PD00066', 300000.0000, 0.0000, 300000.0000, CAST(N'2022-05-22T19:17:23.113' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00067', N'PD00067', 300000.0000, 0.0000, 300000.0000, CAST(N'2022-05-22T19:17:50.263' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00068', N'PD00068', 300000.0000, 0.0000, 300000.0000, CAST(N'2022-05-22T19:20:37.163' AS DateTime), 1)
INSERT [dbo].[tb_HoaDon] ([MaHD], [MaPhieuDat], [TongTien], [GiamTru], [ThanhTien], [NgayLap], [TrangThai]) VALUES (N'HD00069', N'PD00069', 300000.0000, 24000.0000, 276000.0000, CAST(N'2022-05-22T19:43:04.353' AS DateTime), 1)
GO
INSERT [dbo].[tb_Identify] ([Phong], [NhanVien], [SanPham], [PhieuDatPhong], [HoaDon]) VALUES (18, 3, 8, 77, 69)
GO
INSERT [dbo].[tb_KhachHang] ([CCCD], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [NgayCap], [NoiCap], [DaXoa]) VALUES (N'123456789012', N'Phùng Ngọc Diễm Hằng', N'0909009123', NULL, NULL, N'F', CAST(N'2001-02-20' AS Date), CAST(N'2001-02-20' AS Date), NULL, 0)
INSERT [dbo].[tb_KhachHang] ([CCCD], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [NgayCap], [NoiCap], [DaXoa]) VALUES (N'333444555666', N'Võ Lâm Hoàng Minh', N'0913088121', NULL, NULL, N'M', CAST(N'2001-02-20' AS Date), CAST(N'2001-02-20' AS Date), NULL, 0)
INSERT [dbo].[tb_KhachHang] ([CCCD], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [NgayCap], [NoiCap], [DaXoa]) VALUES (N'987654321987', N'Trần Cao Huy', N'0900456789', NULL, NULL, N'M', CAST(N'2001-02-20' AS Date), CAST(N'2001-02-20' AS Date), NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[tb_LoaiGia] ON 

INSERT [dbo].[tb_LoaiGia] ([MaLoaiGia], [TenLoaiGia]) VALUES (1, N'Mặc định')
INSERT [dbo].[tb_LoaiGia] ([MaLoaiGia], [TenLoaiGia]) VALUES (2, N'Ngày lễ')
SET IDENTITY_INSERT [dbo].[tb_LoaiGia] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_LoaiPhong] ON 

INSERT [dbo].[tb_LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [SoLuongNguoiLon], [SoLuongTreEm], [GhiChu], [DaXoa]) VALUES (1, N'Phòng VIP', 2, 1, NULL, 0)
INSERT [dbo].[tb_LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [SoLuongNguoiLon], [SoLuongTreEm], [GhiChu], [DaXoa]) VALUES (2, N'Phòng Thường', 2, 1, NULL, 0)
INSERT [dbo].[tb_LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [SoLuongNguoiLon], [SoLuongTreEm], [GhiChu], [DaXoa]) VALUES (3, N'Phòng đôi', 3, 2, N'View biển', 0)
SET IDENTITY_INSERT [dbo].[tb_LoaiPhong] OFF
GO
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [CCCD], [NgayCap], [NoiCap], [TenDangNhap], [DaXoa]) VALUES (N'NV00001', N'Nguyễn Lê Gia Hân', N'0864173705', NULL, NULL, N'F', NULL, NULL, NULL, NULL, N'admin', 0)
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [CCCD], [NgayCap], [NoiCap], [TenDangNhap], [DaXoa]) VALUES (N'NV00002', N'Phan Bảo Phong', N'0933062937', NULL, NULL, N'M', NULL, NULL, NULL, NULL, N'nhanvien', 0)
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoTen], [DienThoai], [Email], [DiaChi], [GioiTinh], [NgaySinh], [CCCD], [NgayCap], [NoiCap], [TenDangNhap], [DaXoa]) VALUES (N'NV00003', N'Võ Thị Thảo Nhi', N'0980797255', NULL, NULL, N'F', NULL, NULL, NULL, NULL, N'nhanvien2', 0)
GO
SET IDENTITY_INSERT [dbo].[tb_NhomSanPham] ON 

INSERT [dbo].[tb_NhomSanPham] ([MaNSP], [TenNSP], [DaXoa]) VALUES (1, N'Đồ ăn', 0)
INSERT [dbo].[tb_NhomSanPham] ([MaNSP], [TenNSP], [DaXoa]) VALUES (2, N'Đồ uống', 0)
SET IDENTITY_INSERT [dbo].[tb_NhomSanPham] OFF
GO
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00016', N'123456789012', 100.0000, N'NV00001', CAST(N'2022-05-19T00:36:19.457' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00017', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:01:30.563' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00018', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:01:40.123' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00019', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:02:16.483' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00020', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:02:46.487' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00021', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:24:17.153' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00022', N'123456789012', 700.0000, N'NV00001', CAST(N'2022-05-19T01:25:51.423' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00023', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-19T01:29:20.717' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00024', N'123456789012', 500.0000, N'NV00001', CAST(N'2022-05-19T01:32:29.847' AS DateTime), N'Giờ', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00025', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-19T01:33:36.873' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00026', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:36:12.300' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00027', N'123456789012', 400.0000, N'NV00001', CAST(N'2022-05-19T01:39:06.873' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00028', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-19T01:41:08.957' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00029', N'123456789012', 100.0000, N'NV00001', CAST(N'2022-05-21T21:56:53.190' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00030', N'123456789012', 200.0000, N'NV00001', CAST(N'2022-05-21T21:57:12.307' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00031', N'123456789012', 200.0000, N'NV00001', CAST(N'2022-05-21T22:00:31.307' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00032', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-21T23:23:11.397' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00033', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-21T23:33:17.510' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00034', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-22T02:40:00.877' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00035', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-22T02:54:55.917' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00036', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T02:56:45.053' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00037', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T02:59:10.863' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00038', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T03:01:13.940' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00039', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T03:04:59.223' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00040', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T09:25:04.550' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00041', N'123456789012', 200.0000, N'NV00001', CAST(N'2022-05-22T12:25:34.690' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00042', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T13:40:19.830' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00043', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-22T14:08:48.200' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00044', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-22T14:09:59.853' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00045', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T15:01:49.823' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00046', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:06:59.087' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00047', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T18:09:13.747' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00048', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:20:49.197' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00049', N'123456789012', 2300.0000, N'NV00001', CAST(N'2022-05-22T18:21:31.850' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00050', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T18:26:24.627' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00051', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:28:07.403' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00052', N'123456789012', 300.0000, N'NV00001', CAST(N'2022-05-22T18:36:58.917' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00053', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:39:11.233' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00054', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:43:42.720' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00055', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:47:43.820' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00056', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:51:28.177' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00057', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:54:28.777' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00058', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T18:57:28.350' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00059', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T18:59:58.773' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00060', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T19:01:09.397' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00061', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T19:02:40.837' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00062', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T19:04:21.100' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00063', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T19:06:50.850' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00064', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-22T19:07:24.290' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00065', N'987654321987', 0.0000, N'NV00001', CAST(N'2022-05-22T19:10:41.667' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00066', N'987654321987', 0.0000, N'NV00001', CAST(N'2022-05-22T19:17:23.113' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00067', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T19:17:50.263' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00068', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T19:20:37.163' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00069', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-22T19:43:04.353' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00070', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-24T23:31:00.050' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00071', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-05-24T23:32:54.393' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00072', N'333444555666', 0.0000, N'NV00001', CAST(N'2022-05-31T12:45:10.757' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00073', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-06-10T17:46:57.030' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00074', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-06-13T20:55:02.473' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00075', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-06-13T21:18:30.233' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00076', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-06-13T21:31:45.943' AS DateTime), N'Ngày', 0)
INSERT [dbo].[tb_PhieuDatPhong] ([MaPhieuDat], [CCCD], [TraTruoc], [MaNV], [NgayLap], [LoaiHinh], [DaHuy]) VALUES (N'PD00077', N'123456789012', 0.0000, N'NV00001', CAST(N'2022-06-13T21:32:09.070' AS DateTime), N'Ngày', 0)
GO
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0001', N'101', 2, 1, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0002', N'102', 1, 1, N'Đang có khách', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0003', N'103', 1, 1, N'Đang có khách', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0004', N'201', 1, 2, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0005', N'202', 1, 2, N'Đang có khách', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0006', N'203', 2, 2, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0007', N'204', 2, 2, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0008', N'205', 2, 2, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0009', N'206', 3, 2, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0010', N'301', 1, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0011', N'302', 1, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0012', N'303', 1, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0013', N'304', 2, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0014', N'305', 2, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0015', N'306', 3, 3, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0016', N'401', 3, 4, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0017', N'402', 3, 4, N'Phòng trống', 0)
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLoaiPhong], [MaTang], [TrangThai], [DaXoa]) VALUES (N'PHG0018', N'403', 3, 4, N'Phòng trống', 0)
GO
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00001', N'Nước suối', 10000.0000, N'Chai', 2, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00002', N'Red bull', 20000.0000, N'Lon', 2, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00003', N'Pepsi', 15000.0000, N'Chai', 2, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00004', N'Heniken', 25000.0000, N'Lon', 2, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00005', N'Snack', 10000.0000, N'Gói', 1, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP00006', N'Bánh mì ngọt', 15000.0000, N'Gói', 1, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP2758', N'Bánh mì', 25000.0000, N'Cái', 1, 0)
INSERT [dbo].[tb_SanPham] ([MaSanPham], [TenSanPham], [DonGia], [DonViTinh], [MaNSP], [DaXoa]) VALUES (N'SP8738', N'Coca', 10000.0000, N'Lon', 2, 0)
GO
INSERT [dbo].[tb_TaiKhoan] ([TenDangNhap], [MatKhau], [IsAdmin]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[tb_TaiKhoan] ([TenDangNhap], [MatKhau], [IsAdmin]) VALUES (N'nhanvien', N'123', 0)
INSERT [dbo].[tb_TaiKhoan] ([TenDangNhap], [MatKhau], [IsAdmin]) VALUES (N'nhanvien2', N'123', 0)
GO
SET IDENTITY_INSERT [dbo].[tb_TangLau] ON 

INSERT [dbo].[tb_TangLau] ([MaTang], [TenTang], [SoLuongPhong], [GhiChu], [SapXep], [DaDay], [DaXoa]) VALUES (1, N'Tầng Trệt', 10, NULL, 1, 0, 0)
INSERT [dbo].[tb_TangLau] ([MaTang], [TenTang], [SoLuongPhong], [GhiChu], [SapXep], [DaDay], [DaXoa]) VALUES (2, N'Tầng 1', 12, NULL, 2, 0, 0)
INSERT [dbo].[tb_TangLau] ([MaTang], [TenTang], [SoLuongPhong], [GhiChu], [SapXep], [DaDay], [DaXoa]) VALUES (3, N'Tầng 2', 12, NULL, 3, 0, 0)
INSERT [dbo].[tb_TangLau] ([MaTang], [TenTang], [SoLuongPhong], [GhiChu], [SapXep], [DaDay], [DaXoa]) VALUES (4, N'Tầng 3', 12, NULL, 4, 0, 0)
SET IDENTITY_INSERT [dbo].[tb_TangLau] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tb_NhanV__55F68FC03FD24B9E]    Script Date: 6/13/2022 11:39:50 PM ******/
ALTER TABLE [dbo].[tb_NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_HoaDon] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[tb_HoaDon] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[tb_Identify] ADD  DEFAULT ((0)) FOR [Phong]
GO
ALTER TABLE [dbo].[tb_Identify] ADD  DEFAULT ((0)) FOR [NhanVien]
GO
ALTER TABLE [dbo].[tb_Identify] ADD  DEFAULT ((0)) FOR [SanPham]
GO
ALTER TABLE [dbo].[tb_Identify] ADD  DEFAULT ((0)) FOR [PhieuDatPhong]
GO
ALTER TABLE [dbo].[tb_Identify] ADD  DEFAULT ((0)) FOR [HoaDon]
GO
ALTER TABLE [dbo].[tb_KhachHang] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_LoaiPhong] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_NhanVien] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_NhomSanPham] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_PhieuDatPhong] ADD  DEFAULT ((0)) FOR [TraTruoc]
GO
ALTER TABLE [dbo].[tb_PhieuDatPhong] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[tb_PhieuDatPhong] ADD  DEFAULT ((0)) FOR [DaHuy]
GO
ALTER TABLE [dbo].[tb_Phong] ADD  DEFAULT (N'Phòng trống') FOR [TrangThai]
GO
ALTER TABLE [dbo].[tb_Phong] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_SanPham] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_TaiKhoan] ADD  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[tb_TangLau] ADD  DEFAULT ((0)) FOR [DaDay]
GO
ALTER TABLE [dbo].[tb_TangLau] ADD  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tb_CTDatPhong]  WITH CHECK ADD FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[tb_PhieuDatPhong] ([MaPhieuDat])
GO
ALTER TABLE [dbo].[tb_CTDatPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tb_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tb_CTDatPhong_SanPham]  WITH CHECK ADD FOREIGN KEY([MaCTDatPhong])
REFERENCES [dbo].[tb_CTDatPhong] ([MaCTDatPhong])
GO
ALTER TABLE [dbo].[tb_CTDatPhong_SanPham]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[tb_SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[tb_Gia]  WITH CHECK ADD FOREIGN KEY([MaLoaiGia])
REFERENCES [dbo].[tb_LoaiGia] ([MaLoaiGia])
GO
ALTER TABLE [dbo].[tb_Gia]  WITH CHECK ADD FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[tb_LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[tb_PhieuDatPhong] ([MaPhieuDat])
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[tb_TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[tb_PhieuDatPhong]  WITH CHECK ADD FOREIGN KEY([CCCD])
REFERENCES [dbo].[tb_KhachHang] ([CCCD])
GO
ALTER TABLE [dbo].[tb_PhieuDatPhong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_Phong]  WITH CHECK ADD FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[tb_LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[tb_Phong]  WITH CHECK ADD FOREIGN KEY([MaTang])
REFERENCES [dbo].[tb_TangLau] ([MaTang])
GO
ALTER TABLE [dbo].[tb_SanPham]  WITH CHECK ADD FOREIGN KEY([MaNSP])
REFERENCES [dbo].[tb_NhomSanPham] ([MaNSP])
GO
USE [master]
GO
ALTER DATABASE [dbQLKS] SET  READ_WRITE 
GO
