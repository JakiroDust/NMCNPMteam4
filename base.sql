CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

CREATE TABLE PHONG
(
	MaPhong int identity NOT NULL PRIMARY KEY,
	TenPhong Nvarchar(10) not null,
	MaLoaiPhong INT,
	GhiChu NVARCHAR(200),
	TinhTrang BIT --0: dang su dung|| 1: con trong
)
GO	


Create Table LOAIPHONG
(
	MaLoaiPhong  INT IDENTITY not null primary key,
	TenLoaiPhong nvarchar(10),
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
	LoaiKhach NVARCHAR(20),
	CMND NVARCHAR(20),
	DiaChi NVARCHAR(50)
)
GO

CREATE TABLE LOAIKHACH
(
	LoaiKhach NVARCHAR(20) NOT NULL PRIMARY KEY,
	HeSo FLOAT
)
GO

CREATE TABLE HOADON
(
	MaHoaDon INT IDENTITY NOT NULL PRIMARY KEY,
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
	MaLoaiPhong int,
	TongDoanhThu Money,
	TiLe FLOAT
)
GO	

CREATE TABLE THAMSO(
    TenThamSo NVARCHAR(13),
    GiaTriThamSo float
)
GO

Create table PHUTHUKHACH(
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
ALTER TABLE dbo.CT_PHIEUTHUEPHONG ADD CONSTRAINT FK_CT_PHIEUTHUEPHONG_LOAIKHACH FOREIGN KEY(LoaiKhach) REFERENCES dbo.LOAIKHACH(LoaiKhach) ON DELETE CASCADE

-- Chi tiet hoa don --
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON_PHIEUTHUEPHONG FOREIGN KEY(MaPhieuThuePhong) REFERENCES  dbo.PHIEUTHUEPHONG(MaPhieuThuePhong) ON DELETE CASCADE
ALTER TABLE dbo.CT_HOADON ADD CONSTRAINT FK_CT_HOADON FOREIGN KEY(MaHoaDon) REFERENCES  dbo.HOADON(MaHoaDon) ON DELETE CASCADE

-- Bao cao doanh thu theo loai phong --
ALTER TABLE dbo.CT_BAOCAODOANHTHUTHEOLOAIPHONG ADD CONSTRAINT FK_CT_BAOCAODOANHTHUTHEOLOAIPHONG_LOAIPHONG FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)
ALTER TABLE dbo.CT_BAOCAODOANHTHUTHEOLOAIPHONG ADD CONSTRAINT FK_CT_BAOCAODOANHTHUTHEOLOAIPHONG_BAOCAODOANHTHUTHEOLOAIPHONG FOREIGN KEY(MaBaoCaoDoanhThuTheoLoaiPhong) REFERENCES dbo.BAOCAODOANHTHUTHEOLOAIPHONG(MaBaoCaoDoanhThuTheoLoaiPhong)

--TRIGGER--
CREATE TRIGGER INSERT_PHIEUTHUEPHONG
ON dbo.PHIEUTHUEPHONG
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @SoLuongKhach INT, @SoKhachToiDa int
	SELECT @SoLuongKhach = SoLuongKhach FROM inserted
	SELECT @SoKhachToiDa = GiaTriThamSo from THAMSO where TenThamSo = 'SoKhachToiDa'
	
	if (@SoLuongKhach > @SoKhachToiDa)
	BEGIN
		ROLLBACK TRAN
		PRINT 'ERROR!, VUOT QUA SO KHACH TOI DA'
	END
END
GO

ALTER TRIGGER INSERT_CT_PHIEUTHUEPHONG
ON dbo.CT_PHIEUTHUEPHONG	
FOR INSERT, UPDATE
AS 
BEGIN 
	DECLARE @MaPhieuThuePhong NVARCHAR(10), @SoLuongKhach int
	SELECT @MaPhieuThuePhong = MaPhieuThuePhong FROM Inserted
	SELECT @SoLuongKhach = SoLuongKhach FROM PHIEUTHUEPHONG where @MaPhieuThuePhong = MaPhieuThuePhong

	IF ((SELECT COUNT(*) FROM dbo.CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong = @MaPhieuThuePhong) >= (@SoLuongKhach + 1))
	BEGIN	
		ROLLBACK TRAN
		PRINT 'ERROR!, VUOT QUA SO KHACH KHAI BAO TRONG PHIEU'
	END
