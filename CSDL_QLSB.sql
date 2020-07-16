create database QuanLySanBong
use QuanLySanBong



create table LoaiSan(
	MaLs int identity(1,1),
	TenLs nvarchar(50),
	primary key(MaLS)
)

insert into LoaiSan(TenLs) values(N'Sân 5')
insert into LoaiSan(TenLs) values(N'Sân 7')

create table BangGiaSan(
	GioBatDau time,
	GioKetThuc time,
	DonGia money,
	MaLs int ,
	primary key(GioBatDau,GioKetThuc,MaLs),
	foreign key(MaLs) references LoaiSan (MaLs)
)

insert into BangGiaSan values('5:0','11:0','70000','1')
insert into BangGiaSan values('11:0','16:0','50000','1')
insert into BangGiaSan values('16:0','0:0','100000','1')
insert into BangGiaSan values('5:0','11:0','200000','2')
insert into BangGiaSan values('11:0','16:0','180000','2')
insert into BangGiaSan values('16:0','0:0','250000','2')

create table NhaCungCap(
	MaNcc int identity(1,1),
	TenNcc nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(50),
	primary key(MaNcc)
)

insert into NhaCungCap(TenNcc,DiaChi,SoDienThoai) values(N'Tân Hiệp Phát',N'65 Tân Quy','0909164165')
insert into NhaCungCap(TenNcc,DiaChi,SoDienThoai) values(N'Suntory Pepsico',N'37 Tân Kiểng','0908119911')
insert into NhaCungCap(TenNcc,DiaChi,SoDienThoai) values(N'Lavie',N'44 Tân Phong','0909788977')

create table NhanVien(
	MaNv nvarchar(50),
	TenNv nvarchar(50),
	GioiTinh nvarchar(50),
	NgayVaoLam date,
	SoDienThoai nvarchar(50),
	Email nvarchar(50),
	primary key(MaNv)
)

insert into NhanVien values(N'A000',N'ADMIN',N'Nam','01/02/2020','0365486987','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A001',N'Nguyễn Minh A',N'Nam','01/02/2020','0365486987','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A002',N'Nguyễn Minh B',N'Nam','01/02/2020','0365487894','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A003',N'Nguyễn Minh C',N'Nữ','01/02/2020','0365486214','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A004',N'Nguyễn Minh D',N'Nam','01/02/2020','0365486111','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A005',N'Nguyễn Minh E',N'Nữ','01/02/2020','0365486444','dinhhoangnguyen6399@gmail.com')

create table LoaiTK(
	MaLoaiTK int identity(1,1),
	TenLoaiTK nvarchar(50),
	primary key(MaLoaiTK)
)
insert into loaiTK(TenLoaiTK) values(N'Admin')
insert into loaiTK(TenLoaiTK) values(N'Nhân Viên')

create table TaiKhoan(
	UserName nvarchar(50),
	Pass nvarchar(50),
	MaLoaiTK int,
	MaNv nvarchar(50),
	primary key(UserName),
	foreign key(MaNv) references NhanVien(MaNv)ON DELETE CASCADE ,
	foreign key(MaLoaiTk) references LoaiTk(MaLoaiTK)
)

create table PhanViec(
  MaNv nvarchar(50),
  tenCv nvarchar(50),
  primary key(MaNv,tenCv),
  foreign key(MaNv) references NhanVien(MaNv)ON DELETE CASCADE  
)
insert into PhanViec values('A001',N'Bán Hàng')
insert into PhanViec values('A002',N'Dọn Sân')
insert into TaiKhoan values('admin','lu0c+GqlVMQ=','1','A000')

create table KhachHang(
	MaKh int identity(1,1),
	TenKh nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(50),
	Email nvarchar(50),
	primary key(MaKh)
)

insert into KhachHang(TenKh,DiaChi,SoDienThoai,Email) values(N'Lê Văn A',N'65 Lê Lai','0452787878','')
insert into KhachHang(TenKh,DiaChi,SoDienThoai,Email) values(N'Lê Văn B',N'45 Lê Lợi','0452474778','')
insert into KhachHang(TenKh,DiaChi,SoDienThoai,Email) values(N'Lê Văn C',N'15 Lê Thánh Tôn','0401257878','')
insert into KhachHang(TenKh,DiaChi,SoDienThoai,Email) values(N'Lê Văn D',N'115 Lê Thái Tông','0459696878','')
insert into KhachHang(TenKh,DiaChi,SoDienThoai,Email) values(N'Lê Văn E',N'205 Lê Văn Sĩ','0452741018','')

create table San(
	MaSan int identity(1,1),
	TenSan nvarchar(50),
	TrangThai nvarchar(50),
	MaLs int,
	primary key(MaSan),
	foreign key(MaLs) references LoaiSan(MaLs)
)

insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-A',N'Trống','1')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-B',N'Trống','1')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-C',N'Trống','1')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-D',N'Trống','1')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-E',N'Trống','1')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 7-A',N'Trống','2')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 7-B',N'Trống','2')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 7-C',N'Trống','2')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 7-D',N'Trống','2')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 7-E',N'Trống','2')
insert into San(TenSan,TrangThai,MaLs) values(N'Sân 5-F',N'Trống','1')

create table HoaDon(
	MaHd int identity(1,1),
	GioBatDau time,
	GioKetThuc time,
	ThoiGianSuDung float,
	NgayXuat date,
	TongTien money,
	trangThai nvarchar(50),
	MaNv nvarchar(50),
	MaKh int,
	MaSan int,
	primary key(MaHd),
	foreign key(MaNv) references NhanVien(MaNv),
	foreign key(MaKh) references KhachHang(MaKh),
	foreign key(MaSan) references San(MaSan),
)

create table HangHoa(
	MaHh int identity(1,1),
	TenHh nvarchar(50),
	DVT nvarchar(50),
	SoLuongTon int,
	DonGia money,
	primary key(MaHh)
) 

insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Revive',N'Chai','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Revive Chanh Muối',N'Chai','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Pepsi',N'Chai','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Coca',N'Chai','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Number One',N'Chai','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Red Bull',N'Lon','10','15000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Fanta',N'Lon','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Mirinda',N'Lon','10','12000')
insert into HangHoa(TenHh,DVT,SoLuongTon,DonGia) values(N'Lavie',N'Chai','10','7000')

create table CTHoaDon(
	SoLuongBan int,
	donGia money,
	ThanhTien money,
	MaHd int,
	MaHh int ,
	primary key(MaHh,MaHd),
	foreign key (MaHh) references HangHoa(MaHh),
	foreign key (MaHd) references HoaDon(MaHd)
)
select top 1 with ties mahd from HoaDon order by (maHd) DESC

insert into CTHoaDon values('1','10000','0','4','3')
create table PhieuNhap(
	MaPhieu int identity(1,1),
	NgayNhap date,
	ThanhTien money,
	MaNcc int,
	primary key(MaPhieu),
	foreign key(MaNcc) references NhaCungCap(MaNcc)
)

insert into PhieuNhap(NgayNhap,ThanhTien,MaNcc,MaNv) values(null,null,null,null)

create table CTPhieuNhap(
	MaPhieu int,
	DVT nvarchar(50),
	SoLuongNhap int,
	GiaNhap money,
	MaHh int ,
	MaNcc int,
	primary key(MaPhieu,MaHh),
	foreign key (MaPhieu) references PhieuNhap(MaPhieu),
	foreign key (MaHh) references HangHoa(MaHh),
	foreign key (MaNcc) references NhaCungCap(MaNcc),
)
insert into CTPhieuNhap values('2','Chai','10','8000','1','2')

create table DatSan(
	MaDatSan int identity(1,1),
	MaSan int,
	MaKh int,
	TuGio time,
	DenGio time,
	TuNgay date,
	DenNgay date,
	ThoiGian time,
	Trangthai nvarchar(50),
	primary key(MaDatSan),
	foreign key(MaSan) references San(MaSan),
	foreign key(MaKh) references KhachHang(MaKh)
)

insert into DatSan(masan,makh,tugio,dengio,tungay,denngay,thoigian,trangthai) values('11','1','16:00','17:30','10/07/2020','10/07/2020','01:30',N'đã đặt')


 Create trigger tg_HoaDon_in on HoaDon for Insert
 as begin
  Declare @maHd int,@gioBatDau datetime,@gioKetThuc datetime, @donGia money,
  @maSan int,@maLoaiSan int,@soGioDa float 
  select @maHd=maHd,@gioBatDau=GioBatDau,@gioKetThuc=gioKetThuc,@maSan=MaSan from inserted
  select @maLoaiSan=MaLs from San where MaSan=@maSan
  select @donGia=DonGia from BangGiaSan where MaLs=@maLoaiSan and GioBatDau<= CONVERT(time,@gioBatDau) and GioKetThuc>= CONVERT(time,@gioBatDau)
  set @soGioDa= cast(datepart(hour, @gioKetThuc -@gioBatDau) as float)+cast(datepart(MINUTE, @gioKetThuc -@gioBatDau) as float)/60
  update hoaDon set tongTien=@donGia*@soGioDa where maHd=@maHd
 end
 drop trigger tg_HoaDon_in
 select DonGia from BangGiaSan where MaLs=1 and GioBatDau<= CONVERT(time,'18:00:00') and GioKetThuc>= CONVERT(time,'18:00:00')

 ---Trigger CTHD------
CREATE trigger tr_CTHD_IN on CTHoaDon for insert
as begin
 Declare @maHd int, @soLuongBan int, @donGia money, @thanhTien Money,
