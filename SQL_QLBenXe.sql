Create Database QLBenXe
Go
use QLBenXe
Go

CREATE TABLE NhanVien
(
  MaNhanVien CHAR(5) NOT NULL,
  TenNhanVien NVARCHAR(50),
  MatKhau VARCHAR(20),
  Quyen VARCHAR(12),
  PRIMARY KEY (MaNhanVien)
);

CREATE TABLE Khach
(
  MaKhach CHAR(5) NOT NULL,
  CCCD CHAR(12),
  TenKhachHang NVARCHAR(50),
  Tuoi INT,
  SDT CHAR(11),
  TaiKhoan VARCHAR(10),
  MK VARCHAR(10),
  PRIMARY KEY (MaKhach)
);

CREATE TABLE TinhThanh
(
  MaTinh CHAR(5) NOT NULL,
  TenTinh NVARCHAR(50),
  PRIMARY KEY (MaTinh)
);

CREATE TABLE HangXe
(
  MaHangXe CHAR(5) NOT NULL,
  TenHangXe NVARCHAR(20),
  PRIMARY KEY (MaHangXe)
);

CREATE TABLE DichVu
(
  MaDV CHAR(5) NOT NULL,
  TenDV NVARCHAR(20),
  PRIMARY KEY (MaDV)
);

CREATE TABLE LoaiXe
(
  MaLoaiXe CHAR(5) NOT NULL,
  TenLoaiXe NVARCHAR(30),
  SoGhe INT,
  PRIMARY KEY (MaLoaiXe)
);

CREATE TABLE Chuyen
(
  MaChuyen CHAR(5) NOT NULL,
  TenChuyen NVARCHAR(50),
  DiemBatDau CHAR(5),
  DiemDen CHAR(5),
  TGChuyen TIME,
  PRIMARY KEY (MaChuyen),
  FOREIGN KEY (DiemBatDau) REFERENCES TinhThanh(MaTinh),
  FOREIGN KEY (DiemDen) REFERENCES TinhThanh(MaTinh)
);


CREATE TABLE Xe
(
  MaXe CHAR(5)NOT NULL,
  SoXe VARCHAR(10),
  MaChuyen CHAR(5),
  TenTaiXe NVARCHAR(50),
  LoaiXe CHAR(5),
  TrangThai NVARCHAR(20),
  MaHangXe CHAR(5),
  TGXuatPhat DATETIME,
  TGHuyVe TIME,
  Gia INT,
  PRIMARY KEY (MaXe),
  FOREIGN KEY (MaChuyen) REFERENCES Chuyen(MaChuyen),
  FOREIGN KEY (LoaiXe) REFERENCES LoaiXe(MaLoaiXe),
  FOREIGN KEY (MaHangXe) REFERENCES HangXe(MaHangXe)
);

CREATE TABLE Ghe
(
  SoGhe CHAR(2) NOT NULL,
  TrangThai NVARCHAR(20),
  Xe CHAR(5),
  PRIMARY KEY (SoGhe, Xe),
  FOREIGN KEY (Xe) REFERENCES Xe(MaXe)
);

CREATE TABLE Tram
(
  MaTram CHAR(5) NOT NULL,
  Chuyen CHAR(5) NOT NULL,
  TenTram NVARCHAR(50),
  MaTinh CHAR(5),
  PRIMARY KEY (MaTram, Chuyen),
  FOREIGN KEY (Chuyen) REFERENCES Chuyen(MaChuyen),
  FOREIGN KEY (MaTinh) REFERENCES TinhThanh(MaTinh)
);


CREATE TABLE CTDichVu
(
  MaDV CHAR(5) NOT NULL,
  Xe CHAR(5) NOT NULL,
  PRIMARY KEY (MaDV, Xe),
  FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV),
  FOREIGN KEY (Xe) REFERENCES Xe(MaXe)
);

CREATE TABLE Ve
(
  MaVe CHAR(5) NOT NULL,
  NgayDat DATE,
  TrangThai NVARCHAR(20),
  MaKhach CHAR(5) ,
  SoGhe CHAR(2),
  Xe CHAR(5),
  PRIMARY KEY (MaVe),
  FOREIGN KEY (MaKhach) REFERENCES Khach(MaKhach),
  FOREIGN KEY (SoGhe, Xe) REFERENCES Ghe(SoGhe, Xe)
);
Go
 -- Thêm dữ liệu cho bảng NhanVien
INSERT INTO NhanVien
VALUES
  ('NV001', N'Nguyễn Hoàng Tuấn', 'tuan123', 'Admin'),
  ('NV002', N'Phan Nguyễn Duy Hưng', 'hung123', 'user')

