
CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

CREATE TABLE PHONG
(
	MaPhong NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaLoaiPhong nvarchar(10),
	GhiChu NVARCHAR(200),
	TinhTrang BIT --0: dang su dung|| 1: con trong
)

GO	


Create Table LoaiPhong
(
	MaLoaiPhong nvarchar(10) not null primary key,
	DonGia MONEY
)

ALTER TABLE dbo.Phong ADD CONSTRAINT FK_Phong_LoaiPhong FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LoaiPhong(MaLoaiPhong)	


GO	

CREATE TABLE PhieuThuePhong 
(
	MaPhieu NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaPhong NVARCHAR(10),
	SoLuongKhach INT,
	NgayBDThue DATE,
	NgayKTThue DATE
) 
GO	

CREATE TABLE CTPhieuThuePhong
(
	ID INT IDENTITY PRIMARY KEY,
	MaPhieu NVARCHAR(10) NOT NULL,
	TenKH NVARCHAR(50),
	LoaiKhach NVARCHAR(20),
	CMND NVARCHAR(20),
	DiaChi NVARCHAR(50)
)
GO	

CREATE TABLE HoaDon
(
	MaHD NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenKH NVARCHAR(50),
	TenCoQuan NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(20),
	TriGia MONEY
)
GO	

CREATE TABLE CTHD
(
	ID INT IDENTITY PRIMARY KEY,
	MaPhieu NVARCHAR(10) NOT NULL,
  	MaHD NVARCHAR(10) NOT NULL,
	SoNgayThue INT,
	ThanhTien MONEY
)
GO	

CREATE TABLE BaoCaoDoanhThuTheoLoaiPhong 
(
	ID INT IDENTITY PRIMARY KEY,
	Thang SMALLINT,
	Nam SMALLINT,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	DoanhThu MONEY,
	TyLe FLOAT
)
GO	

CREATE TABLE ThamSo(
    TenThamSo NVARCHAR(13),
    GiaTriThamSo float
);
   



-- phieu thue phong --
ALTER TABLE dbo.PhieuThuePhong ADD CONSTRAINT FK_PhieuThuePhong_Phong FOREIGN KEY(MaPhong) REFERENCES dbo.PHONG(MaPhong)

-- Chi tiet phieu thue phong
ALTER TABLE dbo.CTPhieuThuePhong ADD CONSTRAINT FK_CTPhieuThuePhong_PhieuThuePhong FOREIGN KEY(MaPhieu) REFERENCES dbo.PhieuThuePhong(MaPhieu)

-- Chi tiet hoa don --
ALTER TABLE dbo.CTHD ADD CONSTRAINT FK_CTHD_PhieuThuePhong FOREIGN KEY(MaPhieu) REFERENCES  dbo.PhieuThuePhong(MaPhieu)
ALTER TABLE dbo.CTHD ADD CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY(MaHD) REFERENCES  dbo.HoaDon(MaHD)

-- Bao cao doanh thu theo loai phong --
ALTER TABLE dbo.BaoCaoDoanhThuTheoLoaiPhong ADD CONSTRAINT FK_BaoCaoDoanhThuTheoLoaiPhong_Phong FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LoaiPhong(MaLoaiPhong)

-- Quy dinh --
/*
ALTER TABLE dbo.ThamSo ADD CONSTRAINT FK_QuyDinh_CTPhieuThuePhong FOREIGN KEY(LoaiKhach) REFERENCES dbo.QuyDinh(LoaiKhach)
*/
