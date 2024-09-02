CREATE DATABASE [QLBenXe]
Go
USE [QLBenXe]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chuyen](
	[MaChuyen] [char](5) NOT NULL,
	[TenChuyen] [nvarchar](50) NULL,
	[DiemBatDau] [char](5) NULL,
	[DiemDen] [char](5) NULL,
	[TGChuyen] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTDichVu]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTDichVu](
	[MaDV] [char](5) NOT NULL,
	[Xe] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC,
	[Xe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [char](5) NOT NULL,
	[TenDV] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ghe](
	[SoGhe] [char](2) NOT NULL,
	[TrangThai] [nvarchar](20) NULL,
	[Xe] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoGhe] ASC,
	[Xe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangXe]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHangXe] [char](5) NOT NULL,
	[TenHangXe] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khach]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khach](
	[MaKhach] [char](5) NOT NULL,
	[CCCD] [char](12) NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[Tuoi] [int] NULL,
	[SDT] [char](11) NULL,
	[TaiKhoan] [varchar](10) NULL,
	[MK] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaLoaiXe] [char](5) NOT NULL,
	[TenLoaiXe] [nvarchar](30) NULL,
	[SoGhe] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](5) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MatKhau] [varchar](20) NULL,
	[Quyen] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTinh] [char](5) NOT NULL,
	[TenTinh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tram](
	[MaTram] [char](5) NOT NULL,
	[Chuyen] [char](5) NOT NULL,
	[TenTram] [nvarchar](50) NULL,
	[MaTinh] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTram] ASC,
	[Chuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [char](5) NOT NULL,
	[NgayDat] [date] NULL,
	[TrangThai] [nvarchar](20) NULL,
	[MaKhach] [char](5) NULL,
	[SoGhe] [char](2) NULL,
	[Xe] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 29/11/2023 2:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [char](5) NOT NULL,
	[SoXe] [varchar](10) NULL,
	[MaChuyen] [char](5) NULL,
	[TenTaiXe] [nvarchar](50) NULL,
	[LoaiXe] [char](5) NULL,
	[TrangThai] [nvarchar](20) NULL,
	[MaHangXe] [char](5) NULL,
	[TGXuatPhat] [datetime] NULL,
	[TGHuyVe] [time](7) NULL,
	[Gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH001', N'TP.HCM - Vũng Tàu', N'TT001', N'TT002', CAST(N'04:30:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH002', N'Long A - Cần Thơ', N'TT003', N'TT004', CAST(N'03:30:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH003', N'Tiền Giang - An Giang', N'TT010', N'TT007', CAST(N'02:10:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH004', N'Tiền Giang - Long An', N'TT010', N'TT003', CAST(N'01:50:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH005', N'TP.HCM - Cần Thơ', N'TT001', N'TT004', CAST(N'02:20:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH006', N'Vũng Tàu - Bà Rịa-Vũng Tàu', N'TT002', N'TT005', CAST(N'03:30:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH007', N'Sóc Trăng - Bạc Liêu', N'TT012', N'TT006', CAST(N'04:00:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH008', N'TP.HCM - An Giang', N'TT001', N'TT007', CAST(N'01:30:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH009', N'Cà Mau - Rạch Giá', N'TT013', N'TT008', CAST(N'01:00:00' AS Time))
INSERT [dbo].[Chuyen] ([MaChuyen], [TenChuyen], [DiemBatDau], [DiemDen], [TGChuyen]) VALUES (N'CH010', N'TP.HCM - Bến Tre', N'TT001', N'TT009', CAST(N'02:00:00' AS Time))
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV001', N'XE001')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV001', N'XE002')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV001', N'XE003')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV001', N'XE004')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV002', N'XE001')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV002', N'XE002')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV002', N'XE003')
INSERT [dbo].[CTDichVu] ([MaDV], [Xe]) VALUES (N'DV002', N'XE004')
INSERT [dbo].[DichVu] ([MaDV], [TenDV]) VALUES (N'DV001', N'Phục vụ ăn sáng')
INSERT [dbo].[DichVu] ([MaDV], [TenDV]) VALUES (N'DV002', N'Phục vụ nước uống')
INSERT [dbo].[DichVu] ([MaDV], [TenDV]) VALUES (N'DV003', N'Trang bị khăn')
INSERT [dbo].[DichVu] ([MaDV], [TenDV]) VALUES (N'DV004', N'Trang bị gối')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'01', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'01', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'02', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'02', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'03', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'03', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'04', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'04', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'05', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'05', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'06', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'06', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'07', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'07', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'08', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'08', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'09', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'09', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'10', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'10', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'11', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'11', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'12', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'12', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'13', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'13', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'14', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'14', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'15', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'15', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'16', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'16', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'17', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'17', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'18', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'18', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'19', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'19', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'20', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'20', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'21', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'21', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'22', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'22', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'23', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'23', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'24', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'24', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'25', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'25', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'26', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'26', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'27', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'27', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'28', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'28', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'29', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'29', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'30', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'30', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'31', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'31', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'32', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'32', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'33', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'33', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'34', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'34', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'35', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'35', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'36', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'36', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'37', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'37', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'38', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'38', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'39', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'39', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'40', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'40', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'41', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'41', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'42', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'42', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'43', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'43', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'44', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'44', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'45', N'Trống', N'XE001')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'45', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'46', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'47', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'48', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'49', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'50', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'51', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'52', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'53', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'54', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'55', N'Trống', N'XE002')
GO
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'56', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'57', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'58', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'59', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'60', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'61', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'62', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'63', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'64', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'65', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'66', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'67', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'68', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'69', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'70', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'71', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'72', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'73', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'74', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'75', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'76', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'77', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'78', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'79', N'Trống', N'XE002')
INSERT [dbo].[Ghe] ([SoGhe], [TrangThai], [Xe]) VALUES (N'80', N'Trống', N'XE002')
INSERT [dbo].[HangXe] ([MaHangXe], [TenHangXe]) VALUES (N'HX001', N'Phương Trang')
INSERT [dbo].[HangXe] ([MaHangXe], [TenHangXe]) VALUES (N'HX002', N'Hùng Cường')
INSERT [dbo].[HangXe] ([MaHangXe], [TenHangXe]) VALUES (N'HX003', N'Huệ Nghĩa')
INSERT [dbo].[HangXe] ([MaHangXe], [TenHangXe]) VALUES (N'HX004', N'Tân Lập')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH001', N'123456789012', N'Nguyễn Văn A', 30, N'0901234567 ', N'user1', N'password1')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH002', N'987654321012', N'Trần Thị B', 25, N'0912345678 ', N'user2', N'password2')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH003', N'111111111111', N'Lê Văn C', 28, N'0987654321 ', N'user3', N'password3')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH004', N'222222222222', N'Phạm Thị D', 35, N'0976543210 ', N'user4', N'password4')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH005', N'333333333333', N'Hồ Văn E', 40, N'0965432109 ', N'user5', N'password5')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH006', N'444444444444', N'Mai Thị F', 22, N'0954321098 ', N'user6', N'password6')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH007', N'555555555555', N'Lý Văn G', 28, N'0943210987 ', N'user7', N'password7')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH008', N'666666666666', N'Đỗ Thị H', 32, N'0932109876 ', N'user8', N'password8')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH009', N'777777777777', N'Vũ Văn I', 45, N'0921098765 ', N'user9', N'password9')
INSERT [dbo].[Khach] ([MaKhach], [CCCD], [TenKhachHang], [Tuoi], [SDT], [TaiKhoan], [MK]) VALUES (N'KH010', N'888888888888', N'Phan Thị K', 27, N'0910987654 ', N'user10', N'password10')
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe], [SoGhe]) VALUES (N'LX001', N'Xe 45 chổ 1 tầng', 45)
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe], [SoGhe]) VALUES (N'LX002', N'Xe 45 chổ 2 tầng', 80)
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe], [SoGhe]) VALUES (N'LX003', N'Xe 16 chổ', 16)
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe], [SoGhe]) VALUES (N'LX004', N'Xe 17 chổ', 17)
INSERT [dbo].[LoaiXe] ([MaLoaiXe], [TenLoaiXe], [SoGhe]) VALUES (N'LX005', N'Xe 29 chổ', 29)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MatKhau], [Quyen]) VALUES (N'NV001', N'Nguyễn Hoàng Tuấn', N'tuan123', N'Admin')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MatKhau], [Quyen]) VALUES (N'NV002', N'Phan Nguyễn Duy Hưng', N'hung123', N'User')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT001', N'TP.HCM')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT002', N'Vũng Tàu')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT003', N'Long An')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT004', N'Cần Thơ')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT005', N'Bà Rịa-Vũng Tàu')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT006', N'Bạc Liêu')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT007', N'An Giang')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT008', N'Rạch Giá')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT009', N'Bến Tre')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT010', N'Tiền Giang')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT011', N'Hậu Giang')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT012', N'Sóc Trăng')
INSERT [dbo].[TinhThanh] ([MaTinh], [TenTinh]) VALUES (N'TT013', N'Cà Mau')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM001', N'CH001', N'Trạm 1', N'TT001')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM002', N'CH001', N'Trạm 2', N'TT001')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM003', N'CH001', N'Trạm 3', N'TT001')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM004', N'CH001', N'Trạm 4', N'TT001')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM005', N'CH001', N'Trạm 5', N'TT002')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM006', N'CH001', N'Trạm 6', N'TT002')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM007', N'CH001', N'Trạm 7', N'TT002')
INSERT [dbo].[Tram] ([MaTram], [Chuyen], [TenTram], [MaTinh]) VALUES (N'TM008', N'CH001', N'Trạm 8', N'TT002')
INSERT [dbo].[Ve] ([MaVe], [NgayDat], [TrangThai], [MaKhach], [SoGhe], [Xe]) VALUES (N'VE001', CAST(N'2023-10-24' AS Date), N'Đã đặt', N'KH001', N'01', N'XE001')
INSERT [dbo].[Ve] ([MaVe], [NgayDat], [TrangThai], [MaKhach], [SoGhe], [Xe]) VALUES (N'VE002', CAST(N'2023-10-25' AS Date), N'Hủy', N'KH002', N'02', N'XE002')
INSERT [dbo].[Ve] ([MaVe], [NgayDat], [TrangThai], [MaKhach], [SoGhe], [Xe]) VALUES (N'VE003', CAST(N'2023-10-26' AS Date), N'Đã đặt', N'KH003', N'03', N'XE002')
INSERT [dbo].[Ve] ([MaVe], [NgayDat], [TrangThai], [MaKhach], [SoGhe], [Xe]) VALUES (N'VE004', CAST(N'2023-10-27' AS Date), N'Hủy', N'KH004', N'02', N'XE001')
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE001', N'43A-1234', N'CH001', N'Nguyễn Văn Tài', N'LX001', N'Hoạt động', N'HX001', CAST(N'2023-10-14 00:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time), 100000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE002', N'75B-5678', N'CH001', N'Trần Thị Hương', N'LX002', N'Hoạt động', N'HX002', CAST(N'2023-10-14 00:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE003', N'29C-9876', N'CH001', N'Lê Văn Minh', N'LX003', N'Hoạt động', N'HX002', CAST(N'2023-11-23 00:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time), 180000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE004', N'58D-5432', N'CH001', N'Phạm Thị Ngọc', N'LX004', N'Hoạt động', N'HX004', CAST(N'2023-11-23 00:00:00.000' AS DateTime), CAST(N'10:30:00' AS Time), 120000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE005', N'12E-8765', N'CH002', N'Hồ Văn Hoàng', N'LX005', N'Hoạt động', N'HX004', CAST(N'2023-11-23 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time), 90000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE006', N'64F-4321', N'CH002', N'Mai Thị Phương', N'LX003', N'Hoạt động', N'HX003', CAST(N'2023-11-23 00:00:00.000' AS DateTime), CAST(N'12:30:00' AS Time), 100000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE007', N'37G-8765', N'CH002', N'Lý Văn Tùng', N'LX004', N'Hoạt động', N'HX001', CAST(N'2023-12-25 00:00:00.000' AS DateTime), CAST(N'09:30:00' AS Time), 200000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE008', N'89H-4321', N'CH002', N'Đỗ Thị Mai', N'LX005', N'Hoạt động', N'HX002', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'05:30:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE009', N'56I-9876', N'CH003', N'Vũ Văn Thắng', N'LX003', N'Hoạt động', N'HX003', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'07:00:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE010', N'21J-1234', N'CH003', N'Phan Thị Lan', N'LX004', N'Hoạt động', N'HX004', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time), 180000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE011', N'48K-5678', N'CH004', N'Trần Văn Khôi', N'LX005', N'Hoạt động', N'HX002', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'04:00:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE012', N'93L-9876', N'CH004', N'Nguyễn Thị Bích', N'LX003', N'Hoạt động', N'HX001', CAST(N'2023-12-26 00:00:00.000' AS DateTime), CAST(N'06:30:00' AS Time), 110000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE013', N'56I-9844', N'CH003', N'Vũ Văn Thắng', N'LX003', N'Hoạt động', N'HX003', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'07:00:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE014', N'27T-1234', N'CH003', N'Phan Thị Lan', N'LX004', N'Hoạt động', N'HX004', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time), 180000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE015', N'48I-5763', N'CH004', N'Trần Văn Khôi', N'LX005', N'Hoạt động', N'HX002', CAST(N'2023-12-23 00:00:00.000' AS DateTime), CAST(N'04:00:00' AS Time), 150000)
INSERT [dbo].[Xe] ([MaXe], [SoXe], [MaChuyen], [TenTaiXe], [LoaiXe], [TrangThai], [MaHangXe], [TGXuatPhat], [TGHuyVe], [Gia]) VALUES (N'XE016', N'93H-9996', N'CH004', N'Nguyễn Thị Bích', N'LX003', N'Hoạt động', N'HX001', CAST(N'2023-12-26 00:00:00.000' AS DateTime), CAST(N'06:30:00' AS Time), 110000)
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD FOREIGN KEY([DiemBatDau])
REFERENCES [dbo].[TinhThanh] ([MaTinh])
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD FOREIGN KEY([DiemDen])
REFERENCES [dbo].[TinhThanh] ([MaTinh])
GO
ALTER TABLE [dbo].[CTDichVu]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTDichVu]  WITH CHECK ADD FOREIGN KEY([Xe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD FOREIGN KEY([Xe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[Tram]  WITH CHECK ADD FOREIGN KEY([Chuyen])
REFERENCES [dbo].[Chuyen] ([MaChuyen])
GO
ALTER TABLE [dbo].[Tram]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[TinhThanh] ([MaTinh])
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD FOREIGN KEY([SoGhe], [Xe])
REFERENCES [dbo].[Ghe] ([SoGhe], [Xe])
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD FOREIGN KEY([MaKhach])
REFERENCES [dbo].[Khach] ([MaKhach])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([LoaiXe])
REFERENCES [dbo].[LoaiXe] ([MaLoaiXe])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([MaChuyen])
REFERENCES [dbo].[Chuyen] ([MaChuyen])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([MaHangXe])
REFERENCES [dbo].[HangXe] ([MaHangXe])
GO
