-- ==========================================
-- TẠO DATABASE
-- ==========================================
CREATE DATABASE QuanLyBenhNhan;
GO
USE QuanLyBenhNhan;
GO


-- ==========================================
-- XÓA BẢNG CŨ (nếu có) ĐỂ LÀM LẠI TỪ ĐẦU
-- (làm theo thứ tự từ bảng con -> bảng cha để tránh lỗi FK)
-- ==========================================
IF OBJECT_ID('Thuoc', 'U') IS NOT NULL DROP TABLE Thuoc;
IF OBJECT_ID('DieuTri', 'U') IS NOT NULL DROP TABLE DieuTri;
IF OBJECT_ID('HoSoBenhAn', 'U') IS NOT NULL DROP TABLE HoSoBenhAn;
IF OBJECT_ID('PhongKham', 'U') IS NOT NULL DROP TABLE PhongKham;
IF OBJECT_ID('BacSi', 'U') IS NOT NULL DROP TABLE BacSi;
IF OBJECT_ID('BenhNhan', 'U') IS NOT NULL DROP TABLE BenhNhan;
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL DROP TABLE TaiKhoan;
IF OBJECT_ID('ThanNhan', 'U') IS NOT NULL DROP TABLE ThanNhan;
GO


-- ==========================================
-- BẢNG 1: THANNHAN - Lưu thông tin thân nhân
-- ==========================================
CREATE TABLE ThanNhan (
    MaTN INT IDENTITY PRIMARY KEY,				-- Mã thân nhân
    HoTen NVARCHAR(50) NOT NULL,				-- Họ tên thân nhân
    SDT NVARCHAR(15) UNIQUE NOT NULL			-- Số điện thoại
);

-- ==========================================
-- BẢNG 2: BENHNHAN - Lưu thông tin bệnh nhân
-- ==========================================
CREATE TABLE BenhNhan (
    MaBN INT IDENTITY PRIMARY KEY,              -- Mã bệnh nhân
    HoTen NVARCHAR(100) NOT NULL,               -- Họ tên bệnh nhân
    NgaySinh DATE,								-- Ngày sinh
    GioiTinh NVARCHAR(10),						-- Giới tính
    CCCD NVARCHAR(12) UNIQUE,                   -- Căn cước công dân
    DiaChi NVARCHAR(200) NOT NULL,              -- Địa chỉ
    SDT NVARCHAR(15) NOT NULL,					-- Số điện thoại
    MaTN INT FOREIGN KEY REFERENCES ThanNhan(MaTN) -- Liên kết với Thân Nhân
);


-- ==========================================
-- BẢNG 3: BACSI - Lưu thông tin bác sĩ
-- ==========================================
CREATE TABLE BacSi (
    MaBS INT IDENTITY PRIMARY KEY,              -- Mã bác sĩ
    HoTen NVARCHAR(100) NOT NULL,               -- Họ tên
    ChuyenKhoa NVARCHAR(100),					-- Chuyên khoa
    SDT NVARCHAR(15) UNIQUE                     -- Số điện thoại
);



-- ==========================================
-- BẢNG 4: PHONGKHAM - Quản lý các phòng khám
-- ==========================================
CREATE TABLE PhongKham (
    MaPK INT IDENTITY PRIMARY KEY,              -- Mã phòng khám
    TenPhong NVARCHAR(100) UNIQUE,              -- Tên phòng
    ViTri NVARCHAR(100)                         -- Vị trí
);



-- ==========================================
-- BẢNG 5: HOSOBENHAN - Thông tin hồ sơ khám bệnh
-- ==========================================
CREATE TABLE HoSoBenhAn (
    MaHS INT IDENTITY PRIMARY KEY,              -- Mã hồ sơ bệnh án
    MaBN INT FOREIGN KEY REFERENCES BenhNhan(MaBN), -- Liên kết bệnh nhân
    MaBS INT FOREIGN KEY REFERENCES BacSi(MaBS),    -- Liên kết bác sĩ
    MaPK INT FOREIGN KEY REFERENCES PhongKham(MaPK),-- Liên kết phòng khám
    NgayVaoVien DATE DEFAULT GETDATE(),				-- Ngày vào viện (Nếu không nhập, hệ thống sẽ tự lấy ngày hiện tại.)
	NgayRaVien DATE,								-- Ngày ra viện
    TrieuChung NVARCHAR(200),                   -- Triệu chứng
    ChanDoan NVARCHAR(200)                      -- Chẩn đoán
);



