--TRIGGER--
/*Thang*/
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

CREATE TRIGGER INSERT_CT_PHIEUTHUEPHONG
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
	SELECT MaCTPTP AS [ID], TenKH AS [Tên khách hàng], LoaiKhach AS [Loại khách], CMND AS [CMND], DiaChi AS [Địa chỉ]
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

--Tinh gia tri cua cthd dong thoi cap nhat tong tien cua hoa don khi them cthd--
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
