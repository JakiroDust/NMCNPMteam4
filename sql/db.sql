﻿CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

CREATE TABLE PHONG
(
	MaPhong int identity NOT NULL PRIMARY KEY,
	TenPhong Nvarchar(10) not null,
	MaLoaiPhong INT,
	GhiChu NVARCHAR(200),
	TinhTrang BIT default 1 --0: dang su dung|| 1: con trong
)
GO	


Create Table LOAIPHONG
(
	MaLoaiPhong  INT IDENTITY not null primary key,
	TenLoaiPhong nVarchar(20) not null,
	DonGia MONEY
)
GO


CREATE TABLE PHIEUTHUEPHONG 
(
	MaPhieuThuePhong INT IDENTITY NOT NULL PRIMARY KEY,
	MaPhong int,
	SoLuongKhach INT,
	NgayBDThue DATE,
	NgayKTThue DATE,
	DonGiaSan MONEY
) 
GO	

CREATE TABLE CT_PHIEUTHUEPHONG
(
	MaCTPTP INT IDENTITY PRIMARY KEY,
	MaPhieuThuePhong INT NOT NULL,
	TenKH NVARCHAR(50),
	MaLoaiKhach int,
	CMND NVARCHAR(20),
	DiaChi NVARCHAR(50)
)
GO

CREATE TABLE LOAIKHACH
(	MaLoaiKhach INT IDENTITY NOT NULL PRIMARY KEY,
	LoaiKhach NVARCHAR(20),
	HeSo FLOAT
)
GO

CREATE TABLE HOADON
(
	MaHoadon INT IDENTITY NOT NULL PRIMARY KEY,
	TenKH NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(20),
	TriGia MONEY,
	NgayHD DATE
)
GO	

CREATE TABLE CT_HOADON
(
	MaCTHD INT IDENTITY PRIMARY KEY,
	MaPhieuThuePhong INT,
  	MaHoaDon INT NOT NULL,
	SoNgayThue INT,
	ThanhTien MONEY
)
GO	

CREATE TABLE BAOCAODOANHTHUTHEOLOAIPHONG
(
	MaBaoCaoDoanhThuTheoLoaiPhong INT IDENTITY PRIMARY KEY,
	Thang SMALLINT,
	Nam SMALLINT,
	TongTatCaDoanhThu MONEY,

)
GO

Create table CT_BAOCAODOANHTHUTHEOLOAIPHONG
(
	MaCT_BaoCaoDoanhThuTheoLoaiPhong INT IDENTITY PRIMARY KEY,
	MaBaoCaoDoanhThuTheoLoaiPhong INT,
	MaLoaiPhong int
	,
	TongDoanhThu Money,
	TiLe FLOAT
)
GO	

CREATE TABLE THAMSO(
    TenThamSo NVARCHAR(13),
    GiaTriThamSo float
)
GO

Create table PHUTHU(
	MaPhuThu INT IDENTITY PRIMARY KEY,
	SoLuongKhach int not null,
	PhuThu float
)
GO
   

-- Phong --
ALTER TABLE dbo.PHONG ADD CONSTRAINT FK_PHONG_LOAIPHONG FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)	 ON DELETE CASCADE
-- phieu thue phong --
ALTER TABLE dbo.PHIEUTHUEPHONG ADD CONSTRAINT FK_PHIEUTHUEPHONG_PHONG FOREIGN KEY(MaPhong) REFERENCES dbo.PHONG(MaPhong) ON DELETE CASCADE

-- Chi tiet phieu thue phong
ALTER TABLE dbo.CT_PHIEUTHUEPHONG ADD CONSTRAINT FK_CT_PHIEUTHUEPHONG_PHIEUTHUEPHONG FOREIGN KEY(MaPhieuThuePhong) REFERENCES dbo.PhieuThuePhong(MaPhieuThuePhong) ON DELETE CASCADE
ALTER TABLE dbo.CT_PHIEUTHUEPHONG ADD CONSTRAINT FK_CT_PHIEUTHUEPHONG_MaLOAIKHACH FOREIGN KEY(MaLoaiKhach) REFERENCES dbo.LOAIKHACH(MaLoaiKhach) ON DELETE CASCADE

-- Chi tiet hoa don --
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON_PHIEUTHUEPHONG FOREIGN KEY(MaPhieuThuePhong) REFERENCES  dbo.PHIEUTHUEPHONG(MaPhieuThuePhong) ON DELETE CASCADE
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON FOREIGN KEY(MaHoaDon) REFERENCES  dbo.HOADON(MaHoaDon) ON DELETE CASCADE

-- Bao cao doanh thu theo loai phong --

ALTER TABLE dbo.CT_BAOCAODOANHTHUTHEOLOAIPHONG ADD CONSTRAINT FK_CT_BAOCAODOANHTHUTHEOLOAIPHONG_LOAIPHONG FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong) ON DELETE CASCADE
ALTER TABLE dbo.CT_BAOCAODOANHTHUTHEOLOAIPHONG ADD CONSTRAINT FK_CT_BAOCAODOANHTHUTHEOLOAIPHONG_BAOCAODOANHTHUTHEOLOAIPHONG FOREIGN KEY(MaBaoCaoDoanhThuTheoLoaiPhong) REFERENCES dbo.BAOCAODOANHTHUTHEOLOAIPHONG(MaBaoCaoDoanhThuTheoLoaiPhong)  ON DELETE CASCADE