-- ==========================================
-- BẢNG 6: DIEUTRI - Quá trình điều trị
-- ==========================================
CREATE TABLE DieuTri (
    MaDT INT IDENTITY PRIMARY KEY,              -- Mã điều trị
    NgayBatDau DATE DEFAULT GETDATE(),			-- Ngày bắt đầu (Nếu không nhập, hệ thống sẽ tự lấy ngày hiện tại.)
    NgayKetThuc DATE,							-- Ngày kết thúc
    PhuongPhap NVARCHAR(200),                   -- Phương pháp điều trị
    KetQua NVARCHAR(100),                       -- Kết quả (Khỏi, Đang điều trị…)
    GhiChu NVARCHAR(500),						-- Ghi chú
	MaHS INT FOREIGN KEY REFERENCES HoSoBenhAn(MaHS), -- Liên kết hồ sơ
	MaBS INT FOREIGN KEY REFERENCES BacSi(MaBS)		--Liên kết bác sĩ
);



-- ==========================================
-- BẢNG 7: THUOC - Quản lý & kê thuốc
-- (đơn giản: thuốc kê cho từng hồ sơ bệnh án)
-- ==========================================
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY PRIMARY KEY,               -- Mã thuốc
    TenThuoc NVARCHAR(100) NOT NULL,                -- Tên thuốc
    DonVi NVARCHAR(50),                             -- Đơn vị (viên, ống…)
    Gia DECIMAL(18,2),                              -- Giá
    SoLuong INT CHECK (SoLuong >= 0),               -- Số lượng kê
    LieuDung NVARCHAR(200),                         -- Liều dùng
    MaHS INT FOREIGN KEY REFERENCES HoSoBenhAn(MaHS), -- Liên kết hồ sơ bệnh án
	MaBN INT FOREIGN KEY REFERENCES BenhNhan(MaBN)		--Liết kết bệnh nhân
);



-- ==========================================
-- BẢNG 8: TAIKHOAN - Đăng nhập & phân quyền
-- ==========================================
CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY PRIMARY KEY,                 -- Mã tài khoản
    TenDangNhap NVARCHAR(50) UNIQUE,               -- Username
    MatKhau NVARCHAR(100) NOT NULL,                -- Password
);

INSERT INTO TaiKhoan (TenDangNhap, MatKhau)
VALUES (N'admin', N'123');


-- ==========================================
-- KIỂM TRA DỮ LIỆU
-- ==========================================
SELECT * FROM BenhNhan;     -- Xem danh sách bệnh nhân
SELECT * FROM ThanNhan		-- Xem danh sách thân nhân
SELECT * FROM BacSi;        -- Xem danh sách bác sĩ
SELECT * FROM PhongKham;    -- Xem danh sách phòng khám
SELECT * FROM HoSoBenhAn;   -- Xem hồ sơ bệnh án
SELECT * FROM DieuTri;      -- Xem quá trình điều trị
SELECT * FROM Thuoc;        -- Xem thuốc đã kê
SELECT * FROM TaiKhoan;     -- Xem tài khoản login/logout

-- ==========================================
-- XÓA BẢNG
-- ==========================================
DELETE FROM Thuoc;
DELETE FROM DieuTri;
DELETE FROM HoSoBenhAn;
DELETE FROM PhongKham;
DELETE FROM BacSi;
DELETE FROM BenhNhan;
-- Xoá toàn bộ dữ liệu
DELETE FROM TaiKhoan;
-- Reset lại IDENTITY về 1
DBCC CHECKIDENT ('TaiKhoan', RESEED, 0);



-- Ngắt hết các kết nối đang sử dụng database
ALTER DATABASE QuanLyBenhNhan 
SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

-- Xóa database
DROP DATABASE QuanLyBenhNhan;


