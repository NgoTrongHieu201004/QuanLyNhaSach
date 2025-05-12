---------------------------------------------STORE----------------------------
-------------Users-----------------------
----get Users----------------
go
create proc getUsers 
as
begin
select * from Users
end
go
----combobox QuyenHan--------
create proc comboQuyenHan
as
begin
	select MaQuyenHan, TenQuyenHan 
	from QuyenHan
	order by MaQuyenHan asc
end
go
----Insert Users------------
create proc insert_Users
	@Username nvarchar(50),
	@Password nvarchar(255),
	@MaQuyenHan int
as
begin
	insert into Users(Username, Password, MaQuyenHan)
	values(@Username, @Password, @MaQuyenHan)
end
go
---- update Users-----------
create proc update_Users
	@UserId int,
	@Username nvarchar(50),
	@Password nvarchar(255),
	@MaQuyenHan int
as
begin
	update Users set Username = @Username, Password = @Password, MaQuyenHan = @MaQuyenHan
	where UserId = @UserId
end
go
---- delete---------------
create proc delete_Users
	@UserId int
as
begin
	delete from Users
	where UserId = @UserId
end
go

-------------ThongTinUser--------------
----get ThongTinUser--------
go
create proc getThongTinUser 
as
begin
select * from ThongTinUser
end
go
----combobox User--------
create proc comboUser
as
begin
	select UserId, Username
	from Users
	order by UserId asc
end
go
---- lay user chua co ThongTin----
create proc GetUsersWithoutThongTin
as
begin
    select u.UserId, u.Username
    from Users u
	where not exists (select 1 from ThongTinUser t where t.UserId = u.UserId);
end
go

---- insert ThongTinUser---------
create proc insert_ThongTinUser
	@UserId int,
	@TenNhanVien nvarchar (30),
	@NgaySinh date,
	@GioiTinh nvarchar (5),
	@Sdt nvarchar (10),
	@DiaChi nvarchar(100),
	@Luong float
as
begin
	insert into ThongTinUser (UserId, TenNhanVien, NgaySinh, GioiTinh, Sdt, DiaChi, Luong)
	values(@UserId, @TenNhanVien, @NgaySinh, @GioiTinh, @Sdt, @DiaChi, @Luong)
end
go
----update ThongTinUser--------
create proc update_ThongTinUser
	@UserId int,
	@TenNhanVien nvarchar (30),
	@NgaySinh date,
	@GioiTinh nvarchar (5),
	@Sdt nvarchar (10),
	@DiaChi nvarchar(100),
	@Luong float
as
begin
	update ThongTinUser set TenNhanVien = @TenNhanVien, NgaySinh= @NgaySinh, GioiTinh = @GioiTinh, Sdt = @Sdt, DiaChi = @DiaChi, Luong = @Luong
	where UserId = @UserId
end
go
---- delete ThongTinUser---------------
create proc delete_ThongTinUser
	@UserId int
as
begin
	delete from ThongTinUser
	where UserId = @UserId
end
go
----- search NhanVien---------
create proc searchNhanVien
@TenNhanVien nvarchar(30)
as
begin
select * from ThongTinUser where TenNhanVien Like '%' + @TenNhanVien + '%'
end
go

--------------------------------------------TheLoai--------------------------------------
------------------------------Them The Loai

create proc Insert_TheLoai
@MaTheLoai nvarchar (11),
@TenTheLoai nvarchar (30)
as 
begin
Insert into TheLoai (MaTheLoai,TenTheLoai)
values (@MaTheLoai,@TenTheLoai)
end
go
------------------------------Xoa TheLoai
create proc Delete_TheLoai
@MaTheLoai nvarchar (11)
as
begin
Delete TheLoai where MaTheLoai = @MaTheLoai
end
go
-----------------------------Sua The Loai
create proc Update_TheLoai
@MaTheLoai nvarchar (11),
@TenTheLoai nvarchar (30)
as
begin
	update TheLoai set TenTheLoai = @TenTheLoai
	where MaTheLoai = @MaTheLoai
end
go
------get The Loai--------
create proc getTheLoai
as
begin
	select * from TheLoai
end

----------------------------------ThemXoaSuaTacGia---------------------------------------------
------------------------------TacGia-----------------------------------------------------------
go
create proc Insert_TacGia
@MaTacGia nvarchar (11),
@TenTacGia nvarchar (30),
@GioiTinh nvarchar (5),
@TuoiTacGia date,
@TieuSu nvarchar (150)
as
begin
	Insert into TacGia(MaTacGia,TenTacGia,GioiTinh,TuoiTacGia,TieuSu)
	values(@MaTacGia,@TenTacGia,@GioiTinh,@TuoiTacGia,@TieuSu)
