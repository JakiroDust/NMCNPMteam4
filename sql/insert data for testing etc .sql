use QuanLyKhachSan;
delete from CT_BAOCAODOANHTHUTHEOLOAIPHONG
delete from BAOCAODOANHTHUTHEOLOAIPHONG
delete from CT_HOADON
delete from HOADON
delete from CT_PHIEUTHUEPHONG
delete from PHIEUTHUEPHONG;
delete from LOAIKHACH;
delete from PHONG;
delete from LOAIPHONG;
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'A',150000;
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'B',170000;
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) SELECT 'C',200000;
Declare @A int, @B int, @C int,@P1 int, @P2 int ,@P3 int, @P4 int, @P5 int, @P6 int
select @A=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='A'
select @B=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='B'
select @C=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='C'

INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 1,@A,0;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 2,@A,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 3,@A,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 4,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 5,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 6,@B,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 7,@C,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 8,@C,1;
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) SELECT 9,@C,1;
select @P1=PHONG.MaPhong from PHONG where PHONG.TenPhong='1'
select @P2=PHONG.MaPhong from PHONG where PHONG.TenPhong='2'
select @P3=PHONG.MaPhong from PHONG where PHONG.TenPhong='3'
select @P4=PHONG.MaPhong from PHONG where PHONG.TenPhong='4'
select @P5=PHONG.MaPhong from PHONG where PHONG.TenPhong='5'
select @P6=PHONG.MaPhong from PHONG where PHONG.TenPhong='6'
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) SELECT 'KHÁCH THƯỜNG',1;
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) SELECT 'NGOẠI QUỐC',1;
Declare @hd1 int,@ptp1 int,@ptp2 int, @ptp3 int,@ptp4 int,@ptp5 int,@ptp6 int
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P1,3,'10/10/2002','6/11/2002',15000;
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P6,3,'10/10/2002','6/11/2002',25000 ;
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P4,3,'10/10/2002','6/11/2002',35000;
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P2,3,'10/10/2002','6/11/2002',45000;	
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P3,3,'12/10/2002','12/11/2002',45000;
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P5,3,'1/10/2002','1/11/2002',45000;
INSERT INTO PHIEUTHUEPHONG (MaPhong,SoLuongKhach,NgayBDThue,NgayKTThue,DonGiaSan) select @P6,3,'2/10/2002','2/11/2002',45000;	
INSERT INTO HOADON (TenKH) SELECT 'NGUYỄN THỊ A'
select @ptp1=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P1
select @ptp2=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P2
select @ptp3=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P3
select @ptp4=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P4
select @ptp5=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P5
select @ptp6=PHIEUTHUEPHONG.MaPhieuThuePhong from PHIEUTHUEPHONG where PHIEUTHUEPHONG.MaPhong=@P6
select @hd1=HOADON.MaHoadon from HOADON where HOADON.TenKH='NGUYỄN THỊ A'
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp1,1
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp2,1
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp4,1
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp4,1
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp5,1
INSERT INTO CT_HOADON (MaHoaDon,MaPhieuThuePhong,ThanhTien) select @hd1,@ptp6,1
declare @aa int
select @aa= MaCTHD from CT_HOADON where MaHoaDon=@hd1 and MaPhieuThuePhong=@ptp6
select * from CT_BAOCAODOANHTHUTHEOLOAIPHONG
select * from BAOCAODOANHTHUTHEOLOAIPHONG
update PHIEUTHUEPHONG 
set NgayKTThue='2/2/2009'
where MaPhong=@P5
select * from CT_BAOCAODOANHTHUTHEOLOAIPHONG,LOAIPHONG where LOAIPHONG.MaLoaiPhong=CT_BAOCAODOANHTHUTHEOLOAIPHONG.MaLoaiPhong
select * from BAOCAODOANHTHUTHEOLOAIPHONG