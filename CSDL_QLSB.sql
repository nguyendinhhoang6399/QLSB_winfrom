create database QuanLySanBong
use QuanLySanBong

--drop database QuanLySanBong

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
--drop table BangGiaSan
select * from BangGiaSan
insert into BangGiaSan values('5:0','11:0','70000','1')
insert into BangGiaSan values('11:0','16:0','50000','1')
insert into BangGiaSan values('16:0','0:0','100000','1')
insert into BangGiaSan values('5:0','11:0','200000','2')
insert into BangGiaSan values('11:0','16:0','180000','2')
insert into BangGiaSan values('16:0','0:0','250000','2')

select * from BangGiaSan

create table NhaCungCap(
	MaNcc int identity(1,1),
	TenNcc nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(50),
	primary key(MaNcc)
)
drop table NhaCungCap

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
--drop table NhanVien

insert into NhanVien values(N'A001',N'Nguyễn Minh A',N'Nam','01/02/2020','0365486987','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A002',N'Nguyễn Minh B',N'Nam','01/02/2020','0365487894','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A003',N'Nguyễn Minh C',N'Nữ','01/02/2020','0365486214','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A004',N'Nguyễn Minh D',N'Nam','01/02/2020','0365486111','dinhhoangnguyen6399@gmail.com')
insert into NhanVien values(N'A005',N'Nguyễn Minh E',N'Nữ','01/02/2020','0365486444','dinhhoangnguyen6399@gmail.com')

create table TaiKhoan(
	UserName nvarchar(50),
	Pass nvarchar(50),
	MaNv nvarchar(50),
	primary key(MaNv),
	foreign key(MaNv) references NhanVien(MaNv)
)


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

select * from San
--drop table San

create table HoaDon(
	MaHd int identity(1,1),
	GioBatDau time,
	GioKetThuc time,
	ThoiGianSuDung time,
	NgayXuat date,
	TongTien money,
	MaNv nvarchar(50),
	MaKh int,
	MaSan int,
	primary key(MaHd),
	foreign key(MaNv) references NhanVien(MaNv),
	foreign key(MaKh) references KhachHang(MaKh),
	foreign key(MaSan) references San(MaSan),
)
drop table HoaDon
create table HangHoa(
	MaHh int identity(1,1),
	TenHh nvarchar(50),
	DVT nvarchar(50),
	SoLuongTon int,
	DonGia money,
	primary key(MaHh)
) 
drop table HangHoa
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
	TenHh nvarchar(50),
	SoLuongBan int,
	donGia money,
	ThanhTien money,
	MaHd int,
	MaHh int ,
	primary key(MaHh,MaHd),
	foreign key (MaHh) references HangHoa(MaHh),
	foreign key (MaHd) references HoaDon(MaHd)
)

drop table CTHoaDon

create table PhieuNhap(
	MaPhieu int identity(1,1),
	NgayNhap date,
	MaNcc int,
	TenNcc nvarchar(50),
	ThanhTien money,
	MaNv nvarchar(50),
	primary key(MaPhieu),
	foreign key(MaNv) references NhanVien(MaNv),
	foreign key(MaNcc) references NhaCungCap(MaNcc)
)
--drop table PhieuNhap
insert into PhieuNhap
create table CTPhieuNhap(
	MaPhieu int,
	TenHh nvarchar(50),
	DVT nvarchar(50),
	SoLuongNhap int,
	GiaNhap money,
	MaHh int ,
	MaNcc int,
	TenNcc nvarchar(50),
	primary key(MaPhieu,MaHh),
	foreign key (MaPhieu) references PhieuNhap(MaPhieu),
	foreign key (MaHh) references HangHoa(MaHh),
	foreign key (MaNcc) references NhaCungCap(MaNcc),
)

--drop table CTPhieuNhap
select * from CTPhieuNhap
create table DatSan(
	MaDatSan int identity(1,1),
	MaSan int,
	MaKh int,
	TuGio time,
	DenGio time,
	TuNgay date,
	DenNgay date
	primary key(MaDatSan)
	foreign key(MaSan) references San(MaSan),
	foreign key(MaKh) references KhachHang(MaKh)
)
drop table DatSan

	
--drop table DatSanCD

select * from San where mals = 1
select * from CTHoaDon
select * from HangHoa
insert into CTHoaDon values('2','12000','24000','','Revive')


select * from NhaCungCap
delete from KhachHang where TenKh = N'Võ A'
update KhachHang set TenKh = N'Võ A', DiaChi = N'24 Cô Bắc',SoDienThoai='123',Email=N'huyhuyhoihoi@xyz' where 
delete khachHang where tenkh = N'Lê Văn A'

select * from HoaDONNhapThuoc