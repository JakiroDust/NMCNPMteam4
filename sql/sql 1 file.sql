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

--TRIGGER--
/*Thang*/
Go
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

CREATE or alter TRIGGER INSERT_CT_PHIEUTHUEPHONG
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

--lay thong tin ct_phieuthuephong--
CREATE PROC USP_GET_CT_PHIEUTHUEPHONG_BY_MAPHIEUTHUEPHONG
@MaPhieuThuePhong int
AS
BEGIN
	SELECT MaCTPTP AS [ID], TenKH AS [Tên khách hàng], MaLoaiKhach AS [Loại khách], CMND AS [CMND], DiaChi AS [Địa chỉ]
	FROM CT_PHIEUTHUEPHONG
	WHERE MaPhieuThuePhong = @MaPhieuThuePhong
END
GO

--cap nhat tinh trang phong khi thoi han phieu thue phong ket thuc--
CREATE PROC USP_UPDATE_LISTPHONG
AS
	DECLARE @RowsToProcess int,
			@CurrentRow int,
			@MaPhong int
	DECLARE @tempTable TABLE (RowID int not null PRIMARY KEY IDENTITY(1,1), column1 int)

	INSERT INTO @tempTable (column1) SELECT MaPhong FROM PHIEUTHUEPHONG WHERE NgayKTThue > GETDATE()

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

--Tinh gia tri cua cthd dong thoi cap nhat tong tien cua hoa don khi them cthd--
CREATE or alter PROC USP_INSERT_CT_HOADON
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

		SET @ThanhTien = @SoNgayThue * @DonGiaSan
		IF (@SoLuongKhach > 0)	
		BEGIN
			select @PhuThu=exp(sum(log(A.HeSo)))
			from
				(select HeSo 
				from LOAIKHACH 
				where MaLoaiKhach in 
					(select MaLoaiKhach 
					from CT_PHIEUTHUEPHONG)) A
			set @ThanhTien=@PhuThu*@ThanhTien
		END	
		IF ((SELECT COUNT(*) FROM PHUTHU WHERE SoLuongKhach <= @SoLuongKhach) > 0)
		BEGIN
			SELECT Top 1 @PhuThu = PhuThu
			FROM PHUTHU
			WHERE SoLuongKhach <= @SoLuongKhach
			ORDER BY SoLuongKhach DESC
			SET @ThanhTien = @ThanhTien * @PhuThu
		END	

		INSERT INTO dbo.CT_HOADON (MaPhieuThuePhong, MaHoaDon, SoNgayThue, ThanhTien) VALUES (@MaPhieuThuePhong, @MaHoaDon, @SoNgayThue, @ThanhTien)
		UPDATE HOADON SET TriGia = TriGia + @ThanhTien WHERE MaHoaDon = @MaHoaDon
	END
GO

