-- Tạo cơ sở dữ liệu
CREATE DATABASE QLSV;

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QLSV;

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa CHAR(4) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL,
    TinhTrang BIT NOT NULL
);

-- Tạo bảng Lop với khóa ngoại tham chiếu đến Khoa
CREATE TABLE Lop (
    MaLop CHAR(6) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    MaKhoa CHAR(4) NOT NULL,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Tạo bảng SinhVien với khóa ngoại tham chiếu đến Lop
CREATE TABLE SinhVien (
    MaSV CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh BIT NOT NULL,
    QueQuan NVARCHAR(100) NOT NULL,
    MaLop CHAR(6) NOT NULL,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc CHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
);

-- Tạo bảng GiangVien
CREATE TABLE GiangVien (
    MaGV CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    MaKhoa CHAR(4) NOT NULL,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Tạo bảng DangKyHoc để quản lý việc đăng ký môn học của sinh viên
CREATE TABLE DangKyHoc (
    MaDK INT PRIMARY KEY IDENTITY(1,1),
    MaSV CHAR(10) NOT NULL,
    MaMonHoc CHAR(10) NOT NULL,
    MaGV CHAR(10) NOT NULL,
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc),
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV)
);

-- Tạo bảng Diem để lưu điểm của sinh viên
CREATE TABLE Diem (
    MaSinhVien CHAR(10) NOT NULL,
    MaMonHoc CHAR(10) NOT NULL,
    Diem FLOAT NOT NULL,
    PRIMARY KEY (MaSinhVien, MaMonHoc),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);

INSERT INTO Khoa (MaKhoa, TenKhoa, TinhTrang) VALUES 
('CNTT', N'Khoa CNTT', 1),
('KeT', N'Khoa Kế Toán', 1),
('TTNT', N'Khoa Trí Tuệ Nhân Tạo', 1),
('LG', N'Khoa Logistic', 1),
('NNA', N'Khoa Ngôn Ngữ Anh', 1),
('MKT', N'Khoa Marketing', 1),
('CX', N'Khoa Công Trình', 1),
('KTe', N'Khoa Kinh Tế', 1),
('N', N'Khoa Kỹ Thuật Tài Nguyên Nước', 1),
('C', N'Khoa Công Trình', 1);

-- Chèn dữ liệu mẫu vào bảng Lop
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES 
('64CNTT', N'Lớp 64 Công nghệ thông tin', 'CNTT'),
('63CNTT', N'Lớp 63 Công nghệ thông tin', 'CNTT'),
('65CNTT', N'Lớp 65 Công nghệ thông tin', 'CNTT'),
('62CNTT', N'Lớp 62 Công nghệ thông tin', 'CNTT'),
('65TTNT', N'Lớp 65 Trí tuệ nhân tạo', 'TTNT'),
('64NNA', N'Lớp 64 Ngôn ngữ anh', 'NNA'),
('65NNA', N'Lớp 65 Ngôn ngữ anh', 'NNA'),
('63NNA', N'Lớp 63 Ngôn ngữ anh', 'NNA'),
('62NNA', N'Lớp 62 Ngôn ngữ anh', 'NNA'),
('65KeT', N'Lớp 65 Kế toán', 'KeT'),
('64KeT', N'Lớp 64 Kế toán', 'KeT'),
('63KeT', N'Lớp 63 Kế toán', 'KeT'),
('62KeT', N'Lớp 62 Kế toán', 'KeT'),
('65LG', N'Lớp 65 Logistic', 'LG'),
('64LG', N'Lớp 64 Logistic', 'LG'),
('63LG', N'Lớp 63 Logistic', 'LG'),
('62LG', N'Lớp 62 Logistic', 'LG')
;

