go
USE QuanLyKhachSan
Declare @A int, @B int, @C int,@P1 int, @P2 int ,@P3 int, @P4 int, @P5 int, @P6 int
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) values('A',150000);
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) values('B',170000);
INSERT INTO LOAIPHONG (TenLoaiPhong,DonGia) values('C',200000);
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) values (N'KHÁCH THƯỜNG',1);
INSERT INTO LOAIKHACH (LoaiKhach,HeSo) values (N'NGOẠI QUỐC',1.5);
INSERT INTO THAMSO (TenThamSo,GiaTriThamSo) values ('SoKhachToiDa',3);
insert into PHUTHU(SoLuongKhach,PhuThu) values (3,1.25);
select @A=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='A'
select @B=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='B'
select @C=LOAIPHONG.MaLoaiPhong from LOAIPHONG where LOAIPHONG.TenLoaiPhong='C'
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (1,@A,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (2,@A,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (3,@A,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (4,@B,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (5,@B,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (6,@B,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (7,@C,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (8,@C,1);
INSERT INTO PHONG (TenPhong,MaLoaiPhong,TinhTrang) values (9,@C,1);