END
GO

--STORED PROCEDURE--

--cap nhat tinh trang phong khi thoi han phieu thue phong ket thuc--
CREATE PROC USP_UPDATE_LISTPHONG
AS
	DECLARE @RowsToProcess int,
			@CurrentRow int,
			@MaPhong int
	DECLARE @tempTable TABLE (RowID int not null PRIMARY KEY IDENTITY(1,1), column1 int)

	INSERT INTO @tempTable (column1) SELECT MaPhong FROM PHIEUTHUEPHONG WHERE NgayKTThue >= GETDATE()

	UPDATE PHONG SET TinhTrang = 1

	SET @RowsToProcess = @@ROWCOUNT
	SET @CurrentRow = 0
	WHILE @CurrentRow <= @RowsToProcess
	BEGIN
		SELECT @MaPhong = column1 FROM @tempTable WHERE RowID = @CurrentRow
		Print @MaPhong
		UPDATE PHONG SET TinhTrang = 0 WHERE MaPhong = @MaPhong
		SET @CurrentRow = @CurrentRow+1
	END	
GO

--Tinh gia tri cua cthd dong thoi cap nhat tong tien cua hoa don--
CREATE PROC USP_INSERT_CT_HOADON
	@MaHoaDon int,
	@MaPhieuThuePhong int
AS
	IF ((SELECT COUNT(*) FROM PHIEUTHUEPHONG WHERE MaPhieuThuePhong = @MaPhieuThuePhong) > 0)
	BEGIN
		DECLARE @SoNgayThue int,
		@DonGiaSan money,
		@ThanhTien money,
		@SoKhachNuocNgoai int,
		@SoLuongKhach int,
		@PhuThu float

		SELECT @SoNgayThue = DATEDIFF(day, NgayBDThue, NgayKTThue), @DonGiaSan = DonGiaSan
		FROM PHIEUTHUEPHONG
		WHERE MaPhieuThuePhong = @MaPhieuThuePhong

		SELECT @SoLuongKhach = COUNT(*)
		FROM CT_PHIEUTHUEPHONG
		WHERE MaPhieuThuePhong = @MaPhieuThuePhong

		SELECT @SoKhachNuocNgoai = COUNT(*)
		FROM CT_PHIEUTHUEPHONG
		WHERE MaPhieuThuePhong = @MaPhieuThuePhong
		AND LoaiKhach = 'Nuoc ngoai'

		SET @ThanhTien = @SoNgayThue * @DonGiaSan

		IF ((SELECT COUNT(*) FROM PHUTHUKHACH WHERE SoLuongKhach = @SoLuongKhach) > 0)
		BEGIN
			SELECT @PhuThu = PhuThu
			FROM PHUTHUKHACH
			WHERE SoLuongKhach = @SoLuongKhach
			SET @ThanhTien = @ThanhTien * @PhuThu
		END	

		IF (@SoKhachNuocNgoai > 0)
		BEGIN 		
			SET @ThanhTien = @ThanhTien * 1.5
		END

		INSERT INTO dbo.CT_HOADON (MaPhieuThuePhong, MaHoaDon, SoNgayThue, ThanhTien) VALUES (@MaPhieuThuePhong, @MaHoaDon, @SoNgayThue, @ThanhTien)
		UPDATE HOADON SET TriGia = TriGia + @ThanhTien WHERE MaHoaDon = @MaHoaDon
	END
GO

--cap nhat tong tien cua hoa don--
CREATE PROC USP_DELETE_CT_HOADON
	@MaHoaDon int,
	@MaPhieuThuePhong int
AS
	DECLARE @ThanhTien money
	IF ((SELECT COUNT(*) FROM CT_HOADON WHERE MaPhieuThuePhong = @MaPhieuThuePhong) > 0)
	BEGIN
		SELECT @ThanhTien = ThanhTien FROM CT_HOADON WHERE MaPhieuThuePhong = @MaPhieuThuePhong
		DELETE FROM CT_HOADON WHERE MaPhieuThuePhong = @MaPhieuThuePhong
		UPDATE HOADON SET TriGia = TriGia - @ThanhTien WHERE MaHoaDon = @MaHoaDon
	END
GO