-- Chèn dữ liệu mẫu vào bảng SinhVien
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, QueQuan, MaLop) VALUES 
('SV001', N'Nguyễn Văn Hải', '2004-01-01', 1, N'Hà Nội', '64CNTT'),
('SV002', N'Trần Văn Linh', '2000-02-02', 0, N'Hải Phòng', '63LG'),
('SV003', N'Lê Thị Bích', '2002-03-03', 1, N'Đà Nẵng', '65TTNT'),
('SV004', N'Phạm Minh Tuấn', '2001-04-04', 1, N'Huế', '64NNA'),
('SV005', N'Ngô Thị Lan', '2003-05-05', 0, N'Hà Nội', '65KeT'),
('SV006', N'Vũ Hoàng Nam', '2004-06-06', 1, N'Sài Gòn', '62LG'),
('SV007', N'Trần Văn Cường', '2002-07-07', 1, N'Cần Thơ', '63KeT'),
('SV008', N'Lê Thị Thảo', '2001-08-08', 0, N'Hà Nam', '64LG'),
('SV009', N'Phạm Thị Mai', '2000-09-09', 0, N'Ninh Bình', '65NNA'),
('SV010', N'Nguyễn Tiến Dũng', '2004-10-10', 1, N'Hà Giang', '64CNTT'),
('SV011', N'Trần Đức Anh', '2003-11-11', 1, N'Quảng Ninh', '65TTNT'),
('SV012', N'Vũ Thị Hạnh', '2002-12-12', 0, N'Thái Bình', '63LG'),
('SV013', N'Nguyễn Văn Đức', '2001-01-13', 1, N'Tuyên Quang', '62KeT'),
('SV014', N'Phạm Văn Bình', '2000-02-14', 1, N'Phú Thọ', '65KeT'),
('SV015', N'Trần Thị Hằng', '2002-03-15', 0, N'Hà Nội', '64NNA'),
('SV016', N'Lê Hoàng Anh', '2003-04-16', 1, N'Bắc Giang', '63CNTT'),
('SV017', N'Nguyễn Minh Hoàng', '2004-05-17', 1, N'Bắc Ninh', '62CNTT'),
('SV018', N'Trần Văn Đạt', '2000-06-18', 1, N'Hải Dương', '64TTNT'),
('SV019', N'Phạm Minh Hòa', '2001-07-19', 1, N'Hưng Yên', '65LG'),
('SV020', N'Vũ Thị Mai', '2002-08-20', 0, N'Nghệ An', '64KeT'),
('SV021', N'Lê Văn Long', '2000-09-21', 1, N'Hà Tĩnh', '65NNA'),
('SV022', N'Nguyễn Văn Hải', '2001-10-22', 1, N'Quảng Bình', '64CNTT'),
('SV023', N'Trần Văn Tài', '2003-11-23', 1, N'Quảng Trị', '63KeT'),
('SV024', N'Phạm Thị Hoa', '2004-12-24', 0, N'Thừa Thiên Huế', '65LG'),
('SV025', N'Ngô Thị Lan', '2000-01-25', 0, N'Bình Định', '64NNA'),
('SV026', N'Vũ Hoàng Hải', '2001-02-26', 1, N'Quảng Ngãi', '63CNTT'),
('SV027', N'Nguyễn Văn Bình', '2002-03-27', 1, N'Phú Yên', '62KeT'),
('SV028', N'Trần Thị Lan', '2003-04-28', 0, N'Khánh Hòa', '65KeT'),
('SV029', N'Phạm Văn Đức', '2004-05-29', 1, N'Ninh Thuận', '64TTNT'),
('SV030', N'Lê Thị Mai', '2000-06-30', 0, N'Bình Thuận', '62LG'),
('SV031', N'Nguyễn Văn Hoàng', '2001-07-31', 1, N'Kon Tum', '65NNA'),
('SV032', N'Trần Văn Đạt', '2002-08-01', 1, N'Gia Lai', '64CNTT'),
('SV033', N'Phạm Minh Hòa', '2003-09-02', 1, N'Đắk Lắk', '65LG'),
('SV034', N'Ngô Thị Hoa', '2004-10-03', 0, N'Đắk Nông', '63KeT'),
('SV035', N'Vũ Hoàng Nam', '2000-11-04', 1, N'Lâm Đồng', '64NNA'),
('SV036', N'Nguyễn Tiến Dũng', '2001-12-05', 1, N'Bình Phước', '65KeT'),
('SV037', N'Trần Văn Cường', '2002-01-06', 1, N'Tây Ninh', '64LG'),
('SV038', N'Phạm Thị Hằng', '2003-02-07', 0, N'Bình Dương', '65TTNT'),
('SV039', N'Lê Hoàng Anh', '2004-03-08', 1, N'Đồng Nai', '63NNA'),
('SV040', N'Nguyễn Văn Bình', '2000-04-09', 1, N'Bà Rịa-Vũng Tàu', '62CNTT'),
('SV041', N'Trần Văn Linh', '2001-05-10', 1, N'TP.HCM', '64KeT'),
('SV042', N'Phạm Minh Hòa', '2002-06-11', 1, N'Long An', '65LG'),
('SV043', N'Vũ Thị Lan', '2003-07-12', 0, N'Tiền Giang', '63CNTT'),
('SV044', N'Ngô Văn Hải', '2004-08-13', 1, N'Bến Tre', '62KeT'),
('SV045', N'Nguyễn Thị Mai', '2000-09-14', 0, N'Travinh', '65KeT');


-- Chèn dữ liệu mẫu vào bảng MonHoc
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES 
('MH01', N'Tin học cơ sở'),
('MH02', N'Trí tuệ nhân tạo'),
('MH03', N'Mạng máy tính');

-- Chèn dữ liệu mẫu vào bảng GiangVien
INSERT INTO GiangVien (MaGV, HoTen, MaKhoa) VALUES 
('GV001', N'Tống Thị Nhung', 'CNTT'),
('GV002', N'Nguyễn Thị Kim Phụng', 'CNTT'),
('GV003', N'Viên Thanh Nhã', 'CNTT'),
('GV004', 'Phạm Hồng Xuân', 'CNTT'),
('GV005', N'Trần Ngọc Dân', 'CNTT'),
('GV006', N'Phan Thị Tài', 'CNTT'),
('GV007', N'Vũ Thị Hạnh', 'CNTT'),
('GV008', N'Huỳnh Hoài An', 'NNA'),
('GV009', N'Mai Thị Xuân', 'KeT'),
('GV010', N'Nguyễn Thị Ngân', 'NNA'),
('GV011', N'Nguyễn Thị Thu Hương', 'KTe'),
('GV012', N'Đường Thành Tân', 'CX')
;

-- Chèn dữ liệu mẫu vào bảng DangKyHoc
INSERT INTO DangKyHoc (MaSV, MaMonHoc, MaGV) VALUES 
('SV001', 'MH01', 'GV001'),
('SV002', 'MH02', 'GV002'),
('SV003', 'MH03', 'GV003');

-- Chèn dữ liệu mẫu vào bảng Diem
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES 
('SV001', 'MH01', 8.5),
('SV002', 'MH02', 9.0),
('SV003', 'MH03', 7.5);