end
go
------------------Xoa Tac Gia-------------------
create proc Delete_TacGia
@MaTacGia nvarchar (11)
as
begin
	Delete TacGia where MaTacGia= @MaTacGia
end
-------------------Sua Tac Gia
go
create proc UpDate_TacGia
@MaTacGia nvarchar (11),
@TenTacGia nvarchar (30),
@GioiTinh	nvarchar (5),
@TuoiTacGia date,
@TieuSu nvarchar (150)
as
begin
	Update TacGia set TenTacGia = @TenTacGia,GioiTinh = @GioiTinh, TuoiTacGia = @TuoiTacGia, TieuSu = @TieuSu
	where MaTacGia = @MaTacGia
end
go
------get TacGia--------
create proc getTacGia
as
begin
	select * from TacGia
end
go
--------------------------------------------------KHOSACH------------------------------
-----insert KhoSach
create proc Insert_KhoSach
@MaKhoSach nvarchar (11),
@TenKhosach nvarchar(30)
as 
begin
	Insert into KhoSach (MaKhoSach,TenKhosach)
	values (@MaKhoSach,@TenKhosach)
end
go
------------------Xoa Kho Sach-------------------
create proc Delete_Kho
@MaKhoSach nvarchar (11)
as
begin
	Delete KhoSach where MaKhoSach= @MaKhoSach
end
go
-------------------Sua kho
create proc UpDate_Kho
@MaKhoSach nvarchar (11),
@TenKhosach nvarchar(30)
as
begin
	Update KhoSach set TenKhosach = @TenKhosach
	where MaKhoSach = @MaKhoSach
end
go
------get Kho--------
create proc getKho
as
begin
select * from KhoSach
end
go
---------------------------------------NhaxuatBan----------------------------
-----------Them nha xuat Ban
create proc Insert_NXB
@MaNhaXuatBan nvarchar (11),
@TenNhaXuatBan nvarchar (30),
@DiaChiNhaXuatBan nvarchar (30),
@SdtNhaXuatBan nvarchar (10)
as
begin
Insert into NhaXuatBan (MaNhaXuatBan,TenNhaXuatBan,DiaChiNhaXuatBan,SdtNhaXuatBan)
values (@MaNhaXuatBan,@TenNhaXuatBan,@DiaChiNhaXuatBan,@SdtNhaXuatBan)
end
go
--------Xoa NXB
create proc Delete_NXB
@MaNhaXuatBan nvarchar (11)
as
begin
Delete NhaXuatBan where MaNhaXuatBan = @MaNhaXuatBan
end
go
------------Sua_NXB
create proc Update_NXB
@MaNhaXuatBan nvarchar (11),
@TenNhaXuatBan nvarchar (30),
@DiaChiNhaXuatBan nvarchar (30),
@SdtNhaXuatBan nvarchar (10)
as
begin
Update NhaXuatBan set TenNhaXuatBan = @TenNhaXuatBan,DiaChiNhaXuatBan = @DiaChiNhaXuatBan,SdtNhaXuatBan = @SdtNhaXuatBan
where MaNhaXuatBan = @MaNhaXuatBan
end
go
------get NXB--------
create proc getNXB
as
begin
select * from NhaXuatBan
end
go


--------------------VietStore cho Sach--------------------
----combobox Sach--------
create proc comboSach
as
begin
	select MaSach, TenSach
	from Sach
end
go
----combobox TheLoai--------
create proc comboTheLoai
as
begin
	select MaTheLoai, TenTheLoai
	from TheLoai
end
go
----combobox TacGia--------
create proc comboTacGia
as
begin
	select MaTacGia, TenTacGia
	from TacGia
end
go
----combobox NXB--------
create proc comboNhaXuatBan
as
begin
	select MaNhaXuatBan, TenNhaXuatBan
	from NhaXuatBan
end
go
----combobox KhoSach--------
create proc comboKhoSach
as
begin
	select MaKhoSach, TenKhoSach
	from KhoSach
end
go
----combobox User--------
create proc comboNhanVien
as
begin
	select UserId, TenNhanVien
	from ThongTinUser
end
go
------get Sach--------
create proc getSach
as
begin
select * from Sach
end
go
------tim kiem Sach--------
create proc searchSach
@TenSach nvarchar(30)
as
begin
select * from Sach where TenSach Like '%' + @TenSach + '%'
end
go