-- Thêm dữ liệu cho bảng Khach
INSERT INTO Khach (MaKhach, CCCD, TenKhachHang, Tuoi, SDT, TaiKhoan, MK)
VALUES
  ('KH001','123456789012', N'Nguyễn Văn A', 30,  '0901234567', 'user1', 'password1'),
  ('KH002', '987654321012', N'Trần Thị B', 25, '0912345678', 'user2', 'password2'),
  ('KH003', '111111111111', N'Lê Văn C', 28, '0987654321', 'user3', 'password3'),
  ('KH004', '222222222222', N'Phạm Thị D', 35, '0976543210', 'user4', 'password4'),
  ('KH005', '333333333333', N'Hồ Văn E', 40, '0965432109', 'user5', 'password5'),
  ('KH006', '444444444444', N'Mai Thị F', 22, '0954321098', 'user6', 'password6'),
  ('KH007', '555555555555', N'Lý Văn G', 28, '0943210987', 'user7', 'password7'),
  ('KH008', '666666666666', N'Đỗ Thị H', 32, '0932109876', 'user8', 'password8'),
  ('KH009', '777777777777', N'Vũ Văn I', 45, '0921098765', 'user9', 'password9'),
  ('KH010', '888888888888', N'Phan Thị K', 27, '0910987654', 'user10', 'password10');

-- Thêm dữ liệu cho bảng HangXe
INSERT INTO HangXe (MaHangXe, TenHangXe)
VALUES
  ('HX001', N'Phương Trang Sài Gòn'),
  ('HX002', N'Hùng Cường'),
  ('HX003', N'Huệ Nghĩa'),
  ('HX004', N'Tân Lập');

-- Thêm dữ liệu cho bảng TinhThanh
INSERT INTO TinhThanh (MaTinh, TenTinh)
VALUES
  ('TT001', N'TP.HCM'),
  ('TT002', N'Vũng Tàu'),
  ('TT003', N'Long An'),
  ('TT004', N'Cần Thơ'),
  ('TT005', N'Bà Rịa-Vũng Tàu'),
  ('TT006', N'Bạc Liêu'),
  ('TT007', N'An Giang'),
  ('TT008', N'Rạch Giá'),
  ('TT009', N'Bến Tre'),
  ('TT010', N'Tiền Giang'),
  ('TT011', N'Hậu Giang'),
  ('TT012', N'Sóc Trăng'),
  ('TT013', N'Cà Mau');


-- Thêm dữ liệu cho bảng DichVu
INSERT INTO DichVu (MaDV, TenDV)
VALUES
  ('DV001', N'Phục vụ ăn sáng'),
  ('DV002', N'Phụ vụ nước uống'),
  ('DV003', N'Phụ vụ khăn');


--Thêm dữ liệu cho bảng loại xe
INSERT INTO LoaiXe (MaLoaiXe, TenLoaiXe, SoGhe)
VALUES
  ('LX001', N'Xe 45 chổ 1 tầng', 45),
  ('LX002', N'Xe 45 chổ 2 tầng', 45),
  ('LX003', N'Xe 16 chổ', 16),
  ('LX004', N'Xe 17 chổ', 17),
  ('LX005', N'Xe 29 chổ', 29);



-- Thêm dữ liệu cho bảng Chuyen
INSERT INTO Chuyen (MaChuyen, TenChuyen, DiemBatDau, DiemDen, TGChuyen)
VALUES
  ('CH001', N'TP.HCM - Vũng Tàu', 'TT001', 'TT002', '4:30'),
  ('CH002', N'Long A - Cần Thơ', 'TT003', 'TT004', '3:30'),
  ('CH003', N'Tiền Giang - An Giang', 'TT010', 'TT007', '2:10'),
  ('CH004', N'Tiền Giang - Long An', 'TT010', 'TT003', '1:50'),
  ('CH005', N'TP.HCM - Cần Thơ', 'TT001', 'TT004', '2:20'),
  ('CH006', N'Vũng Tàu - Bà Rịa-Vũng Tàu', 'TT002', 'TT005', '3:30'),
  ('CH007', N'Sóc Trăng - Bạc Liêu', 'TT012', 'TT006', '4:00'),
  ('CH008', N'TP.HCM - An Giang', 'TT001', 'TT007', '1:30'),
  ('CH009', N'Cà Mau - Rạch Giá', 'TT013', 'TT008', '1:00'),
  ('CH010', N'TP.HCM - Bến Tre', 'TT001', 'TT009', '2:00');


