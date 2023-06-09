USE [QLPhong]
GO
/****** Object:  Table [dbo].[Hopdong_Khachhang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hopdong_Khachhang](
	[ID_Hopdong] [int] NOT NULL,
	[ID_Khachhang] [int] NOT NULL,
 CONSTRAINT [PK_Hopdong_Khachhang] PRIMARY KEY CLUSTERED 
(
	[ID_Hopdong] ASC,
	[ID_Khachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcauhinh]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcauhinh](
	[id_quanly] [int] IDENTITY(1,1) NOT NULL,
	[taikhoan] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[Tenphongtro] [nvarchar](150) NULL,
	[Chuphongtro] [nvarchar](150) NOT NULL,
	[Diachiphongtro] [nvarchar](250) NOT NULL,
	[Dongiadien] [int] NULL,
	[DongiaNuoc] [int] NULL,
	[SDT] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblcauhinh] PRIMARY KEY CLUSTERED 
(
	[id_quanly] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblchitiethopdong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblchitiethopdong](
	[ID_CTHopdong] [int] IDENTITY(1,1) NOT NULL,
	[ID_Hopdong] [int] NULL,
	[Ngaybatdau] [date] NULL,
	[Ngayketthuc] [date] NULL,
	[CSD_Cu] [int] NULL,
	[CSD_Moi] [int] NULL,
	[CSN_Cu] [int] NULL,
	[CSN_Moi] [int] NULL,
	[Dathanhtoan] [int] NULL,
 CONSTRAINT [PK_tblchitiethopdong] PRIMARY KEY CLUSTERED 
(
	[ID_CTHopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblhopdong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblhopdong](
	[ID_Hopdong] [int] IDENTITY(1,1) NOT NULL,
	[ID_Phong] [int] NULL,
	[Giaphong] [int] NULL,
	[DatCoc] [int] NULL,
	[Dongiadien] [int] NULL,
	[TienInternet] [int] NULL,
	[TienVesinh] [int] NULL,
	[Dongianuoc] [int] NULL,
	[Daketthuc] [bit] NULL,
 CONSTRAINT [PK_tblhopdong] PRIMARY KEY CLUSTERED 
(
	[ID_Hopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblkhachhang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblkhachhang](
	[ID_Khachhang] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Tendem] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[CCCD] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[Quequan] [nvarchar](150) NULL,
	[HKTT] [nvarchar](150) NULL,
	[Trangthai] [bit] NULL,
 CONSTRAINT [PK_tblkhachhang] PRIMARY KEY CLUSTERED 
(
	[ID_Khachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblkhutro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblkhutro](
	[ID_Khutro] [int] IDENTITY(1,1) NOT NULL,
	[Tenkhu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblkhutro] PRIMARY KEY CLUSTERED 
(
	[ID_Khutro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblloaiphong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblloaiphong](
	[ID_Loaiphong] [int] IDENTITY(1,1) NOT NULL,
	[Tenloaiphong] [nchar](10) NULL,
	[Dongia] [int] NULL,
 CONSTRAINT [PK_tblloaiphong] PRIMARY KEY CLUSTERED 
(
	[ID_Loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblphong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblphong](
	[ID_Phong] [int] IDENTITY(1,1) NOT NULL,
	[ID_loaiphong] [int] NULL,
	[ID_Tangtro] [int] NULL,
	[Tenphong] [nchar](10) NULL,
	[trangthai] [bit] NULL,
 CONSTRAINT [PK_tblphong] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuanly]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuanly](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblQuanly] PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbltangtro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbltangtro](
	[ID_Tangtro] [int] IDENTITY(1,1) NOT NULL,
	[ID_khutro] [int] NULL,
	[Tentang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbltangtro] PRIMARY KEY CLUSTERED 
(
	[ID_Tangtro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblcauhinh] ON 

INSERT [dbo].[tblcauhinh] ([id_quanly], [taikhoan], [matkhau], [Tenphongtro], [Chuphongtro], [Diachiphongtro], [Dongiadien], [DongiaNuoc], [SDT]) VALUES (1, N'admin', N'123', N'ĐH Hà Tĩnh', N'Líu Văn Lịu', N'Xã Cẩm Bình, Huyện Cẩm Xuyên, Tỉnh Hà tĩnh', 1500, 3000, N'0333346071')
INSERT [dbo].[tblcauhinh] ([id_quanly], [taikhoan], [matkhau], [Tenphongtro], [Chuphongtro], [Diachiphongtro], [Dongiadien], [DongiaNuoc], [SDT]) VALUES (2, N'LHAnh', N'02112002', N'Hạnh Phúc', N'LHAnh', N'abcxyz', 1500, 3000, N'0372236390')
SET IDENTITY_INSERT [dbo].[tblcauhinh] OFF
GO
SET IDENTITY_INSERT [dbo].[tblkhutro] ON 

INSERT [dbo].[tblkhutro] ([ID_Khutro], [Tenkhu]) VALUES (1, N'Khu 1')
INSERT [dbo].[tblkhutro] ([ID_Khutro], [Tenkhu]) VALUES (2, N'Khu 2')
SET IDENTITY_INSERT [dbo].[tblkhutro] OFF
GO
SET IDENTITY_INSERT [dbo].[tblloaiphong] ON 

INSERT [dbo].[tblloaiphong] ([ID_Loaiphong], [Tenloaiphong], [Dongia]) VALUES (1, N'Phòng đơn ', 1000000)
INSERT [dbo].[tblloaiphong] ([ID_Loaiphong], [Tenloaiphong], [Dongia]) VALUES (2, N'Phòng đôi ', 2000000)
SET IDENTITY_INSERT [dbo].[tblloaiphong] OFF
GO
SET IDENTITY_INSERT [dbo].[tblphong] ON 

INSERT [dbo].[tblphong] ([ID_Phong], [ID_loaiphong], [ID_Tangtro], [Tenphong], [trangthai]) VALUES (1, 1, 1, N'Phòng 1   ', 1)
INSERT [dbo].[tblphong] ([ID_Phong], [ID_loaiphong], [ID_Tangtro], [Tenphong], [trangthai]) VALUES (3, 2, 1, N'Phòng 2   ', 1)
INSERT [dbo].[tblphong] ([ID_Phong], [ID_loaiphong], [ID_Tangtro], [Tenphong], [trangthai]) VALUES (4, 1, 1, N'Phòng 3   ', 1)
SET IDENTITY_INSERT [dbo].[tblphong] OFF
GO
SET IDENTITY_INSERT [dbo].[tbltangtro] ON 

INSERT [dbo].[tbltangtro] ([ID_Tangtro], [ID_khutro], [Tentang]) VALUES (1, 1, N'Tầng 1')
INSERT [dbo].[tbltangtro] ([ID_Tangtro], [ID_khutro], [Tentang]) VALUES (3, 1, N'Tầng 2')
SET IDENTITY_INSERT [dbo].[tbltangtro] OFF
GO
ALTER TABLE [dbo].[tblcauhinh] ADD  CONSTRAINT [DF_tblcauhinh_Dongiadien]  DEFAULT ((1500)) FOR [Dongiadien]
GO
ALTER TABLE [dbo].[tblcauhinh] ADD  CONSTRAINT [DF_tblcauhinh_DongiaNuoc]  DEFAULT ((3000)) FOR [DongiaNuoc]
GO
ALTER TABLE [dbo].[tblhopdong] ADD  CONSTRAINT [DF_tblhopdong_TienInternet]  DEFAULT ((0)) FOR [TienInternet]
GO
ALTER TABLE [dbo].[tblhopdong] ADD  CONSTRAINT [DF_tblhopdong_TienVesinh]  DEFAULT ((0)) FOR [TienVesinh]
GO
ALTER TABLE [dbo].[tblhopdong] ADD  CONSTRAINT [DF_tblhopdong_Daketthuc]  DEFAULT ((0)) FOR [Daketthuc]
GO
ALTER TABLE [dbo].[tblkhachhang] ADD  CONSTRAINT [DF_tblkhachhang_Trangthai]  DEFAULT ((1)) FOR [Trangthai]
GO
ALTER TABLE [dbo].[tblphong] ADD  CONSTRAINT [DF_tblphong_trangthai]  DEFAULT ((0)) FOR [trangthai]
GO
ALTER TABLE [dbo].[Hopdong_Khachhang]  WITH CHECK ADD  CONSTRAINT [FK_Hopdong_Khachhang_tblhopdong] FOREIGN KEY([ID_Hopdong])
REFERENCES [dbo].[tblhopdong] ([ID_Hopdong])
GO
ALTER TABLE [dbo].[Hopdong_Khachhang] CHECK CONSTRAINT [FK_Hopdong_Khachhang_tblhopdong]
GO
ALTER TABLE [dbo].[Hopdong_Khachhang]  WITH CHECK ADD  CONSTRAINT [FK_Hopdong_Khachhang_tblkhachhang] FOREIGN KEY([ID_Khachhang])
REFERENCES [dbo].[tblkhachhang] ([ID_Khachhang])
GO
ALTER TABLE [dbo].[Hopdong_Khachhang] CHECK CONSTRAINT [FK_Hopdong_Khachhang_tblkhachhang]
GO
ALTER TABLE [dbo].[tblchitiethopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblchitiethopdong_tblhopdong] FOREIGN KEY([ID_Hopdong])
REFERENCES [dbo].[tblhopdong] ([ID_Hopdong])
GO
ALTER TABLE [dbo].[tblchitiethopdong] CHECK CONSTRAINT [FK_tblchitiethopdong_tblhopdong]
GO
ALTER TABLE [dbo].[tblhopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblhopdong_tblphong] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[tblphong] ([ID_Phong])
GO
ALTER TABLE [dbo].[tblhopdong] CHECK CONSTRAINT [FK_tblhopdong_tblphong]
GO
ALTER TABLE [dbo].[tblphong]  WITH CHECK ADD  CONSTRAINT [FK_tblphong_tblloaiphong1] FOREIGN KEY([ID_loaiphong])
REFERENCES [dbo].[tblloaiphong] ([ID_Loaiphong])
GO
ALTER TABLE [dbo].[tblphong] CHECK CONSTRAINT [FK_tblphong_tblloaiphong1]
GO
ALTER TABLE [dbo].[tblphong]  WITH CHECK ADD  CONSTRAINT [FK_tblphong_tbltangtro] FOREIGN KEY([ID_Tangtro])
REFERENCES [dbo].[tbltangtro] ([ID_Tangtro])
GO
ALTER TABLE [dbo].[tblphong] CHECK CONSTRAINT [FK_tblphong_tbltangtro]
GO
ALTER TABLE [dbo].[tbltangtro]  WITH CHECK ADD  CONSTRAINT [FK_tbltangtro_tblkhutro] FOREIGN KEY([ID_khutro])
REFERENCES [dbo].[tblkhutro] ([ID_Khutro])
GO
ALTER TABLE [dbo].[tbltangtro] CHECK CONSTRAINT [FK_tbltangtro_tblkhutro]
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteKhuTro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteKhuTro]
	@ID_Khutro int
AS
BEGIN
	DECLARE @v_countidkhutro INT ;
	SET @v_countidkhutro =	(SELECT COUNT(ID_khutro) FROM dbo.tbltangtro WHERE ID_khutro = @ID_Khutro);
	IF (@v_countidkhutro = 0 )
		DELETE FROM  dbo.tblkhutro	WHERE ID_Khutro = @ID_Khutro
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteLoaiPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteLoaiPhong]
	@id_loaiphong INT

AS	
	DECLARE @v_countidloaiphong INT ;
	SET @v_countidloaiphong =(SELECT COUNT(ID_loaiphong) FROM dbo.tblphong WHERE ID_loaiphong = @id_loaiphong);
	IF (@v_countidloaiphong = 0 )
		DELETE FROM dbo.tblloaiphong WHERE ID_Loaiphong = @id_loaiphong
GO
/****** Object:  StoredProcedure [dbo].[USP_DeletePhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeletePhong]
	 @id_phong int
AS 
	DELETE FROM dbo.tblphong WHERE ID_Phong = @id_phong
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteTang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteTang]
	@ID_Tang INT

AS 
	DECLARE @v_countidtang INT ;
	SET @v_countidtang =(SELECT COUNT(ID_Tangtro) FROM dbo.tblphong WHERE ID_Tangtro = @ID_Tang);
	IF (@v_countidtang = 0 )
		DELETE FROM dbo.tbltangtro WHERE ID_Tangtro = @ID_Tang
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccountByUserName] 
	@taikhoan NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.tblcauhinh WHERE taikhoan = @taikhoan
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetALLALLDSthuephong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetALLALLDSthuephong]
	
AS
BEGIN

	SELECT 
		ct.ID_CTHopdong,
		hd.ID_Hopdong,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		hd.Giaphong,
		hd.DatCoc,
		ct.Ngaybatdau,
		ct.Ngayketthuc,
		ct.CSD_Cu,
		ct.CSD_Moi,
		hd.Dongiadien,
		hd.Dongianuoc,
		ct.CSN_Cu,
		ct.CSN_Moi,
		(ct.CSD_Moi - ct.CSD_Cu) AS	Dientieuthu,
		(ct.CSN_Moi - ct.CSN_Cu) AS	Nuoctieuthu,
		hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) AS Tiendien,
		hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) AS Tiennuoc,
		hd.TienInternet,
		hd.TienVeSinh,
		(hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) + hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) +hd.TienInternet + hd.TienVeSinh + hd.Giaphong) AS Tongtien,
		ct.Dathanhtoan,
		((hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) + hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) +hd.TienInternet + hd.TienVeSinh + hd.Giaphong) - ct.Dathanhtoan) AS	Conlai
	FROM dbo.tblhopdong hd
	INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
	INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
	INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
	INNER JOIN dbo.tblchitiethopdong ct ON ct.ID_Hopdong = hd.ID_Hopdong
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllAllKhachHang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllAllKhachHang] 
	
AS
BEGIN
	SELECT 
		kh.ID_Khachhang,
		kh.Ho,
		kh.Tendem,
		kh.Ten,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		hd.Giaphong,
		kh.CCCD,
		kh.SDT,
		kh.Quequan,
		kh.HKTT,
		kh.Trangthai
		FROM dbo.tblkhachhang kh
		INNER JOIN dbo.Hopdong_Khachhang hdkh ON hdkh.ID_Khachhang = kh.ID_Khachhang
		INNER JOIN dbo.tblhopdong hd ON hd.ID_Hopdong = hdkh.ID_Hopdong
		INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
		INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
		INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetALLDSthuephong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetALLDSthuephong]
	
AS
BEGIN

	SELECT 
		ct.ID_CTHopdong,
		hd.ID_Hopdong,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		hd.Giaphong,
		hd.DatCoc,
		ct.Ngaybatdau,
		ct.Ngayketthuc,
		ct.CSD_Cu,
		ct.CSD_Moi,
		hd.Dongiadien,
		hd.Dongianuoc,
		ct.CSN_Cu,
		ct.CSN_Moi,
		(ct.CSD_Moi - ct.CSD_Cu) AS	Dientieuthu,
		(ct.CSN_Moi - ct.CSN_Cu) AS	Nuoctieuthu,
		hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) AS Tiendien,
		hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) AS Tiennuoc,
		hd.TienInternet,
		hd.TienVeSinh,
		(hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) + hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) +hd.TienInternet + hd.TienVeSinh + hd.Giaphong) AS Tongtien,
		ct.Dathanhtoan,
		((hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) + hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) +hd.TienInternet + hd.TienVeSinh + hd.Giaphong) - ct.Dathanhtoan) AS	Conlai
	FROM dbo.tblhopdong hd
	INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
	INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
	INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
	INNER JOIN dbo.tblchitiethopdong ct ON ct.ID_Hopdong = hd.ID_Hopdong
	LEFT JOIN dbo.tblchitiethopdong ct2  ON ct2.ID_Hopdong = ct.ID_Hopdong AND ct.ID_CTHopdong < ct2.ID_CTHopdong
	WHERE hd.Daketthuc = 0 AND ct2.ID_CTHopdong IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllHopdong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllHopdong]
	@id_hopdong INT
AS
BEGIN
	DECLARE @v_tiendien INT;
	DECLARE @v_tiennuoc INT;
	DECLARE @v_tienDienThangHienTai INT;
	DECLARE @v_tienNuocThangHienTai INT;
	DECLARE @v_tongTienCacThang INT;
	DECLARE @v_soTienDaTra INT;
	DECLARE @v_soThangDaThue INT;
	DECLARE @v_idThangHienTai INT;
	--tính tiền điện
	SET @v_tiendien = (SELECT TOP(1) 
						hd.Dongiadien * (ct.CSD_Moi - ct.CSD_Cu) 
						FROM dbo.tblchitiethopdong ct
						INNER JOIN dbo.tblhopdong hd ON hd.ID_Hopdong = ct.ID_Hopdong
						WHERE hd.ID_Hopdong = @id_hopdong 
						ORDER BY ID_CTHopdong DESC);
	-- tính tiền nước
	SET @v_tiennuoc = (SELECT TOP(1) 
						hd.Dongianuoc * (ct.CSN_Moi - ct.CSN_Cu) 
						FROM dbo.tblchitiethopdong ct
						INNER JOIN dbo.tblhopdong hd ON hd.ID_Hopdong = ct.ID_Hopdong
						WHERE hd.ID_Hopdong = @id_hopdong 
						ORDER BY ID_CTHopdong DESC)

	--tính ID lớn nhất của chitiethopdong ứng với hợp đồng được chọn <=> chi tiết hợp đồng mới nhất
	SET @v_idThangHienTai = (SELECT MAX(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong);


	---TÍNH TỔNG TIỀN CẦN TRẢ VÀ ĐÃ ĐƯỢC TRẢ TRƯỚC ĐÓ (KHÔNG BAO GỒM THÁNG HIỆN TẠI)


	--1. Tính số tháng đã thuê của hợp đồng được chọn (không bao gồm tháng hiện tại = chi tiết hợp đồng có ID = @v_idThangHienTai)
	DECLARE @v_countmonth INT = 0;
	SET @v_soThangDaThue = (SELECT COUNT(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong AND ID_CTHopdong <@v_idThangHienTai);
	IF(@v_soThangDaThue = @v_countmonth)
		SET	@v_soThangDaThue = 1;
	SET @v_soThangDaThue = (SELECT COUNT(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong AND ID_CTHopdong <@v_idThangHienTai);

	--2. tổng tiền cần trả của các tháng đã thuê
	SET @v_tongTienCacThang = (SELECT 
								(hd.Giaphong + hd.Tieninternet + hd.Tienvesinh) * @v_soThangDaThue 
								+ SUM(@v_tiennuoc) 
								+ SUM(@v_tiendien)
								FROM dbo.tblchitiethopdong ct
								INNER JOIN dbo.tblhopdong hd ON ct.ID_Hopdong = hd.ID_Hopdong
								WHERE ct.ID_Hopdong = @id_hopdong AND ct.ID_CTHopdong <@v_idThangHienTai
								GROUP BY hd.Giaphong , hd.Tieninternet , hd.Tienvesinh);

	--3. số tiền đã thanh toán( không bao gồm số tháng hiện tại ) = tổng số tiền đã trả hàng tháng
	SET @v_soTienDaTra = (SELECT ISNULL(SUM(Dathanhtoan),0) FROM	dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong AND ID_CTHopdong <@v_idThangHienTai);

    SELECT
		hd.ID_Hopdong,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		hd.Giaphong,
		@v_tiendien AS Tiendien,
		@v_tiennuoc AS Tiennuoc,
		hd.TienInternet,
		hd.TienVeSinh,
		(hd.Giaphong + hd.Tieninternet + hd.Tienvesinh + @v_tiendien + @v_tiennuoc) AS Tongtiencuathang,
		(ISNULL(@v_tongTienCacThang, 0) -@v_soTienDaTra)AS	sonoconthieu,
		ISNULL(@v_tongTienCacThang, 0) AS tongtiencacthang,
		@v_soTienDaTra AS datra,
		(ISNULL(@v_tongTienCacThang, 0) - @v_soTienDaTra 
			+ (hd.Giaphong + hd.Tieninternet + hd.Tienvesinh + @v_tiendien + @v_tiennuoc))AS	tongtienphaitra
		FROM dbo.tblhopdong hd
		INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
		INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
		INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
		INNER JOIN dbo.tblchitiethopdong ct ON ct.ID_Hopdong = hd.ID_Hopdong
		WHERE ct.ID_CTHopdong = @v_idThangHienTai;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllKhachHang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllKhachHang] 
	
AS
BEGIN
	SELECT 
		kh.ID_Khachhang,
		kh.Ho,
		kh.Tendem,
		kh.Ten,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		hd.Giaphong,
		kh.CCCD,
		kh.SDT,
		kh.Quequan,
		kh.HKTT,
		kh.Trangthai
		FROM dbo.tblkhachhang kh
		INNER JOIN dbo.Hopdong_Khachhang hdkh ON hdkh.ID_Khachhang = kh.ID_Khachhang
		INNER JOIN dbo.tblhopdong hd ON hd.ID_Hopdong = hdkh.ID_Hopdong
		INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
		INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
		INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
		WHERE kh.Trangthai = 1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllKhutro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllKhutro]
AS
	SELECT * FROM	dbo.tblkhutro
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllLoaiPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllLoaiPhong]

AS 
	SELECT ID_Loaiphong,Tenloaiphong,Dongia FROM dbo.tblloaiphong
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllPhong]

AS 
BEGIN
	SELECT 
		p.ID_Phong,
		kt.Tenkhu,
		tt.ID_Tangtro,
		p.Tenphong,
		lp.ID_Loaiphong,
		lp.Dongia,
		p.trangthai
	FROM dbo.tblphong p 
	INNER JOIN dbo.tbltangtro tt ON tt.ID_Tangtro = p.ID_Tangtro
	INNER JOIN dbo.tblloaiphong lp ON lp.ID_Loaiphong = p.ID_loaiphong
	INNER JOIN dbo.tblkhutro kt ON kt.ID_Khutro = tt.ID_khutro
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllPhongHopdong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllPhongHopdong]

AS
BEGIN
    SELECT 
		p.ID_Phong,
		CONCAT(k.Tenkhu,' - ', t.Tentang,' - ',p.Tenphong) AS	Tenphong,
		lp.Dongia
		FROM dbo.tblphong p 
		INNER JOIN dbo.tbltangtro t ON p.ID_Tangtro = t.ID_Tangtro
		INNER JOIN dbo.tblkhutro k ON k.ID_Khutro = t.ID_khutro
		INNER JOIN dbo.tblloaiphong lp ON lp.ID_Loaiphong = p.ID_loaiphong
		WHERE trangthai = 0
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllPhongTrong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllPhongTrong]

AS 
BEGIN
	SELECT 
		p.ID_Phong,
		kt.Tenkhu,
		tt.ID_Tangtro,
		p.Tenphong,
		lp.ID_Loaiphong,
		lp.Dongia,
		p.trangthai
	FROM dbo.tblphong p 
	INNER JOIN dbo.tbltangtro tt ON tt.ID_Tangtro = p.ID_Tangtro
	INNER JOIN dbo.tblloaiphong lp ON lp.ID_Loaiphong = p.ID_loaiphong
	INNER JOIN dbo.tblkhutro kt ON kt.ID_Khutro = tt.ID_khutro
	WHERE p.trangthai = 0
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllTangTro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAllTangTro]
AS 
	SELECT ID_Tangtro,ID_khutro,Tentang FROM dbo.tbltangtro
GO
/****** Object:  StoredProcedure [dbo].[USP_Insertcauhinh]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Insertcauhinh] 
	@taikhoan NVARCHAR(50), @matkhau NVARCHAR(50) ,@tenphongtro NVARCHAR(50), @chuphongtro NVARCHAR(50), @diachiphongtro NVARCHAR(250), @sdt NVARCHAR(50)
AS
BEGIN
   INSERT INTO dbo.tblcauhinh
   (
       taikhoan,
       matkhau,
       Tenphongtro,
       Chuphongtro,
       Diachiphongtro,
       SDT
   )
   VALUES
   (   @taikhoan, -- taikhoan - nvarchar(50)
       @matkhau, -- matkhau - nvarchar(50)
       @tenphongtro, -- Tenphongtro - nvarchar(150)
       @chuphongtro, -- Chuphongtro - nvarchar(150)
       @diachiphongtro, -- Diachiphongtro - nvarchar(250)
		@sdt   -- SDT - varchar(50)
       )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertChiTietHopDong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertChiTietHopDong]
	@ngaybatdau DATE, @ngayketthuc DATE, @csd_cu INT, @csn_cu INT 
AS
BEGIN
	INSERT INTO dbo.tblchitiethopdong
	(
	    ID_Hopdong,
	    Ngaybatdau,
	    Ngayketthuc,
	    CSD_Cu,
	    CSN_Cu
	)
	VALUES
	(  
	    (SELECT MAX(ID_Hopdong) FROM dbo.tblhopdong),         -- ID_Hopdong - int
	    @ngaybatdau , @ngayketthuc , @csd_cu , @csn_cu  
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertHopdong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertHopdong]
	@id_phong int, @datcoc int, @tienvesinh int, @tieninternet INT
    
AS
BEGIN
	INSERT INTO dbo.tblhopdong
	(
	    ID_Phong,
	    Giaphong,
	    DatCoc,
	    Dongiadien,
	    Dongianuoc,
		Tieninternet,
		Tienvesinh
	)
	VALUES
	(   @id_phong, -- ID_Phong - int
	    (SELECT 
			lp.dongia
			FROM dbo.tblphong p 
			INNER JOIN dbo.tblloaiphong lp ON p.ID_loaiphong = lp.ID_Loaiphong
			WHERE p.ID_Phong = @id_phong),   -- Giaphong - int
	    @datcoc,  -- DatCoc - int
	    (SELECT TOP(1) Dongiadien FROM dbo.tblcauhinh),    -- Dongiadien - int
	    (SELECT TOP(1) DongiaNuoc FROM dbo.tblcauhinh),  -- Dongianuoc - int
		@tieninternet,
		@tienvesinh
	    )
	UPDATE dbo.tblphong SET trangthai = 1 WHERE ID_Phong = @id_phong
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertKhachhang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertKhachhang]
	@Ho NVARCHAR(50), @tendem NVARCHAR(50), @ten NVARCHAR(50), @cccd VARCHAR(50), @sdt VARCHAR(50), @quequan NVARCHAR(150), @hktt NVARCHAR(150)
AS
BEGIN
SELECT * FROM dbo.tblkhachhang
	INSERT INTO dbo.tblkhachhang
	(
	    Ho,
	    Tendem,
	    Ten,
	    CCCD,
	    SDT,
	    Quequan,
	    HKTT
	)
	VALUES
	(   @Ho, @tendem , @ten , @cccd , @sdt , @quequan , @hktt 
	    )
	
	IF @@ROWCOUNT > 0 
		BEGIN 
			INSERT INTO dbo.Hopdong_Khachhang
			(
			    ID_Hopdong,
			    ID_Khachhang
			)
			VALUES
			(    (SELECT MAX(ID_Hopdong) FROM dbo.tblhopdong),-- ID_Hopdong - int
			     (SELECT MAX(ID_Khachhang) FROM dbo.tblkhachhang)  -- ID_Khachhang - int
			    )
			IF @@ROWCOUNT > 0 RETURN 1
			ELSE RETURN 0
		END
	ELSE RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertKhuTro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertKhuTro]
	@Tenkhu NVARCHAR(50)
AS
	INSERT  dbo.tblkhutro	(tenkhu) VALUES (@Tenkhu)
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertLoaiPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertLoaiPhong]
	@LoaiPhong NVARCHAR(50),
	@dongia INT

AS 
	INSERT dbo.tblloaiphong
	(
	    Tenloaiphong,
		Dongia
	)
	VALUES
	(@LoaiPhong,@dongia -- Tenloaiphong - nchar(10)
	    )
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertPhong]
	 @id_loaiphong int, @ID_tang int, @tenphong NVARCHAR(50)
AS 
	INSERT dbo.tblphong
	(
	    ID_Tangtro,
	    ID_loaiphong,
	    Tenphong
	)
	VALUES
	(   @ID_tang,  -- ID_Tangtro - int
	    @id_loaiphong,  -- ID_loaiphong - int
	    @tenphong -- Tenphong - nchar(10)
	    )
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertTang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertTang]
@tentang NVARCHAR(50),
	@ID_Khu INT
	

AS 
	INSERT dbo.tbltangtro
	(
	    ID_khutro,
	    Tentang
	)
	VALUES
	(   @id_khu,  -- ID_khutro - int
	    @tentang -- Tentang - nvarchar(50)
	    )
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertThanhToanVaGiaHan]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertThanhToanVaGiaHan]
	@id_hopdong INT, @dathanhtoan INT
AS
BEGIN
	DECLARE @v_maxid INT;
	DECLARE @v_ngaybatdau DATE;
	DECLARE @v_csdCu INT;
	DECLARE @v_csnCu INT;
	SET @v_maxid = (SELECT MAX(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong);
	SET @v_ngaybatdau =(SELECT Ngayketthuc FROM	dbo.tblchitiethopdong WHERE ID_Hopdong =  @id_hopdong AND ID_CTHopdong = @v_maxid)
	SET @v_csdCu =(SELECT CSD_Moi FROM	dbo.tblchitiethopdong WHERE ID_Hopdong =  @id_hopdong AND ID_CTHopdong = @v_maxid)
	SET @v_csnCu =(SELECT CSN_Moi FROM	dbo.tblchitiethopdong WHERE ID_Hopdong =  @id_hopdong AND ID_CTHopdong = @v_maxid)
	UPDATE dbo.tblchitiethopdong SET Dathanhtoan = @dathanhtoan WHERE ID_CTHopdong = @v_maxid
	INSERT INTO dbo.tblchitiethopdong
	(
	    ID_Hopdong,
	    Ngaybatdau,
	    Ngayketthuc,
	    CSD_Cu,
	    CSN_Cu
	)
	VALUES
	(   @id_hopdong,         -- ID_Hopdong - int
	    @v_ngaybatdau, -- Ngaybatdau - date
	    DATEADD(day, 30, @v_ngaybatdau), -- Ngayketthuc - date
	    @v_csdCu,         -- CSD_Cu - int
	    @v_csnCu        -- CSN_Cu - int
	    )

END
select * from tblchitiethopdong
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login] 
	@taikhoan NVARCHAR(50) , @matkhau NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.tblcauhinh WHERE taikhoan = @taikhoan AND	 matkhau = @matkhau
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount] 
	@taikhoan NVARCHAR(50), @tenphongtro NVARCHAR(50), @chuphongtro NVARCHAR(50), @diachiphongtro NVARCHAR(150), @dongiadien int, @dongianuoc int, @sdt VARCHAR(50)
AS
BEGIN
    UPDATE dbo.tblcauhinh SET Tenphongtro = @tenphongtro , Chuphongtro = @chuphongtro , Diachiphongtro = @diachiphongtro , Dongiadien =@dongiadien,DongiaNuoc = @dongianuoc , SDT = @sdt WHERE taikhoan = @taikhoan
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateDiennuocmoi]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateDiennuocmoi] 
	@id_hopdong int, @csd_Moi int, @csn_moi INT
AS
BEGIN
	DECLARE @v_maxid INT;
	SET @v_maxid = (SELECT MAX(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong);
    UPDATE dbo.tblchitiethopdong SET CSD_Moi = @csd_Moi , CSN_Moi = @csn_moi WHERE ID_CTHopdong = @v_maxid
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateKhachHang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateKhachHang] 
	@id_khachhang int, @Ho NVARCHAR(50), @tendem NVARCHAR(50), @ten NVARCHAR(50), @cccd VARCHAR(50), @sdt VARCHAR(50), @quequan NVARCHAR(150), @hktt NVARCHAR(150), @trangthai bit
AS
BEGIN
	UPDATE dbo.tblkhachhang SET Ho = @Ho,Tendem = @tendem , Ten =@ten , CCCD = @cccd , SDT = @sdt ,Quequan = @quequan ,HKTT = @hktt , Trangthai = @trangthai WHERE ID_Khachhang = @id_khachhang
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateKhuTro]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateKhuTro]
	@Tenkhu NVARCHAR(50),
	@ID_khutro int
AS
	UPDATE  dbo.tblkhutro	SET  tenkhu = @Tenkhu WHERE ID_Khutro = @ID_khutro
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateLoaiPhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateLoaiPhong]
	@id_loaiphong INT,
	@LoaiPhong NVARCHAR(50),
	@dongia INT

AS 
	UPDATE dbo.tblloaiphong SET Tenloaiphong = @LoaiPhong , dongia = @dongia WHERE	ID_Loaiphong = @id_loaiphong
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePassword]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdatePassword] 
	@taikhoan NVARCHAR(50), @matkhau NVARCHAR(50) ,@matkhaunew NVARCHAR(50)
AS
BEGIN
   DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.tblcauhinh WHERE taikhoan = @taikhoan and matkhau = @matkhau
	IF (@isRightPass = 1)
	BEGIN
		IF (@matkhaunew = null or @matkhaunew = '')
			RETURN
		ELSE
			UPDATE tblcauhinh SET matkhau = @matkhaunew WHERE taikhoan = @taikhoan
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePhong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdatePhong]
	 @id_phong int, @id_loaiphong int, @ID_tang int, @tenphong NVARCHAR(50),  @trangthai BIT
AS 
	UPDATE dbo.tblphong SET ID_loaiphong = @id_loaiphong , ID_Tangtro = @ID_tang , Tenphong =@tenphong , trangthai = @trangthai WHERE ID_Phong = @id_phong
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateTang]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateTang]
	@id_khu INT,
	@tentang NVARCHAR(50),
	@ID_Tang INT

AS 
	UPDATE dbo.tbltangtro SET ID_khutro = @id_khu , Tentang = @tentang WHERE	ID_Tangtro = @ID_Tang
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateThanhtoanvatraphong]    Script Date: 1/10/2023 6:16:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateThanhtoanvatraphong]
	@id_hopdong INT, @dathanhtoan INT
AS
BEGIN
	DECLARE @v_maxid INT;
	DECLARE @v_IDphong	INT;
	SET @v_maxid = (SELECT MAX(ID_CTHopdong) FROM dbo.tblchitiethopdong WHERE ID_Hopdong = @id_hopdong);
	UPDATE dbo.tblchitiethopdong SET Dathanhtoan = @dathanhtoan WHERE ID_CTHopdong = @v_maxid
	UPDATE dbo.tblhopdong SET Daketthuc = 1 WHERE ID_Hopdong = @id_hopdong

	SET @v_IDphong = (SELECT ID_Phong FROM	dbo.tblhopdong WHERE ID_Hopdong = @id_hopdong);

	UPDATE dbo.tblphong SET trangthai = 0 WHERE ID_Phong = @v_IDphong
	UPDATE dbo.tblkhachhang SET Trangthai = 0 WHERE ID_Khachhang In (SELECT kh.ID_Khachhang FROM dbo.tblhopdong hd 
		INNER JOIN dbo.Hopdong_Khachhang hdkh ON hdkh.ID_Hopdong = hd.ID_Hopdong 
		INNER JOIN dbo.tblkhachhang kh ON kh.ID_Khachhang = hdkh.ID_Khachhang
		INNER JOIN dbo.tblphong p ON hd.ID_Phong = p.ID_Phong
		WHERE hd.ID_Hopdong = @id_hopdong)
END
GO
