﻿USE MASTER 
GO

if DB_ID('QUANLYKHACHSAN')is not null
	drop database QUANLYKHACHSAN
go
CREATE DATABASE QUANLYKHACHSAN
GO
USE QUANLYKHACHSAN
GO
--DROP TABLE TTDANGKYDICHVU, TTSUDUNGSANPHAM, LICHSUGIAODICH, DICHVU, THONGTINVANCHUYENHANHLY, CTSUDUNGMINIBAR,CTHOSOKIEMTRAPHONG , THONGTINDATPHONG, SANPHAM, LOTRINHTOUR, TTDANGKYTOUR, TOUR, HOADON, CTPHIEUDATPHONG, PHIEUDATPHONG, PHONG, LOAIPHONG, PHIEUYEUCAU, THONGTINDOAN, KHACHHANG;

create table KHACHHANG(
	MaKH char(6),
	CMND varchar(10),
	Sdt varchar(11),
	SoFax varchar(11),
	HoTen nvarchar(30),
	DiaChi nvarchar(60),
	constraint PK_khachhang primary key(MaKH)
)
go
create table THONGTINDOAN(
	TruongDoan char(6),
	TenDoan varchar(30),
	SoNguoi int,
	constraint FK_THONGTINDOAN_KHACHHANG FOREIGN KEY (TruongDoan) REFERENCES KHACHHANG(MaKH),
	constraint PK_THONGTINDOAN PRIMARY KEY (TruongDoan, TenDoan)
)
go
create table PHIEUYEUCAU(
	MaKH char(6),
	Stt int IDENTITY(1,1),
	NoiDung nvarchar(50),
	constraint FK_PHIEUYEUCAU_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	constraint PK_PHIEUYEUCAU primary key(MaKH, Stt)
)
go
create table LOAIPHONG(
	MaLoaiPhong char(6),
	TenLoaiPhong nvarchar(20),
	DonGia int,
	constraint PK_LOAIPHONG primary key(MaLoaiPhong)
)
go

