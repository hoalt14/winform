USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 01-Nov-19 12:18:58 AM ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Hotel.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Hotel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](40) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[GiaDichVu] [float] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[TenHoaDon] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
	[MaDichVu] [int] NULL,
	[MaPhieuThue] [int] NULL,
	[MaNhanVien] [int] NULL,
 CONSTRAINT [PK_HOADON_1] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKhachHang] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](50) NULL,
	[DienThoaiKH] [nvarchar](15) NULL,
	[SoCMND] [nvarchar](15) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNhanVien] [nvarchar](50) NULL,
	[NgaySinhNV] [datetime] NULL,
	[DiaChiNV] [nvarchar](50) NULL,
	[DienThoaiNV] [nvarchar](15) NULL,
	[MaChucVu] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHUE]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUE](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[TenPhieuThue] [nvarchar](15) NULL,
	[NgayThue] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[MaKhachHang] [int] NULL,
	[MaPhong] [int] NULL,
 CONSTRAINT [PK_PHIEUTHUE] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](15) NULL,
	[MaLoaiPhong] [int] NULL,
	[GiaPhong] [float] NULL,
	[TinhTrang] [nvarchar](15) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 01-Nov-19 12:18:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TaiKhoan] [nvarchar](15) NOT NULL,
	[MatKhau] [nvarchar](30) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CHUCVU] ON 

INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (1, N'Lễ Tân')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (2, N'Quản Lý')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (3, N'Bảo Vệ')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (4, N'Buồng Phòng')
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
SET IDENTITY_INSERT [dbo].[DICHVU] ON 

INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (1, N'Ca nô', 30.999)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (2, N'Giặt ủi', 21.012)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (3, N'Nước chanh', 6.789)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (4, N'Phao', 2.999)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (6, N'Xe đạp', 19.999)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (7, N'Áo tắm', 5.999)
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (8, N'Xe máy', 30.999)
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHoaDon], [TenHoaDon], [NgayLap], [MaDichVu], [MaPhieuThue], [MaNhanVien]) VALUES (1, N'HD-01', CAST(N'2019-01-01 00:00:00.000' AS DateTime), 1, 1, 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenHoaDon], [NgayLap], [MaDichVu], [MaPhieuThue], [MaNhanVien]) VALUES (2, N'HD-02', CAST(N'2019-01-02 00:00:00.000' AS DateTime), 2, 2, 2)
INSERT [dbo].[HOADON] ([MaHoaDon], [TenHoaDon], [NgayLap], [MaDichVu], [MaPhieuThue], [MaNhanVien]) VALUES (3, N'HD-03', CAST(N'2019-08-06 00:00:00.000' AS DateTime), 8, 3, 3)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (1, N'Tào Tháo', N'1 Tào', N'0911222333', N'123456789')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (2, N'Lưu Bị', N'2 Lưu', N'0911222444', N'234567891')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (3, N'Tôn Quyền', N'3 Tôn', N'0911222555', N'345678912')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (5, N'A test edit', N'1', N'1', N'1')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (6, N'Tư Mã Ý', N'4 Tư', N'0911222666', N'456789123')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (7, N'A test delete', N'2', N'2', N'2')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChiKH], [DienThoaiKH], [SoCMND]) VALUES (8, N'B test insert', N'3', N'3', N'3')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LOAIPHONG] ON 

INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (1, N'1 giường đơn')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (2, N'2 giường đơn')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (3, N'3 giường đơn')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (4, N'1 giường đôi')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (5, N'2 giường đôi')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (6, N'1 giường đơn, 1 giường đôi')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (7, N'1 giường đơn, 2 giường đơn ')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (8, N'2 giường đơn, 1 giường đôi')
SET IDENTITY_INSERT [dbo].[LOAIPHONG] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (1, N'Lê Thanh Hòa', CAST(N'1999-10-07 00:00:00.000' AS DateTime), N'1 Lê', N'0902462511', 2)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (2, N'Lý Mạc Sầu', CAST(N'2019-01-10 00:00:00.000' AS DateTime), N'2 Lý', N'0902462512', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (3, N'Tôn Ngộ Không', CAST(N'2019-02-10 00:00:00.000' AS DateTime), N'3 Tôn', N'0902462513', 3)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (4, N'A Sửa', CAST(N'2019-10-10 00:00:00.000' AS DateTime), N'4 Sửa Done Again', N'0902462514', 4)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (5, N'Triệu Vân', CAST(N'2019-11-10 00:00:00.000' AS DateTime), N'5 Triệu', N'0902462518', 3)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (6, N'B Test', CAST(N'2019-04-16 00:00:00.000' AS DateTime), N'1', N'1', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (7, N'', NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNhanVien], [NgaySinhNV], [DiaChiNV], [DienThoaiNV], [MaChucVu]) VALUES (8, N'C Thêm', CAST(N'2019-09-17 00:00:00.000' AS DateTime), N'2', N'2', 3)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] ON 

INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (1, N'PT-01', CAST(N'2019-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-02 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (2, N'PT-02', CAST(N'2019-01-03 00:00:00.000' AS DateTime), CAST(N'2019-01-05 00:00:00.000' AS DateTime), 2, 2)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (3, N'PT-03', CAST(N'2019-10-22 00:00:00.000' AS DateTime), CAST(N'2019-10-31 00:00:00.000' AS DateTime), 3, 3)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (5, N'PT-04', CAST(N'2019-10-12 00:00:00.000' AS DateTime), CAST(N'2019-10-12 00:00:00.000' AS DateTime), 6, 8)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (6, N'PT-05', CAST(N'2019-10-06 00:00:00.000' AS DateTime), CAST(N'2019-10-21 00:00:00.000' AS DateTime), 5, 7)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [NgayThue], [NgayTra], [MaKhachHang], [MaPhong]) VALUES (7, N'PT-10', CAST(N'2019-10-17 00:00:00.000' AS DateTime), CAST(N'2019-10-21 00:00:00.000' AS DateTime), 7, 4)
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] OFF
SET IDENTITY_INSERT [dbo].[PHONG] ON 

INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (1, N'P-01', 1, 59.999, N'trống')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (2, N'P-02', 2, 69.999, N'trống')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (3, N'P-03', 3, 79.999, N'đã đặt')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (4, N'P-04', 4, 29.999, N'đã đặt')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (5, N'P-05', 5, 49.999, N'đã đặt')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (6, N'P-06', 6, 69.999, N'trống')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (7, N'P-07', 7, 89.999, N'trống')
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [MaLoaiPhong], [GiaPhong], [TinhTrang]) VALUES (8, N'P-08', 8, 119.999, N'đã đặt')
SET IDENTITY_INSERT [dbo].[PHONG] OFF
INSERT [dbo].[TAIKHOAN] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'admin')
INSERT [dbo].[TAIKHOAN] ([TaiKhoan], [MatKhau]) VALUES (N'test', N'test')
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_DICHVU] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICHVU] ([MaDichVu])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_DICHVU]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHIEUTHUE] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PHIEUTHUE] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHIEUTHUE]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_PHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
