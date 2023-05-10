--Xem thong tin phong
DROP PROC THONGTINPHONG
create proc THONGTINPHONG @sophong int
as
BEGIN
	DECLARE @MAPHIEUDP AS VARCHAR(6) = (select TOP 1 MaPhieuDat 
									from THONGTINDATPHONG 
									where sophong = @sophong 
									ORDER BY MaPhieuDat DESC)
	SELECT P.MaPhieuDat, P.MaKH, K.HoTen ,P.NgayDen, P.NgayDi, PH.SoPhong, L.TenLoaiPhong, L.DonGia
	FROM PHIEUDATPHONG P JOIN KHACHHANG K ON P.MaKH=K.MaKH JOIN THONGTINDATPHONG T ON P.MaPhieuDat=T.MaPhieuDat JOIN PHONG PH ON T.SoPhong=PH.SoPhong JOIN LOAIPHONG L ON PH.MaLoaiPhong=L.MaLoaiPhong
	WHERE P.MaPhieuDat = @MAPHIEUDP
END

-- Xac nhan Dichvu/Tour
create proc XACNHAN_DVU_TOUR @mahd as varchar(6)
as
begin
	select d.TenDV, tt.SoLuong, d.DonGia
	from TTDANGKYDICHVU tt join DICHVU d on tt.MaDichVu=d.MaDV
	where tt.MaHD = @mahd
	union
	select t.TenTour, tt.SoLuong, t.DonGia
	from TTDANGKYTOUR tt join TOUR t on tt.MaTour=t.MaTour
	where tt.MaHD = @mahd
end

--Xac nhan kiem tra phong
drop proc XACNHAN_KTPHONG
create proc XACNHAN_KTPHONG @mapd as varchar(6)
as
begin
	select SoPhong, NoiDung, ChiPhiThietHai, null as SoLuong
	from CTHOSOKIEMtRAPHONG
	where MaPhieuDat = @mapd
	union
	select c.SoPhong, s.TenSanPham, s.DonGia, c.SoLuong
	from CTSUDUNGMINIBAR c join SANPHAM s on c.MaSanPham=s.MaSanPham
	where MaPhieuDat = @mapd
end

--Hoa Don
create proc TONG_HOADON @mahd as varchar(6)
as
begin
	declare @madp as varchar(6) = (select MaPhieuDat from HOADON where MaHD = @mahd)
	--DichVu
	declare @dichvu as int = (select sum(tt.SoLuong*d.DonGia) 
							from TTDANGKYDICHVU tt join DICHVU d on tt.MaDichVu=d.MaDV
							where tt.MaHD = @mahd)
	--Tour
	declare @tour as int = (select sum(tt.SoLuong*t.DonGia) 
							from TTDANGKYTOUR tt join TOUR t on tt.MaTour=t.MaTour
							where tt.MaHD = @mahd)

	--SanPham
	declare @sp as int = (select sum(tt.SoLuong*s.DonGia) 
							from TTSUDUNGSANPHAM tt join SANPHAM s on tt.MaSanPham=s.MaSanPham
							where tt.MaHD = @mahd)

	--minibar
	declare @sp2 as int = (select sum(ct.SoLuong*s.DonGia) 
							from CTSUDUNGMINIBAR ct join SANPHAM s on ct.MaSanPham=s.MaSanPham
							where ct.MaPhieuDat = @madp)

	--KTphong
	declare @ktp as int = (select sum(ChiPhiThietHai)
							from CTHOSOKIEMTRAPHONG
							where MaPhieuDat = @madp)

	--Songayluutru
    declare @ngay as int = (select datediff(day, ngayden, ngaydi) from PHIEUDATPHONG where MaPhieuDat = @madp)
	declare @tienphong as int = (select sum(l.DonGia)*@ngay
									from PHIEUDATPHONG p join THONGTINDATPHONG tt on p.MaPhieuDat=tt.MaPhieuDat
										join PHONG ph on tt.SoPhong=ph.SoPhong 
										join LOAIPHONG l on ph.MaLoaiPhong=l.MaLoaiPhong
									where p.MaPhieuDat = @madp)
	declare @total as int = @tienphong - (@tienphong*0.3) + @dichvu + @tour + @sp + @sp2 + @ktp
	select @total
end

--Kiem tra trang thai phong
drop proc KT_TRANGTHAIPHONG
create proc KT_TRANGTHAIPHONG @sophong as int
as
begin
	declare @check as nvarchar(20) = (select top 1 TrangThai from THONGTINDATPHONG where SoPhong = @sophong order by MaPhieuDat desc)
	if @check = 'Check out' or @check is null
		begin
			select 1
		end
	else select top 1 MaPhieuDat 
		from THONGTINDATPHONG 
		where TrangThai = 'Check in' and SoPhong = @sophong 
		order by MaPhieuDat desc
end
-- Dat
CREATE
--DROP
FUNCTION f_TienPhong (@MaPhieuDat char(6))
RETURNS INT
BEGIN
    DECLARE @tong int;
    SELECT @tong = SUM(CT.SoLuong*LP.DonGia)
            FROM CTPHIEUDATPHONG CT JOIN LOAIPHONG LP ON CT.MaLoaiPhong = LP.MaLoaiPhong
            WHERE @MaPhieuDat = CT.MaPhieuDat
    RETURN @tong;
END

go
CREATE 
--DROP
TRIGGER TG_CTPHIEUDATPHONG ON CTPHIEUDATPHONG
AFTER INSERT, UPDATE
AS 
  BEGIN
    DECLARE @MaPhieuDat char(6);
    SELECT @MaPhieuDat = INSERTED.MaPhieuDat FROM INSERTED;
    UPDATE PHIEUDATPHONG SET TongTienPhong=DBO.f_TienPhong(@MaPhieuDat) where @MaPhieuDat = MaPhieuDat;
  END

go
