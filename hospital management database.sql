-- ==========================================
-- TẠO DATABASE "QuanLyBenhNhan"
-- ==========================================
CREATE DATABASE QuanLyBenhNhan;
GO
USE QuanLyBenhNhan;
GO

-- ==========================================
-- XÓA CÁC BẢNG CŨ (nếu tồn tại)
-- ==========================================
IF OBJECT_ID('DieuTri', 'U') IS NOT NULL DROP TABLE DieuTri;       -- Bảng điều trị
IF OBJECT_ID('HoSoBenhAn', 'U') IS NOT NULL DROP TABLE HoSoBenhAn; -- Bảng hồ sơ bệnh án
IF OBJECT_ID('PhongBenh', 'U') IS NOT NULL DROP TABLE PhongBenh;   -- Bảng phòng bệnh
IF OBJECT_ID('BacSi', 'U') IS NOT NULL DROP TABLE BacSi;           -- Bảng bác sĩ
IF OBJECT_ID('ChuyenKhoa', 'U') IS NOT NULL DROP TABLE ChuyenKhoa; -- Bảng chuyên khoa
IF OBJECT_ID('BenhNhan', 'U') IS NOT NULL DROP TABLE BenhNhan;     -- Bảng bệnh nhân
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL DROP TABLE TaiKhoan;     -- Bảng tài khoản đăng nhập
GO

-- ==========================================
-- TẠO BẢNG BỆNH NHÂN
-- ==========================================
CREATE TABLE BenhNhan (
    BenhNhanID INT PRIMARY KEY IDENTITY,                -- Khóa chính, tự tăng
    HoTen NVARCHAR(100),                                -- Họ tên bệnh nhân
    NgaySinh DATE,                                      -- Ngày sinh
    GioiTinh NVARCHAR(10),                              -- Giới tính (Nam/Nữ)
    SDT CHAR(10) CHECK (SDT NOT LIKE '%[^0-9]%'),       -- SĐT (chỉ cho phép 10 số)
    CCCD CHAR(12) CHECK (CCCD NOT LIKE '%[^0-9]%'),     -- CCCD (12 số)
    TenThanNhan NVARCHAR(100),                          -- Tên thân nhân liên hệ
    SDTThanNhan CHAR(10) CHECK (SDTThanNhan NOT LIKE '%[^0-9]%') -- SĐT của thân nhân
);

-- ==========================================
-- TẠO BẢNG CHUYÊN KHOA
-- ==========================================
CREATE TABLE ChuyenKhoa (
    ChuyenKhoaID INT PRIMARY KEY IDENTITY,           -- Mã chuyên khoa
    TenChuyenKhoa NVARCHAR(100) UNIQUE,              -- Tên chuyên khoa (duy nhất)
    MoTa NVARCHAR(255)                               -- Mô tả về chuyên khoa
);

-- ==========================================
-- TẠO BẢNG BÁC SĨ
-- ==========================================
CREATE TABLE BacSi (
    BacSiID INT PRIMARY KEY IDENTITY,                                -- Mã bác sĩ
    HoTen NVARCHAR(100),                                             -- Họ tên
    ChuyenKhoaID INT FOREIGN KEY REFERENCES ChuyenKhoa(ChuyenKhoaID), -- Khóa ngoại đến bảng ChuyenKhoa
    SDT CHAR(10) CHECK (SDT NOT LIKE '%[^0-9]%'),                    -- SĐT
    Email VARCHAR(100),                                              -- Email
    TrinhDo NVARCHAR(50)                                             -- Trình độ chuyên môn
);

-- ==========================================
-- TẠO BẢNG HỒ SƠ BỆNH ÁN
-- ==========================================
CREATE TABLE HoSoBenhAn (
    HoSoID INT PRIMARY KEY IDENTITY,                              -- Mã hồ sơ
    BenhNhanID INT FOREIGN KEY REFERENCES BenhNhan(BenhNhanID),   -- FK đến bệnh nhân
    NgayLap DATE,                                                 -- Ngày lập hồ sơ
    ChanDoan NVARCHAR(255),                                       -- Chẩn đoán bệnh
    TrieuChung NVARCHAR(255),                                     -- Triệu chứng
    TienSuBenh NVARCHAR(255) DEFAULT N'Không',                    -- Tiền sử bệnh (mặc định "Không")
    GhiChu NVARCHAR(255)                                          -- Ghi chú thêm
);

-- ==========================================
-- TẠO BẢNG ĐIỀU TRỊ
-- ==========================================
CREATE TABLE DieuTri (
    DieuTriID INT PRIMARY KEY IDENTITY,                               -- Mã điều trị
    HoSoID INT FOREIGN KEY REFERENCES HoSoBenhAn(HoSoID),             -- FK đến hồ sơ bệnh án
    BacSiID INT FOREIGN KEY REFERENCES BacSi(BacSiID),                -- FK đến bác sĩ điều trị
    NgayDieuTri DATE,                                                 -- Ngày điều trị
    PhuongPhap NVARCHAR(255),                                         -- Phương pháp điều trị
    Thuoc NVARCHAR(255),                                              -- Tên thuốc sử dụng
    ChiPhi DECIMAL(18, 2) CHECK (ChiPhi >= 0),                        -- Chi phí điều trị
    KetQua NVARCHAR(255) NULL                                         -- Kết quả (có thể NULL)
);