--cap nhat tong tien cua hoa don khi xoa cthd--
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

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~```*/
GO
CREATE or alter TRIGGER INSERT_CT_HOADON_CT_BAOCAODOANHTHU
on CT_HOADON
for insert
as declare @MaPhieuThuePhong int,@MaCTHD int, @ThanhTien Money,@month int,@year int, @MaLoaiPhong int, @MaBaoCao int
select @MaPhieuThuePhong=MaPhieuThuePhong,@ThanhTien=ThanhTien, @MaCTHD=MaCTHD, @ThanhTien=ThanhTien
from inserted
select @MaLoaiPhong=PHONG.MaLoaiPhong,@month=month(PHIEUTHUEPHONG.NgayKTThue),@year=year(PHIEUTHUEPHONG.NgayKTThue)
from inserted,PHIEUTHUEPHONG,PHONG where inserted.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong and PHIEUTHUEPHONG.MaPhong=PHONG.MaPhong  
if not exists (
select 1 
from CT_BAOCAODOANHTHUTHEOLOAIPHONG,BAOCAODOANHTHUTHEOLOAIPHONG 
where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong and CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong=@MaLoaiPhong and BAOCAODOANHTHUTHEOLOAIPHONG.Nam=@year and BAOCAODOANHTHUTHEOLOAIPHONG.Thang=@month)

	begin
	if not exists (select 1 from BAOCAODOANHTHUTHEOLOAIPHONG where Thang=@month and Nam=@year)
		insert into BAOCAODOANHTHUTHEOLOAIPHONG(Thang,Nam,TongTatCaDoanhThu) select @month,@year,0;
	select @MaBaoCao=A.MaBaoCaoDoanhThuTheoLoaiPhong from (select top 1 *  from BAOCAODOANHTHUTHEOLOAIPHONG where BAOCAODOANHTHUTHEOLOAIPHONG.Nam=@year and BAOCAODOANHTHUTHEOLOAIPHONG.Thang=@month) A
	insert into CT_BAOCAODOANHTHUTHEOLOAIPHONG(MaBaoCaoDoanhThuTheoLoaiPhong,MaLoaiPhong,TongDoanhThu) select @MaBaoCao,@MaLoaiPhong,@ThanhTien
	end;

else
	begin
	select @MaBaoCao=A.MaBaoCaoDoanhThuTheoLoaiPhong from (select top 1 *  from BAOCAODOANHTHUTHEOLOAIPHONG where BAOCAODOANHTHUTHEOLOAIPHONG.Nam=@year and BAOCAODOANHTHUTHEOLOAIPHONG.Thang=@month) A
	update CT_BAOCAODOANHTHUTHEOLOAIPHONG
	set TongDoanhThu=TongDoanhThu+@ThanhTien
	where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong=@MaLoaiPhong and CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
	end;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

go
CREATE or alter TRIGGER UPDATE_Ct_HOADON_CT_BAOCAODOANHTHU
on CT_HOADON
AFTER UPDATE
as 
declare  @MaPhieuThuePhong_new int,@MaCTHD int, @ThanhTien_new Money,@month_new int,@year_new int, @MaLoaiPhong_new int, @MaBaoCao int
declare	 @MaPhieuThuePhong_old int, @ThanhTien_old Money,@month_old int,@year_old int, @MaLoaiPhong_old int,@MaBaoCao_old int
select @MaPhieuThuePhong_new=MaPhieuThuePhong,@ThanhTien_new=ThanhTien,@MaCTHD=MaCTHD
from inserted
select @MaPhieuThuePhong_old=MaPhieuThuePhong,@ThanhTien_old=ThanhTien
from deleted
if @MaPhieuThuePhong_new=@MaPhieuThuePhong_old
	begin
	select @MaLoaiPhong_new=MaLoaiPhong,@year_new=year(NgayKTThue),@month_new=month(NgayKTThue) from CT_HOADON,PHIEUTHUEPHONG,PHONG where CT_HOADON.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong and PHIEUTHUEPHONG.MaPhong=PHONG.MaPhong
	select @MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_new and nam=@year_new
	update CT_BAOCAODOANHTHUTHEOLOAIPHONG
	set TongDoanhThu=TongDoanhThu+@ThanhTien_new-@ThanhTien_old
	where MaLoaiPhong=@MaLoaiPhong_new and MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao

	end
else
	begin
	select @MaLoaiPhong_new=MaLoaiPhong,@year_new=year(NgayKTThue),@month_new=month(NgayKTThue) from inserted,PHIEUTHUEPHONG,PHONG where inserted.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong and PHIEUTHUEPHONG.MaPhong=PHONG.MaPhong
	select @MaLoaiPhong_old=MaLoaiPhong,@year_old=year(NgayKTThue),@month_old=month(NgayKTThue) from deleted,PHIEUTHUEPHONG,PHONG where deleted.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong and PHIEUTHUEPHONG.MaPhong=PHONG.MaPhong
	select @MaBaoCao_old=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_old and nam=@year_old
	
	if not exists (select * from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_new and nam=@year_new)
		insert into BAOCAODOANHTHUTHEOLOAIPHONG(Thang,Nam,TongTatCaDoanhThu) select @month_new,@year_new,0;

	select @MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_new and nam=@year_new

	if not exists (select * from CT_BAOCAODOANHTHUTHEOLOAIPHONG where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao and MaLoaiPhong=@MaLoaiPhong_new)
		insert into CT_BAOCAODOANHTHUTHEOLOAIPHONG(MaBaoCaoDoanhThuTheoLoaiPhong,MaLoaiPhong,TongDoanhThu) select @MaBaoCao,@MaLoaiPhong_new,@ThanhTien_new
	else
		update CT_BAOCAODOANHTHUTHEOLOAIPHONG
			set TongDoanhThu=TongDoanhThu+@ThanhTien_new
			where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong=@MaLoaiPhong_new and MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
	
	update CT_BAOCAODOANHTHUTHEOLOAIPHONG
		set TongDoanhThu=TongDoanhThu-@ThanhTien_old
		where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong=@MaLoaiPhong_old and MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao_old
		
	
	end

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
create or alter trigger UPDATE_CT_BAOCAODOANHTHULEOLOAIPHONG_BAOCAODOANHTHUTHEOLOAIPHONG
on CT_BAOCAODOANHTHUTHEOLOAIPHONG
after update
as
declare @thanhtien_cu money,@thanhtien_moi money, @MaBaoCao int, @MaCT_BaoCao int,@TongDoanhThu money
select @thanhtien_moi=TongDoanhThu,@MaCT_BaoCao=MaCT_BaoCaoDoanhThuTheoLoaiPhong,@MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong
from inserted
select @thanhtien_cu=TongDoanhThu
from deleted
	if @thanhtien_moi=0
		delete from CT_BAOCAODOANHTHUTHEOLOAIPHONG where TongDoanhThu=0 and CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaCT_BaoCaoDoanhThuTheoLoaiPhong=@MaCT_BaoCao

update BAOCAODOANHTHUTHEOLOAIPHONG
	set TongTatCaDoanhThu=TongTatCaDoanhThu-@thanhtien_cu+@thanhtien_moi
	where BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
	select @TongDoanhThu=TongTatCaDoanhThu from BAOCAODOANHTHUTHEOLOAIPHONG where BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao

update CT_BAOCAODOANHTHUTHEOLOAIPHONG
	set TiLe= case 
	when @TongDoanhThu=0 then 0
	else TongDoanhThu/@TongDoanhThu
	end
	where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
create or alter trigger INSERT_CT_BAOCAODOANHTHULEOLOAIPHONG_BAOCAODOANHTHUTHEOLOAIPHONG
on CT_BAOCAODOANHTHUTHEOLOAIPHONG
for insert
as
declare @MaBaoCao int, @ThanhTien money,@TongDoanhThu money
select @MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong,@ThanhTien=TongDoanhThu
from inserted
update BAOCAODOANHTHUTHEOLOAIPHONG
set TongTatCaDoanhThu=TongTatCaDoanhThu+@ThanhTien,@TongDoanhThu=TongTatCaDoanhThu
where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
update CT_BAOCAODOANHTHUTHEOLOAIPHONG
	set TiLe= case 
	when @TongDoanhThu=0 then 0
	else TongDoanhThu/@TongDoanhThu
	end
	where CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
create or alter trigger UPDATE_PHIEUTHUEPHONG_CT_BAOCAODOANHTHUTHEOLOAIPHONG
on PHIEUTHUEPHONG
AFTER UPDATE
AS
declare @ThanhTien money
declare @MaLoaiPhong_new int,@year_new int,@month_new int,@MaBaoCao_new int
declare @MaLoaiPhong_old int,@year_old int,@month_old int,@MaBaoCao_old int
select @MaLoaiPhong_new=phong.MaLoaiPhong,@year_new=year(NgayKTThue), @month_new=month(NgayKTThue) from inserted,PHONG where PHONG.MaPhong=inserted.MaPhong 
select @MaLoaiPhong_old=phong.MaLoaiPhong,@year_old=year(NgayKTThue), @month_old=month(NgayKTThue) from deleted,PHONG where PHONG.MaPhong=deleted.MaPhong 
select @ThanhTien=ThanhTien from CT_HOADON,PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhieuThuePhong=CT_HOADON.MaPhieuThuePhong
if not exists (select * from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_new and nam=@year_new)
	insert into BAOCAODOANHTHUTHEOLOAIPHONG(Thang,Nam,TongTatCaDoanhThu) select @month_new,@year_new,0;

select @MaBaoCao_new=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where thang=@month_new and nam=@year_new

if not exists (select * from CT_BAOCAODOANHTHUTHEOLOAIPHONG where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao_new and MaLoaiPhong=@MaLoaiPhong_new)
	begin
	insert into CT_BAOCAODOANHTHUTHEOLOAIPHONG(MaBaoCaoDoanhThuTheoLoaiPhong,MaLoaiPhong,TongDoanhThu) select @MaBaoCao_new,@MaLoaiPhong_new,@ThanhTien
	end
else
	begin
	update CT_BAOCAODOANHTHUTHEOLOAIPHONG
	set TongDoanhThu=TongDoanhThu+@ThanhTien
	where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao_new and MaLoaiPhong=@MaLoaiPhong_new
	end
select @MaBaoCao_old=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG where @year_old=Nam and @month_old=Thang
update CT_BAOCAODOANHTHUTHEOLOAIPHONG
set TongDoanhThu=TongDoanhThu-@ThanhTien
where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao_old and MaLoaiPhong=@MaLoaiPhong_old

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
create or alter trigger DELETE_CT_BAOCAODOANHTHUTHEOTHANG_BAOCAODOANHTHU
on CT_BAOCAODOANHTHUTHEOLOAIPHONG
for delete
AS
DECLARE @ThanhTien money,@TongDoanhThu money,@MaBaoCao int
select @ThanhTien=TongDoanhThu,@MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong from deleted
update BAOCAODOANHTHUTHEOLOAIPHONG
set @TongDoanhThu=TongTatCaDoanhThu-@ThanhTien,TongTatCaDoanhThu=TongTatCaDoanhThu-@ThanhTien
where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
update CT_BAOCAODOANHTHUTHEOLOAIPHONG
set TiLe= case
when @TongDoanhThu=0 then 0
else TongDoanhThu/@TongDoanhThu
end
where MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go 
create or alter trigger UPDATE_BAOCAODOANHTHUTHEOLOAI
on BAOCAODOANHTHUTHEOLOAIPHONG
after update
as
declare @ThanhTien money, @MaBaoCao int
select @ThanhTien=TongTatCaDoanhThu, @MaBaoCao=MaBaoCaoDoanhThuTheoLoaiPhong from BAOCAODOANHTHUTHEOLOAIPHONG
if @ThanhTien<=0
delete from BAOCAODOANHTHUTHEOLOAIPHONG where BAOCAODOANHTHUTHEOLOAIPHONG.MaBaoCaoDoanhThuTheoLoaiPhong=@MaBaoCao
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
CREATE or alter proc FUNC_DELETE_CT_BAOCAODOANHTHUTHEOLOAIPHONG(@MaLoaiPhong int)
as
begin
while exists 
(
	select top 1 * 
	from CT_BAOCAODOANHTHUTHEOLOAIPHONG 
	where MaLoaiPhong =@MaLoaiPhong
) 
begin 
	WITH  q AS
	(
	SELECT TOP 1 *
	FROm CT_BAOCAODOANHTHUTHEOLOAIPHONG
	where MaLoaiPhong=@MaLoaiPhong
	)
	DELETE
	FROM    q
end
end
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
go
CREATE or alter proc FUNC_DELETE_CT_BAOCAODOANHTHUTHEOLOAIPHONG_PHONG(@TenPhong nvarchar(20))
as
begin
declare @MaPhong int
select @MaPhong=MaPhong from PHONG where TenPhong=@TenPhong
while exists 
(
	select top 1 * 
	from PHIEUTHUEPHONG 
	where MaPhong=@MaPhong
) 
begin
	declare @MaPhieuThuePhong int
	select @MaPhieuThuePhong=MaPhieuThuePhong
	from
	(
	select
	top 1 * 
	from PHIEUTHUEPHONG 
	where MaPhong=@MaPhong
	) a
	UPDATE
	CT_HOADON
	SET
	ThanhTien=0
	WHERE
	MaPhieuThuePhong=@MaPhieuThuePhong
	delete from PHIEUTHUEPHONG where MaPhieuThuePhong=@MaPhieuThuePhong
end
end
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
/**********/
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'A',150000;
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'B',170000;
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'C',200000;
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) SELECT 'KHÁCH THƯỜNG',1;
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) SELECT 'NGOẠI QUỐC',1.5;
INSERT INTO THAMSO (TenThamSo,GiaTriThamSo) SELECT 'SoKhachToiDa',3;
insert into PHUTHU(SoLuongKhach,PhuThu) select 3,1.25;
select @A=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='A'
select @B=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='B'
select @C=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='C'
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 1,@A,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 2,@A,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 3,@A,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 4,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 5,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 6,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 7,@C,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 8,@C,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 9,@C,1;