/*base query by Thang*/
CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

CREATE TABLE LOAIPHONG 
(
	MaLoaiPhong NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenLoaiPhong NVARCHAR(50),
	DonGia FLOAT,
	GhiChu NVARCHAR(200)
)
GO	

CREATE TABLE PHONG 
(
	MaPhong NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	TinhTrang NVARCHAR(10) --Free || Occupied
)
GO	

CREATE TABLE PHIEUTHUEPHONG 
(
	MaPhieuThue NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaPhong NVARCHAR(10) NOT NULL,
	SoLuongKhach INT,
	NgayBDThue DATE,
	DonGiaSan FLOAT
) 
GO	

CREATE TABLE CTPHIEUTHUEPHONG
(
	MaCTPTP INT IDENTITY PRIMARY KEY,
	MaPhieuThue NVARCHAR(10) NOT NULL,
	TenKH NVARCHAR(50),
	MaLoaiKhach NVARCHAR(10),
	CMND NVARCHAR(20),
	DiaChi NVARCHAR(50)
)
GO

CREATE TABLE LOAIKHACH
(
	MaLoaiKhach NVARCHAR(10) NOT NULL PRIMARY KEY,
	LoaiKhach NVARCHAR(10),
	HeSo FLOAT
)
GO

CREATE TABLE HOADON
(
	MaHD NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenKH NVARCHAR(50),
	TenCoQuan NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(20),
	TriGia MONEY
)
GO	

CREATE TABLE CT_HOADON
(
	ID INT IDENTITY PRIMARY KEY,
	MaPhieu NVARCHAR(10) NOT NULL,
  	MaHD NVARCHAR(10) NOT NULL,
	SoNgayThue INT,
	ThanhTien FLOAT
)
GO	

CREATE TABLE BCDT 
(
	MaBCDT INT IDENTITY PRIMARY KEY,
	Thang SMALLINT,
	Nam SMALLINT,
	Tong FLOAT
)
GO	

CREATE TABLE CTBCDT
(
	MaCTBCDT INT IDENTITY PRIMARY KEY,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	MaBCDT INT,
	TiLe FLOAT, 
	TongDoanhThu FLOAT
)
GO

CREATE TABLE THAMSO
(
    SoLuongKhach INT,
    PhuThu FLOAT
)
GO
   

-- danh sach phong --
ALTER TABLE dbo.PHONG ADD CONSTRAINT FK_PHONG_LOAIPHONG FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)

-- phieu thue phong --
ALTER TABLE dbo.PHIEUTHUEPHONG ADD CONSTRAINT FK_PHIEUTHUEPHONG_PHONG FOREIGN KEY(MaPhong) REFERENCES dbo.PHONG(MaPhong)

-- Chi tiet phieu thue phong
ALTER TABLE dbo.CTPHIEUTHUEPHONG ADD CONSTRAINT FK_CTPHIEUTHUEPHONG_PHIEUTHUEPHONG FOREIGN KEY(MaPhieuThue) REFERENCES dbo.PHIEUTHUEPHONG(MaPhieuThue)
ALTER TABLE dbo.CTPHIEUTHUEPHONG ADD CONSTRAINT FK_CTPHIEUTHUEPHONG_LOAIKHACH FOREIGN KEY(MaLoaiKhach) REFERENCES dbo.LOAIKHACH(MaLoaiKhach)


-- Chi tiet hoa don --
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON_PHIEUTHUEPHONG FOREIGN KEY(MaPhieuThue) REFERENCES  dbo.PHIEUTHUEPHONG(MaPhieuThue)
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON_HOADON FOREIGN KEY(MaHD) REFERENCES  dbo.HOADON(MaHD)

-- Chi tiet bao cao doanh thu --
ALTER TABLE dbo.CTBCDT ADD CONSTRAINT FK_CTBCDT_BCDT FOREIGN KEY(MaBCDT) REFERENCES dbo.BCDT(MaBCDT)
ALTER TABLE dbo.CTBCDT ADD CONSTRAINT FK_CTBCDT_LOAIPHONG FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)