-- ==========================================
-- TẠO BẢNG PHÒNG BỆNH
-- ==========================================
CREATE TABLE PhongBenh (
    PhongBenhID INT PRIMARY KEY IDENTITY,						-- Khóa chính, tự động tăng (ID duy nhất cho mỗi bản ghi phòng bệnh)
    BenhNhanID INT FOREIGN KEY REFERENCES BenhNhan(BenhNhanID), -- Khóa ngoại tham chiếu tới bảng BenhNhan (bệnh nhân)
    NgayNhapVien DATE,											-- Ngày bệnh nhân nhập viện (bắt buộc)
    NgayXuatVien DATE NULL,										-- Ngày bệnh nhân xuất viện (có thể để NULL nếu chưa xuất viện)
    PhongSo NVARCHAR(10),										-- Số phòng bệnh
    GiuongSo NVARCHAR(10),										-- Số giường trong phòng bệnh
    -- Ràng buộc kiểm tra đảm bảo ngày xuất viện phải lớn hơn hoặc bằng ngày nhập viện
    CONSTRAINT chk_NgayXuatVien CHECK (NgayXuatVien IS NULL OR NgayXuatVien >= NgayNhapVien)
);


-- ==========================================
-- TẠO BẢNG TÀI KHOẢN ĐĂNG NHẬP
-- ==========================================
CREATE TABLE TaiKhoan (
    TaiKhoanID INT PRIMARY KEY IDENTITY,                              -- Mã tài khoản
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,                         -- Tên đăng nhập
    MatKhau NVARCHAR(100) NOT NULL,                                   -- Mật khẩu (dạng text, không hash)
    VaiTro TINYINT NOT NULL DEFAULT 1 CHECK (VaiTro IN (0, 1))        -- Vai trò: 0 = Admin, 1 = User (mặc định)
);


-- ================================
-- CHUYÊN KHOA
-- ================================
INSERT INTO ChuyenKhoa (TenChuyenKhoa, MoTa)
VALUES 
(N'Nội khoa', N'Khám và điều trị bệnh nội tạng'),
(N'Tim mạch', N'Điều trị các bệnh lý về tim'),
(N'Ngoại khoa', N'Phẫu thuật, chấn thương');

-- ================================
-- BỆNH NHÂN
-- ================================
INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SDT, CCCD, TenThanNhan, SDTThanNhan)
VALUES
(N'Nguyễn Văn A', '1980-01-15', N'Nam', '0909123456', '123456789012', N'Nguyễn Văn B', '0911223344'),
(N'Trần Thị B', '1990-05-10', N'Nữ', '0911223344', '987654321098', N'Trần Văn C', '0909888777');

-- ================================
-- BÁC SĨ
-- ================================
INSERT INTO BacSi (HoTen, ChuyenKhoaID, SDT, Email, TrinhDo)
VALUES
(N'BS. Lê Minh Tuấn', 1, '0909000001', 'tuanlm@benhvien.vn', N'Tiến sĩ'),
(N'BS. Nguyễn Thị Hoa', 2, '0909000002', 'hoant@benhvien.vn', N'Thạc sĩ');

-- ================================
-- HỒ SƠ BỆNH ÁN
-- ================================
INSERT INTO HoSoBenhAn (BenhNhanID, NgayLap, ChanDoan, TrieuChung, TienSuBenh, GhiChu)
VALUES
(1, '2025-10-01', N'Viêm phổi', N'Sốt, ho, khó thở', N'Hen suyễn', N'Cần theo dõi sát'),
(2, '2025-10-03', N'Rối loạn nhịp tim', N'Đau ngực, mệt', N'Tăng huyết áp', N'Theo dõi tim mạch');

-- ================================
-- ĐIỀU TRỊ
-- ================================
INSERT INTO DieuTri (HoSoID, BacSiID, NgayDieuTri, PhuongPhap, Thuoc, ChiPhi, KetQua)
VALUES
(1, 1, '2025-10-02', N'Tiêm kháng sinh', N'Augmentin', 150000, N'Cải thiện tốt'),
(2, 2, '2025-10-04', N'Dùng thuốc điều hòa tim', N'Metoprolol', 200000, N'Ổn định');

-- ================================
-- PHÒNG BỆNH
-- ================================
INSERT INTO PhongBenh (BenhNhanID, NgayNhapVien, NgayXuatVien, PhongSo, GiuongSo)
VALUES
(1, '2025-10-01', '2025-10-06', N'101', N'01'),
(2, '2025-10-03', NULL, N'102', N'02');

-- ================================
-- TÀI KHOẢN
-- ================================
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro)
VALUES
(N'admin', N'admin123', 0),
(N'user1', N'user123', 1);


-- ==========================================
-- KIỂM TRA DỮ LIỆU
-- ==========================================

SELECT * FROM BenhNhan;
SELECT * FROM BacSi;
SELECT * FROM ChuyenKhoa;
SELECT * FROM PhongBenh;
SELECT * FROM HoSoBenhAn;
SELECT * FROM DieuTri;
SELECT * FROM TaiKhoan;

-- ==========================================
-- LƯU Ý
-- ==========================================

-- Xóa dữ liệu theo thứ tự tránh vi phạm FK:
-- DELETE FROM DieuTri;
-- DELETE FROM HoSoBenhAn;
-- DELETE FROM PhongBenh;
-- DELETE FROM BacSi;
-- DELETE FROM BenhNhan;
-- DELETE FROM TaiKhoan;

-- DBCC CHECKIDENT ('TaiKhoan', RESEED, 0);

-- Cẩn thận khi xóa database, thao tác này sẽ mất toàn bộ dữ liệu:
-- ALTER DATABASE QuanLyBenhNhan SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
-- DROP DATABASE QuanLyBenhNhan;
