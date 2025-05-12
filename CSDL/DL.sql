----------------DU LIEU------------------------
----Quyen Han-----------
insert into QuyenHan(TenQuyenHan)
Values (N'Quản Lý'),
	   (N'Thu Ngân'),
	   (N'Dọn Dẹp')
go 


-----Users-------------
insert into Users(Username,Password, MaQuyenHan)
Values ('admin','admin', 1),
	   ('nhanvien1','nhanvien1', 2)
go

-----ThongTinUser-------------
insert into ThongTinUser(UserId, TenNhanVien,NgaySinh, GioiTinh,Sdt, DiaChi, Luong)
Values (1,N'Nguyễn Văn A', '1985-05-15', N'Nam', '0123456789', N'123 Đường ABC, Hà Nội', 9000000),
	   (2,N'Trần Thị B', '1990-08-20', N'Nữ', '0987654321', N'456 Đường XYZ, TP.HCM', 7000000)
go
------KhachHang----------
insert into KhachHang(MaKhachHang, HoTen, GioiTinh, Tuoi, Email, Sdt, UserId)
values ('KH01',N'Lâm Vạn Thuận', N'Nam', '2003-04-05', 'vanthuan03@gmail.com', '0233445567', 2),
	   ('KH02',N'Phạm Thị A', N'Nữ', '2003-04-05', 'apham98@gmail.com', '0233445567', 2)
go
------TheLoai------------
insert into TheLoai(MaTheLoai, TenTheLoai)
values ('TL01', N'Tiểu Thuyết'),
	   ('TL02', N'Trinh Thám'),
	   ('TL03', N'Cổ Tích')
------TacGia-------------
insert into TacGia(MaTacGia, TenTacGia, GioiTinh, TuoiTacGia, TieuSu)
values ('TG01',N'Pham Van A', N'Nam', '1989-04-05', N'Tieu Su'),
	   ('TG02',N'Nguyen Van S', N'Nam', '1945-03-26', N'Tieu Su')
------KhoSach------------
insert into KhoSach(MaKhoSach,TenKhoSach)
values ('KS01',N'Kho A'),
	   ('KS02',N'Kho B')
-----NhaXuatBan----------
insert into NhaXuatBan(MaNhaXuatBan, TenNhaXuatBan, DiaChiNhaXuatBan, SdtNhaXuatBan)
values ('NXB01', N'Kim Đồng', N'Ha Noi', '0122334456'),
	   ('NXB02', N'Báo Chí', N'HCM', '0143596870')
-----Sach---------------
insert into Sach(MaSach, TenSach, MaTacGia, MaTheLoai, MaNhaXuatBan, MaKhoSach, UserId , Gia)
values ('S01', N'Mắt Biếc','TG01','TL03', 'NXB02', 'KS01', 2, 20000),
	   ('S02', N'Ánh Trăng','TG02','TL01', 'NXB01', 'KS02', 1, 30000)
------HoaDon---------
insert into HoaDon(MaHD, MaKhachHang, MaSach, SoLuong, TongTien, UserId, NgayLapHD)
values ('HD01', 'KH01', 'S02', 2, 60000, 1, '2024-12-14')