-- Thêm dữ liệu cho bảng Xe
INSERT INTO Xe (MaXe, SoXe,MaChuyen, TenTaiXe, LoaiXe, TrangThai, MaHangXe, TGXuatPhat, TGHuyVe, Gia)
VALUES
  ('XE001','43A-1234','CH001', N'Nguyễn Văn Tài', 'LX001', N'Hoạt động', 'HX001', '2023-10-14', '10:00', 100000),
  ('XE002','75B-5678','CH001', N'Trần Thị Hương','LX002', N'Hoạt động', 'HX002','2023-10-14', '10:00', 150000),
  ('XE003','29C-9876','CH001', N'Lê Văn Minh','LX003', N'Hoạt động', 'HX002','2023-11-23', '10:00',  180000),
  ('XE004','58D-5432','CH001', N'Phạm Thị Ngọc','LX004', N'Hoạt động', 'HX004','2023-11-23', '10:30',  120000),
  ('XE005','12E-8765','CH002', N'Hồ Văn Hoàng', 'LX005', N'Hoạt động', 'HX004','2023-11-23', '8:00',  90000),
  ('XE006','64F-4321','CH002', N'Mai Thị Phương','LX003', N'Hoạt động', 'HX003','2023-11-23', '12:30',  100000),
  ('XE007','37G-8765','CH002', N'Lý Văn Tùng','LX004', N'Hoạt động', 'HX001','2023-12-25', '9:30',  200000),
  ('XE008','89H-4321','CH002', N'Đỗ Thị Mai', 'LX005', N'Hoạt động', 'HX002','2023-12-23', '5:30',  150000),
  ('XE009','56I-9876','CH003', N'Vũ Văn Thắng', 'LX003', N'Hoạt động', 'HX003','2023-12-23', '7:00',  150000),
  ('XE010','21J-1234','CH003', N'Phan Thị Lan', 'LX004', N'Hoạt động', 'HX004', '2023-12-23', '8:00', 180000),
  ('XE011','48K-5678','CH004', N'Trần Văn Khôi', 'LX005', N'Hoạt động', 'HX002', '2023-12-23', '4:00', 150000),
  ('XE012','93L-9876','CH004', N'Nguyễn Thị Bích', 'LX003', N'Hoạt động', 'HX001','2023-12-26', '6:30',  110000);

-- Thêm dữ liệu cho bảng Ghe
INSERT INTO Ghe (SoGhe, TrangThai, Xe)
VALUES
  ('01', N'Trống', 'XE001'),
  ('02', N'Đã đặt', 'XE002');

-- Thêm dữ liệu cho bảng Tram
INSERT INTO Tram (MaTram, Chuyen, TenTram, MaTinh)
VALUES
  ('TM001','CH001', N'Trạm 1', 'TT001'),
  ('TM002','CH002', N'Trạm 2', 'TT002');

-- Thêm dữ liệu cho bảng CTDichVu
INSERT INTO CTDichVu (MaDV, Xe)
VALUES
  ('DV001', 'XE001'),
  ('DV002', 'XE002');

-- Thêm dữ liệu cho bảng Ve
INSERT INTO Ve (MaVe, NgayDat, TrangThai, MaKhach, SoGhe, Xe)
VALUES
  ('VE001', '2023-10-24 12:00:00 ', N'Đã đặt', 'KH001', '01', 'XE001'),
  ('VE002', '2023-10-25 11:00:00', N'Đã đặt', 'KH002', '01', 'XE002'),
  ('VE003', '2023-10-26 10:00:00', N'Đã đặt', 'KH001', '02', 'XE001'),
  ('VE004', '2023-10-25 9:00:00', N'Đã đặt', 'KH002', '03', 'XE001'),
  ('VE005', '2023-10-26 12:00:00', N'Đã đặt', 'KH001', '04', 'XE001'),
  ('VE006', '2023-10-28 7:00:00', N'Đã đặt', 'KH002', '02', 'XE002'),
  ('VE007', '2023-10-27 8:00:00', N'Đã đặt', 'KH001', '01', 'XE001'),
  ('VE008', '2023-10-29 7:30:00', N'Đã đặt', 'KH002', '02', 'XE002'),
  ('VE009', '2023-10-27 11:20:00', N'Đã đặt', 'KH001', '01', 'XE001'),
  ('VE010', '2023-10-29 10:10:00', N'Đã đặt', 'KH002', '02', 'XE002'),
  ('VE011', '2023-11-24 7:30:00', N'Đã đặt', 'KH001', '01', 'XE001'),
  ('VE011', '2023-11-24 8:00:00', N'Đã đặt', 'KH001', '01', 'XE001'),
  ('VE012', '2023-10-25 9:40:00', N'Đã đặt', 'KH002', '05', 'XE002');






 