create table PHONG(
	SoPhong int,
	MaLoaiPhong char(6),
	Tinhtrang nvarchar(15),
	constraint PK_PHONG primary key(SoPhong),
	constraint FK_PHONG_LOAIPHONG foreign key (MaLoaiPhong) references LOAIPHONG
)
go
create table PHIEUDATPHONG(
	MaPhieuDat char(6),
	MaKH char(6),
	NgayDen datetime,
	NgayDi datetime,
	TongTienPhong int constraint DF_PHIEUDATPHONG_TongTienPhong DEFAULT 0,
	constraint PK_PHIEUDATPHONG primary key(MaPhieuDat),
	constraint FK_PHIEUDATPHONG_KHACHHANG foreign key(MaKH)  references KHACHHANG(MaKH)
)
go
create table CTPHIEUDATPHONG(
	MaPhieuDat char(6),
	MaLoaiPhong char(6),
	SoLuong int,
	constraint FK_CTPHIEUDATPHONG_PHIEUDATPHONG foreign key(MaPhieuDat) references PHIEUDATPHONG(MaPhieuDat),
	constraint FK_CTPHIEUDATPHONG_LOAIPHONG foreign key(MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
	constraint PK_CTPHIEUDATPHONG primary key (MaPhieuDat, MaLoaiPhong)
)
go

create table TOUR(
	MaTour char(6),
	TenTour nvarchar(30),
	DonGia int,
	MoTa nvarchar(200)
	constraint PK_Tour primary key(MaTour)
)
go
create table LOTRINHTOUR (
	MaTour char(6),
	STT INT,
	TenLoTrinh nvarchar(30),
	ThoiGian datetime,
	constraint FK_LOTRINHTOUR_TOUR foreign key(MaTour) references TOUR(MaTour),
	constraint PK_LOTRINHTOUR primary key (MaTour, STT)
)
go
create table SANPHAM (
	MaSanPham char(6),
	TenSanPham nvarchar(30),
	DonGia int,
	constraint PK_SANPHAM primary key (MaSanPham)
	)
go
--create table CTSUDUNGMINIBAR(
	
create table THONGTINDATPHONG(
	MaPhieuDat char(6),
	SoPhong int,
	TongChiPhiThietHai int,
	constraint FK_THONGTINDATPHONG_PHONG foreign key (SoPhong) references PHONG(SoPhong),
	constraint FK_THONGTINDATPHONG_PHIEUDATPHONG foreign key (MaPhieuDat) references PHIEUDATPHONG(MaPhieuDat),
	constraint PK_THONGTINDATPHONG primary key(MaPhieuDat, SoPhong)
)
go
create table CTHOSOKIEMTRAPHONG(
	MaPhieuDat char(6),
	Stt int IDENTITY(1,1), 
	SoPhong int,
	NoiDung nvarchar(30),
	ChiPhiThietHai int,
	constraint FK_CTHOSOKIEMTRAPHONG_THONGTINDATPHONG foreign key (MaPhieuDat, SoPhong) references THONGTINDATPHONG(MaPhieuDat, SoPhong),
	constraint PK_CTHOSOKIEMTRAPHONG primary key (MaPhieuDat, SoPhong, Stt)
)
go
create table CTSUDUNGMINIBAR(
	MaPhieuDat char(6),
	SoPhong int,
	MaSanPham char(6),
	SoLuong int,
	constraint FK_CTSUDUNGMINIBAR_THONGTINDATPHONG foreign key (MaPhieuDat, SoPhong) references THONGTINDATPHONG(MaPhieuDat, SoPhong),
	constraint FK_CTSUDUNGMINIBAR_SANPHAM foreign key (MaSanPham) references SANPHAM (MaSanPham),
	constraint PK_CTSUDUNGMINIBAR primary key (MaPhieuDat, SoPhong, MaSanPham)
)
go
create table THONGTINVANCHUYENHANHLY(
	MaPhieuDat char(6),
	SoPhong int,
	SoLuongHanhLy int,
	MOTA NVARCHAR(50),
	constraint FK_THONGTINVANCHUYENHANHLY_THONGTINDATPHONG foreign key (MaPhieuDat, SoPhong) references THONGTINDATPHONG(MaPhieuDat, SoPhong),
	constraint PK_THONGTINVANCHUYENHANHLY primary key (MaPhieuDat, SoPhong)
)
go
create table DICHVU(
	MaDV char(6),
	TenDV nvarchar(30),
	DonGia int,
	Rate float,
	constraint PK_DICHVU primary key(MaDV)
)
go

create table HOADON(
	MaHD char(6),
	MaPhieuDat char(6),
	TongTriGia int,
	constraint FK_HOADON_PHIEUDATPHONG foreign key (MaPhieuDat) references PHIEUDATPHONG (MaPhieuDat),
	constraint PK_HOADON primary key (MaHD)
)
go

create table LICHSUGIAODICH(
	MaHD char(6),
	Stt int IDENTITY(1,1),
	NoiDung nvarchar(30),
	HinhThucThanhToan nvarchar(30),
	DonGia int,
	constraint FK_LICHSUGIAODICH_HOADON foreign key (MaHD) references HOADON(MaHD),
	constraint PK_LICHSUGIAODICH primary key (MaHD, Stt)
)
go
create table TTSUDUNGSANPHAM(
	MaHD char(6),
	Stt int IDENTITY(1,1),
	SoLuong int,
	MaSanPham char(6),
	constraint FK_TTSUDUNGSANPHAM_HOADON foreign key (MaHD) references HOADON (MaHD),
	constraint FK_TTSUDUNGSANPHAM_SANPHAM foreign key (MaSanPham) references SANPHAM(MaSanPham),
	constraint PK_TTSUDUNGSANPHAM primary key (MaHD, MaSanPham, Stt)
)
go
create table TTDANGKYDICHVU(
	MaHD char(6),
	Stt int IDENTITY(1,1),
	MaDichVu char(6),
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime,
	YeuCau nvarchar(30),
	SoLuong int constraint DF_TTDANGKYDICHVU_SoLuong DEFAULT 0,
	TongTien int,
	constraint FK_TTDANGKYDICHVU_HOADON foreign key (MaHD) references HOADON(MaHD),
	constraint FK_TTDANGKYDICHVU_TOUR foreign key (MaDichVu) references DICHVU,
	constraint PK_TTDANGKYDICHVU primary key(MaHD, Stt, MaDichVu)
)

create table TTDANGKYTOUR(
	MaHD char(6),
	Stt int IDENTITY(1,1),
	MaTour char(6),
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime,
	YeuCau nvarchar(30),
	SoLuong int constraint DF_TTDANGKYTOUR_SoLuong DEFAULT 0,
	TongTien int,
	HinhThucDiChuyen nvarchar(20),
	constraint FK_TTDANGKYTOUR_HOADON foreign key (MaHD) references HOADON(MaHD),
	constraint FK_TTDANGKYTOUR_TOUR foreign key (MaTour) references TOUR(MaTour),
	constraint PK_TTDANGKYTOUR primary key(MaHD, Stt, MaTour)
)
go
--Loại phòng
INSERT INTO LOAIPHONG VALUES('LOAI01', N'Đơn', 1500000)
INSERT INTO LOAIPHONG VALUES('LOAI02', N'Đôi', 2000000)
INSERT INTO LOAIPHONG VALUES('LOAI03', N'VIP', 4000000)

--Phòng
INSERT INTO PHONG VALUES(101, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(102, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(104, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(105, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(201, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(202, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(204, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(205, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(301, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(302, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(304, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(305, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(401, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(402, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(404, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(405, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(501, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(502, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(504, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(505, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(601, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(602, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(604, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(605, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(701, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(702, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(704, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(705, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(801, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(802, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(804, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(805, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(901, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(902, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(904, 'LOAI01', N'Trống')
INSERT INTO PHONG VALUES(905, 'LOAI01', N'Trống')

INSERT INTO PHONG VALUES(103, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(106, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(107, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(203, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(206, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(207, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(303, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(306, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(307, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(403, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(406, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(407, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(503, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(506, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(507, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(603, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(606, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(607, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(703, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(706, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(707, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(803, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(806, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(807, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(903, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(906, 'LOAI02', N'Trống')
INSERT INTO PHONG VALUES(907, 'LOAI02', N'Trống')

INSERT INTO PHONG VALUES(108, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(208, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(308, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(408, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(508, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(608, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(708, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(808, 'LOAI03', N'Trống')
INSERT INTO PHONG VALUES(908, 'LOAI03', N'Trống')

--Sản phẩm
INSERT INTO SANPHAM VALUES('SP0001', N'Mì ly',20000)
INSERT INTO SANPHAM VALUES('SP0002', N'Snack khoai tây',25000)
INSERT INTO SANPHAM VALUES('SP0003', N'Nước suối Lavile',12000)
INSERT INTO SANPHAM VALUES('SP0004', N'Socola',25000)
INSERT INTO SANPHAM VALUES('SP0005', N'Bánh Cutas',35000)
INSERT INTO SANPHAM VALUES('SP0006', N'Bánh chocopile',8000)
INSERT INTO SANPHAM VALUES('SP0007', N'Rượu vang Charlotte',300000)
INSERT INTO SANPHAM VALUES('SP0008', N'Sprite',18000)
INSERT INTO SANPHAM VALUES('SP0009', N'Coca',18000)
INSERT INTO SANPHAM VALUES('SP0010', N'Pepsi',19000)
INSERT INTO SANPHAM VALUES('SP0011', N'Bánh Flan',15000)
INSERT INTO SANPHAM VALUES('SP0012', N'Sữa chua Vinamilk',13000)

--Dịch vụ
INSERT INTO DICHVU VALUES('DV0001',N'Bơi',100000,4.9)
INSERT INTO DICHVU VALUES('DV0002',N'Mát xa',300000,10.0)
INSERT INTO DICHVU VALUES('DV0003',N'Gym',120000,9.8)
INSERT INTO DICHVU VALUES('DV0004',N'Đánh Golf',600000,10.0)
INSERT INTO DICHVU VALUES('DV0005',N'Đánh Tennis',150000,7.8)

--Tour
INSERT INTO TOUR VALUES('TOUR01', N'Đi khắp Đà Lạt cùng Bo', 1000000, N'Trải nghiệm ăn uống Đà Lạt cùng Mr.Bo')
INSERT INTO TOUR VALUES('TOUR02', N'6 tỉnh miền Tây sông nước', 1200000, N'SÀI GÒN – MỸ THO - BẾN TRE -  CẦN THƠ - ĂN TỐI DU THUYỀN 5 SAO–CÀ MAU- ĐIỆN GIÓ BẠC LIÊU')
INSERT INTO TOUR VALUES('TOUR03', N'Chinh phục núi Ngọc Linh', 800000, N'Chinh phục đến nơi cao nhất Tây Nguyên Việt Nam')

--Lộ trình Tour
INSERT INTO LOTRINHTOUR VALUES('TOUR01', 1, N'Xuất phát','2023-06-20 06:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR01', 2, N'Tham quan thác Datanla','2023-06-20 08:30:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR01', 3, N'Vườn thú ZooDoo','2023-06-20 15:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR01', 4, N'Kết thúc','2023-06-20 17:30:00')

INSERT INTO LOTRINHTOUR VALUES('TOUR02', 1, N'Xuất phát','2023-06-20 03:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR02', 2, N'Chợ nổi Cái Răng','2023-06-20 05:15:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR02', 3, N'Vườn quốc gia U Minh','2023-06-20 08:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR02', 4, N'Kết thúc','2023-06-20 12:30:00')

INSERT INTO LOTRINHTOUR VALUES('TOUR03', 1, N'Xuất phát','2023-06-20 06:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR03', 2, N'Thử thách leo núi','2023-06-20 09:30:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR03', 3, N'Camping','2023-06-20 15:00:00')
INSERT INTO LOTRINHTOUR VALUES('TOUR03', 4, N'Kết thúc','2023-06-21 06:00:00')

--Khách hàng
INSERT INTO KHACHHANG VALUES('KH0001', '1234567890', '1234567899', '98765432111', N'Nguyễn Phương Hằng', N'Tự Lạn, Việt Yên, Bắc Giang')
INSERT INTO KHACHHANG VALUES('KH0002', '1254567890', '1214567899', '94765432111', N'Võ Hà Linh', N'Phú Diên, Phú Vang, Thừa Thiên Huế')
INSERT INTO KHACHHANG VALUES('KH0003', '1232567890', '1234566899', '98767432111', N'Bùi Thanh Tâm', N'Chiềng Ban, Mai Sơn, Sơn La')
INSERT INTO KHACHHANG VALUES('KH0004', '1234566890', '1236567899', '98765432121', N'Mai Hồng Ngọc', N'Du Già, Yên Minh, Hà Giang')
INSERT INTO KHACHHANG VALUES('KH0005', '1234961890', '1234567899', '98765432111', N'Võ Hoài Yên', N'Hữu Văn, Chương Mỹ, Hà Nội')
INSERT INTO KHACHHANG VALUES('KH0006', '1234967890', '1234567899', '98765432111', N'Phương Oanh', N'Hải Tân, Hải Dương, Hải Dương')
INSERT INTO KHACHHANG VALUES('KH0007', '1234067890', '1234567899', '98765432111', N'Thủy Tiên', N'Hùng An, Kim Động, Hưng Yên')
INSERT INTO KHACHHANG VALUES('KH0008', '1224567890', '1234567899', '98765432111', N'Công Vinh', N'Cầu Bà, Khánh Vĩnh, Khánh Hòa')

--Thông tin đoàn
INSERT INTO THONGTINDOAN VALUES('KH0001', N'Biệt đội Đại Nam', 3)
INSERT INTO THONGTINDOAN VALUES('KH0001', N'Từ thiện từ tâm', 3)
INSERT INTO THONGTINDOAN VALUES('KH0007', N'Mì tôm mãi ngon', 2)
INSERT INTO THONGTINDOAN VALUES('KH0003', N'Support Thanh Tâm', 5)

--Phiếu yêu cầu đặc biệt
INSERT INTO PHIEUYEUCAU(MaKH, NoiDung) VALUES('KH0001', N'1 đôi 1 đơn') 

--Phiếu đặt phòng/Chi tiết phiếu đặt
INSERT INTO PHIEUDATPHONG VALUES('PD0001', 'KH0001', '2023-06-19 08:30:00', '2023-06-28 12:30:00', 0)
INSERT INTO CTPHIEUDATPHONG VALUES('PD0001','LOAI01', 1)
INSERT INTO CTPHIEUDATPHONG VALUES('PD0001','LOAI02', 1)

--Đặt cọc/ hóa đơn 
INSERT INTO HOADON VALUES('HD0001', 'PD0001', -1050000)
INSERT INTO LICHSUGIAODICH(MaHD, NoiDung, HinhThucThanhToan, DonGia) VALUES('HD0001', N'Tiền đặt cọc', N'Tiền mặt', 1050000)

--Thông tin đặt phòng
INSERT INTO THONGTINDATPHONG VALUES('PD0001', 101, NULL)
INSERT INTO THONGTINDATPHONG VALUES('PD0001', 103, NULL)

--Vận chuyển hành lý
INSERT INTO THONGTINVANCHUYENHANHLY VALUES('PD0001', 101, 1, N'Vali Đỏ')
INSERT INTO THONGTINVANCHUYENHANHLY VALUES('PD0001', 103, 2, N'Vali Đen, Xanh lá')

--Hóa đơn thứ 2
INSERT INTO HOADON VALUES('HD0002', 'PD0001', NULL)

--Đăng ký dịch vụ/Tour/Sản phẩm
INSERT INTO TTDANGKYDICHVU(MaHD,MaDichVu,SoLuong) VALUES('HD0002', 'DV0001', 3)
INSERT INTO TTDANGKYTOUR(MaHD,MaTour,SoLuong) VALUES('HD0002', 'TOUR01', 3)
INSERT INTO TTSUDUNGSANPHAM(MaHD,SoLuong,MaSanPham) VALUES('HD0002', 3, 'SP0001')

--Kiểm tra phòng
INSERT INTO CTHOSOKIEMTRAPHONG(MaPhieuDat,SoPhong,NoiDung,ChiPhiThietHai) VALUES('PD0001', 101, N'Bể gương', 400000)
INSERT INTO CTHOSOKIEMTRAPHONG(MaPhieuDat,SoPhong,NoiDung,ChiPhiThietHai) VALUES('PD0001', 101, N'Rách ga giường', 100000)

--Kiểm tra minibar
INSERT INTO CTSUDUNGMINIBAR VALUES('PD0001',101,'SP0001',2)
INSERT INTO CTSUDUNGMINIBAR VALUES('PD0001',101,'SP0002',1)
INSERT INTO CTSUDUNGMINIBAR VALUES('PD0001',103,'SP0001',2)
INSERT INTO CTSUDUNGMINIBAR VALUES('PD0001',103,'SP0002',1)
