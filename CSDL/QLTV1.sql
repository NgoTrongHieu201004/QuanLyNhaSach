create database QuanlyNhaSach
--drop database QLNhaSach
go
use QuanLyNhaSach
go
set dateformat dmy
go

---- Tao bang Users ----
create table Users 
(
	UserId int identity(1,1) primary key,
	Username nvarchar(50) not null unique,
	Password nvarchar(255) not null,
	MaQuyenHan int not null
)
go
---- Tao bang QuyenHan----
create table QuyenHan
(
	MaQuyenHan int identity(1,1) primary key,
	TenQuyenHan nvarchar(50) not null unique
)
----Tao bang NhanVien----
create table ThongTinUser
(
	UserId int primary key,
	TenNhanVien nvarchar (30),
	NgaySinh date,
	GioiTinh nvarchar (5),
	Sdt nvarchar (10),
	DiaChi nvarchar(100),
	Luong float
)
go 
---Tao Bang Du Lieu KhachHang
create table KhachHang
(
	MaKhachHang nvarchar(11) primary key not null,
	HoTen nvarchar(30),                                 
	GioiTinh nvarchar(5),
	Tuoi date,
	Email nvarchar (30),
	Sdt nvarchar (10),
	UserId int
)
go
----Tao bang TheLoai--------------
create table TheLoai
(
	MaTheLoai nvarchar (11) primary key not null,
	TenTheLoai nvarchar (30),
)
go
---Tao bang TacGia
create table TacGia      
(
	MaTacGia nvarchar (11) primary key not null,
	TenTacGia nvarchar (30),
	GioiTinh nvarchar (5),
	TuoiTacGia date,
	TieuSu nvarchar (150)
)
go
---tao bang khoSach-----
create table KhoSach
(
	MaKhoSach nvarchar (11) primary key not null,
	TenKhoSach nvarchar(30),
)


go
--Tao Bang NhaXuatBan-----
create table NhaXuatBan
(
	MaNhaXuatBan nvarchar(11) primary key not null,
	TenNhaXuatBan nvarchar (30),
	DiaChiNhaXuatBan nvarchar (30),
	SdtNhaXuatBan nvarchar (10),
)
---Tao bang du lieu Sach------
go
 create table Sach
(
	MaSach nvarchar (11) primary key not null,
	TenSach nvarchar (30),
	MaTacGia nvarchar (11),
	MaTheLoai nvarchar (11),
	MaNhaXuatBan nvarchar(11),
	MaKhoSach nvarchar (11),
	UserId int,
	Gia float
	
)

 create table HoaDon
(
	MaHD nvarchar (10) primary key not null,
	MaKhachHang nvarchar (11),
    MaSach nvarchar(11),                   
    SoLuong INT,                 
	TongTien float,
	UserId int,
	NgayLapHD date
)

-----------------------------KHOA NGOAI------------------------------
go
alter table Users
add constraint FK_Users_QuyenHan foreign key (MaQuyenHan) references QuyenHan(MaQuyenHan)
go
alter table ThongTinUser
add constraint FK_ThongTinUser_Users foreign key (UserId) references Users(UserId)
on delete cascade
go
alter table Sach
add constraint FK_Sach_TacGia foreign key (MaTacGia) references TacGia(MaTacGia)
go
alter table Sach
add constraint FK_Sach_TheLoai foreign key (MaTheLoai) references Theloai(MaTheLoai)
go
alter table Sach
add constraint FK_Sach_NhaXuatBan foreign key (MaNhaXuatBan) references NhaXuatBan(MaNhaXuatBan)
go
alter table Sach
add constraint FK_Sach_KhoSach foreign key (MaKhoSach) references KhoSach(MaKhoSach)
go
alter table Sach
add constraint FK_Sach_ThongTinUser foreign key (UserId) references ThongTinUser(UserId)
go
alter table KhachHang
add constraint FK_KhachHang_ThongTinUser foreign key (UserId) references ThongTinUser(UserId)
go
alter table HoaDon
add constraint FK_HoaDon_KhachHang foreign key (MaKhachHang) references KhachHang(MaKhachHang)
go
alter table HoaDon
add constraint FK_HoaDon_Sach foreign key (MaSach) references Sach(MaSach)
go
alter table HoaDon
add constraint FK_HoaDon_ThongTinUser foreign key (UserId) references ThongTinUser(UserId)
go