@MaHh int
 select @maHd=Mahd, @soLuongBan=SoLuongBan,@donGia=donGia,@MaHh=MaHh from inserted
 print @soluongBan
 set @thanhTien=@soLuongBan*@donGia
 print @donGia
 update CTHoaDon set ThanhTien=@thanhTien where MaHd=@maHd and MaHh=@maHh
 update HoaDon set tongTien=tongTien + @thanhTien where mahd=@maHd
 Update HangHoa set soLuongTon=soLuongTon-@soLuongBan where maHh=@MaHh
end

Create trigger tg_THD_Up on CTHoaDon for update
as begin
  Declare @maHd int, @soLuongBan int, @donGia money,@soLuongBanCu int,
  @thanhTienCu Money,@thanhTienMoi Money, @MaHh int
  select @thanhTienCu=thanhTien,@soLuongBanCu=SoLuongBan from deleted
  select @maHd=Mahd, @soLuongBan=SoLuongBan,@donGia=donGia,@MaHh=MaHh from inserted
 set @thanhTienMoi=@soLuongBan*@donGia
if(@thanhTienCu !=0) begin
  update CTHoaDon set ThanhTien=@thanhTienMoi where MaHd=@maHd and MaHh=@maHh
  update HoaDon set tongTien=tongTien + @thanhTienMoi-@thanhTienCu where mahd=@maHd
  Update HangHoa Set soLuongTon=soLuongTon-@soLuongBan+@soLuongBanCu where maHh=@maHh
  end
end

Create trigger tg_CThd_de on CTHoaDon for delete
as begin
Declare @maHd int,@thanhTien money,@maHh int,@soLuongBan int
select @maHd=maHd, @thanhTien=thanhTien,@maHh=MaHh,@soLuongBan=SoLuongBan from deleted
update HoaDon set tongTien=tongTien-@thanhTien where mahd=@maHd
  Update HangHoa Set soLuongTon=soLuongTon+@soLuongBan where maHh=@maHh
end


---Trigger CTPhieuNhap-----
Create trigger Tg_CTPhieuNhap_in on CTPhieuNhap for Insert
as begin
Declare @MaPhieu int,@soLuongNhap int,@giaNhap Money,@maHh int
 Select @MaPhieu=maPhieu,@soLuongNhap=SoLuongNhap,@giaNhap=GiaNhap,@maHh=maHh from inserted
 update PhieuNhap set thanhTien=ThanhTien+(@soLuongNhap*@giaNhap) where maPhieu=@MaPhieu
 update HangHoa set SoLuongTon=soLuongTon + @soLuongNhap where maHh=@maHh
end

Create trigger Tg_CTPhieuNhap_Up on CTPhieuNhap for Update
as begin
Declare @MaPhieu int,@soLuongNhapCu int,@giaNhapCu Money,@maHh int,
@soLuongNhapMoi int,@GiaNhapMoi money
select @soLuongNhapCu=SoLuongNhap,@giaNhapCu=GiaNhap from deleted
Select @soLuongNhapMoi=SoLuongNhap,@GiaNhapMoi=GiaNhap,@MaPhieu=maPhieu,@maHh=MaHh from inserted
Update PhieuNhap set thanhTien=ThanhTien+(@soLuongNhapMoi*@GiaNhapMoi)-(@soLuongNhapCu*@giaNhapCu) where maPhieu=@MaPhieu
update HangHoa set soLuongTon=soLuongTon+@soLuongNhapMoi-@soLuongNhapCu where maHh=@maHh
end

Create trigger Tg_CTPhieuNhap_dele on CTPhieuNhap for delete
as begin
Declare @MaPhieu int,@soLuongNhap int,@giaNhap Money,@maHh int
select @MaPhieu=maPhieu,@soLuongNhap=soLuongNhap,@giaNhap=giaNhap from deleted
update PhieuNhap set thanhTien=thanhTien-(@soLuongNhap*@giaNhap) where maPhieu=@MaPhieu
Update HangHoa set soLuongTon=soLuongTon-@soLuongNhap where maHh=@maHh
SELECT FORMAT(123456789, 'C0')
end
select * from BangGiaSan
Select FORMAT(sum(ThanhTien),'C0')as thanhTien from CTHoaDon
update hoadon set trangThai=N'Chưa Thanh Toán'
select * from HoaDon

--Proc--
Create proc pr_HoaDon
as begin
 Select Mahd,MaNv,NgayXuat,MaKh,TongTien,TrangThai from HoaDon where NgayXuat betWeen N'2020-07-20' and N'2020-07-21'
end
Create proc LayNgay
as begin
 select getdate()as tuNgay,getdate() as denNgay
end
create proc getTien
as begin 
select PARSENAME(CONVERT(varchar, CAST(sum(tongTien) AS money), 1), 2)as thanhTien from HoaDon
end


--querry Doanh Thu---
select * from taikhoan
select convert(nvarchar(30), NgayXuat, 23)as NgayXuat,sum(TongTien)as TongTien from HoaDon 
   where NgayXuat between N'2020-07-13' and N'2020-07-15' group by convert(nvarchar(30), NgayXuat, 23)