-------------------------Them-----------------------------
create proc Insert_Sach(
@MaSach nvarchar (11),
@TenSach nvarchar (30),
@MaTacGia nvarchar (11),
@MaTheLoai nvarchar (11),
@MaNhaXuatBan nvarchar (11),
@MaKhoSach nvarchar (11),
@UserId int,
@Gia float

)
as
begin
Insert into Sach(MaSach,TenSach,MaTacGia, MaTheLoai, MaNhaXuatBan, MaKhoSach, UserId, Gia)
values (@MaSach, @TenSach, @MaTacGia, @MaTheLoai, @MaNhaXuatBan, @MaKhoSach, @UserId, @Gia)
end

-------Xoa Sach------------
go
create proc Delete_Sach
@MaSach nvarchar (11)
as
begin
delete Sach Where MaSach = @MaSach
end
---------------------Update sach---------------------
go
create proc Update_Sach
@MaSach nvarchar (11),
@TenSach nvarchar (30),
@MaTacGia nvarchar (11),
@MaTheLoai nvarchar (11),
@MaNhaXuatBan nvarchar (11),
@MaKhoSach nvarchar (11),
@UserId int,
@Gia float
as
begin
Update Sach set TenSach = @TenSach,MaTacGia = @MaTacGia, MaTheLoai = @MaTheLoai, MaNhaXuatBan = @MaNhaXuatBan, MaKhoSach = @MaKhoSach, Gia = @Gia
where MaSach = @MaSach
end
go

------------------------------KhachHang------------------------------

----combobox KhachHang--------
create proc comboKhachHang
as
begin
	select MaKhachHang, HoTen
	from KhachHang
end
go
----------get KhachHang--------
create proc getKhachHang
as
begin
select * from KhachHang
end
go
-------------------------Them-----------------------------
go
create proc Insert_KhachHang(
@MaKhachHang nvarchar(11),
@HoTen nvarchar(30),
@GioiTinh nvarchar(5),
@Tuoi date,
@Email nvarchar (30),
@Sdt nvarchar (10),
@UserId int

)
as
begin
Insert into KhachHang(MaKhachHang,HoTen,GioiTinh, Tuoi, Email, Sdt, UserId)
values (@MaKhachHang, @HoTen, @GioiTinh, @Tuoi, @Email, @Sdt, @UserId)
end
go

-------Xoa KhachHang------------
create proc Delete_KhachHang
@MaKhachHang nvarchar (11)
as
begin
delete KhachHang Where MaKhachHang = @MaKhachHang
end
go
---------------------Update KhachHang---------------------
create proc Update_KhachHang
@MaKhachHang nvarchar(11),
@HoTen nvarchar(30),
@GioiTinh nvarchar(5),
@Tuoi date,
@Email nvarchar (30),
@Sdt nvarchar (10),
@UserId int
as
begin
Update KhachHang set HoTen = @HoTen, GioiTinh = @GioiTinh, Tuoi = @Tuoi, Email = @Email, Sdt = @Sdt, UserId = @UserId
where MaKhachHang = @MaKhachHang
end
go

------tim kiem KhachHang--------go
create proc searchKhachHang
@TenKhachHang nvarchar(30)
as
begin
select * from KhachHang where @TenKhachHang Like '%' + @TenKhachHang + '%'
end
go

------------------------------HOADON------------------------------
----------get HoaDon--------
create proc getHoaDon
as
begin
select * from HoaDon
end
go
-------------------------Them-----------------------------
go
create proc Insert_HoaDon
@MaHD nvarchar (10),
@MaKhachHang nvarchar (11),
@MaSach nvarchar(11),                   
@SoLuong INT,                 
@TongTien float,
@UserId int,
@NgayLapHD date
as
begin
Insert into HoaDon(MaHD,MaKhachHang,MaSach, SoLuong, TongTien, UserId, NgayLapHD)
values (@MaHD, @MaKhachHang, @MaSach, @SoLuong, @TongTien, @UserId, @NgayLapHD)
end
go

-------Xoa KhachHang------------
create proc Delete_HoaDon
@MaHD nvarchar (11)
as
begin
delete HoaDon Where MaHD = @MaHD
end
go
---------------------Update KhachHang---------------------
create proc Update_HoaDon
@MaHD nvarchar (10),
@MaKhachHang nvarchar (11),
@MaSach nvarchar(11),                   
@SoLuong INT,                 
@TongTien float,
@UserId int,
@NgayLapHD date
as
begin
Update HoaDon set MaKhachHang = @MaKhachHang, MaSach = @MaSach, SoLuong = @SoLuong, TongTien = @TongTien, UserId = @UserId, NgayLapHD = @NgayLapHD
where MaHD = @MaHD
end
go

------tim kiem KhachHang--------go
create proc searchHoaDon
@Start date,
@End date
as
begin
select * from HoaDon where NgayLapHD between @Start and @End
end
go

----
create proc Gia_Sach
@MaSach nvarchar(11)
as
begin
select Gia from Sach Where MaSach = @MaSach
end
go

