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
-- BẢNG BỆNH NHÂN
-- ==========================================
CREATE TABLE BenhNhan (
    BenhNhanID VARCHAR(10) PRIMARY KEY,       -- Khóa chính, định danh duy nhất cho mỗi bệnh nhân
    HoTen NVARCHAR(100),                      -- Họ tên bệnh nhân
    NgaySinh DATE,                            -- Ngày sinh
    DiaChi NVARCHAR(100),                     -- Địa chỉ
    GioiTinh NVARCHAR(10),                    -- Giới tính (Nam/Nữ)
    SDT CHAR(10) CHECK (SDT NOT LIKE '%[^0-9]%'), -- SĐT: chỉ cho phép 10 chữ số
    CCCD CHAR(12) CHECK (CCCD NOT LIKE '%[^0-9]%'), -- CCCD: chỉ cho phép 12 chữ số
    TenThanNhan NVARCHAR(100),                -- Tên thân nhân liên hệ
    SDTThanNhan CHAR(10) CHECK (SDTThanNhan NOT LIKE '%[^0-9]%') -- SĐT thân nhân
);

-- ==========================================
-- BẢNG CHUYÊN KHOA
-- ==========================================
CREATE TABLE ChuyenKhoa (
    ChuyenKhoaID VARCHAR(10) PRIMARY KEY,    -- Khóa chính cho chuyên khoa
    TenChuyenKhoa NVARCHAR(100) UNIQUE,      -- Tên chuyên khoa, duy nhất
    MoTa NVARCHAR(255)                        -- Mô tả về chuyên khoa
);

-- ==========================================
-- BẢNG BÁC SĨ
-- ==========================================
CREATE TABLE BacSi (
    BacSiID VARCHAR(10) PRIMARY KEY,        -- Khóa chính bác sĩ
    HoTen NVARCHAR(100),                     -- Họ tên bác sĩ
    ChuyenKhoaID VARCHAR(10),                -- Mã chuyên khoa mà bác sĩ thuộc về
    SDT CHAR(10) CHECK (SDT NOT LIKE '%[^0-9]%'), -- SĐT bác sĩ
    Email VARCHAR(100),                      -- Email
    TrinhDo NVARCHAR(50),                    -- Trình độ chuyên môn
    -- Ràng buộc khóa ngoại: liên kết đến bảng ChuyenKhoa
    CONSTRAINT FK_BacSi_ChuyenKhoa FOREIGN KEY (ChuyenKhoaID)
        REFERENCES ChuyenKhoa(ChuyenKhoaID)
        -- Lưu ý: Không dùng ON DELETE CASCADE ở đây, tránh xóa bác sĩ khi xóa chuyên khoa
);

-- ==========================================
-- BẢNG HỒ SƠ BỆNH ÁN
-- ==========================================
CREATE TABLE HoSoBenhAn (
    HoSoID VARCHAR(10) PRIMARY KEY,         -- Khóa chính hồ sơ bệnh án
    BenhNhanID VARCHAR(10),                 -- Mã bệnh nhân, khóa ngoại đến bảng BenhNhan
    NgayLap DATE,                           -- Ngày lập hồ sơ
    ChanDoan NVARCHAR(255),                 -- Chẩn đoán bệnh
    TrieuChung NVARCHAR(255),               -- Triệu chứng
    TienSuBenh NVARCHAR(255) DEFAULT N'Không', -- Tiền sử bệnh (mặc định "Không")
    GhiChu NVARCHAR(255),                   -- Ghi chú thêm
    -- Khóa ngoại liên kết đến bệnh nhân
    CONSTRAINT FK_HoSoBenhAn_BenhNhan FOREIGN KEY (BenhNhanID)
        REFERENCES BenhNhan(BenhNhanID)
        ON DELETE CASCADE -- Khi xóa bệnh nhân, hồ sơ liên quan tự động bị xóa
);

-- ==========================================
-- BẢNG ĐIỀU TRỊ
-- ==========================================
CREATE TABLE DieuTri (
    DieuTriID VARCHAR(10) PRIMARY KEY,      -- Khóa chính điều trị
    HoSoID VARCHAR(10),                     -- Khóa ngoại liên kết hồ sơ bệnh án
    BacSiID VARCHAR(10),                    -- Khóa ngoại bác sĩ điều trị
    NgayDieuTri DATE,                       -- Ngày điều trị
    PhuongPhap NVARCHAR(255),               -- Phương pháp điều trị
    Thuoc NVARCHAR(255),                    -- Tên thuốc
    ChiPhi DECIMAL(18,2) CHECK (ChiPhi >= 0), -- Chi phí ≥ 0
    KetQua NVARCHAR(255) NULL,              -- Kết quả điều trị có thể NULL
    -- Khóa ngoại liên kết hồ sơ bệnh án, xóa tự động khi hồ sơ bị xóa
    CONSTRAINT FK_DieuTri_HoSoBenhAn FOREIGN KEY (HoSoID)
        REFERENCES HoSoBenhAn(HoSoID)
        ON DELETE CASCADE,
    -- Khóa ngoại liên kết bác sĩ, không xóa tự động
    CONSTRAINT FK_DieuTri_BacSi FOREIGN KEY (BacSiID)
        REFERENCES BacSi(BacSiID)
);

-- ==========================================
-- BẢNG PHÒNG BỆNH
-- ==========================================
CREATE TABLE PhongBenh (
    PhongBenhID VARCHAR(10) PRIMARY KEY,    -- Khóa chính phòng bệnh
    BenhNhanID VARCHAR(10),                 -- Mã bệnh nhân
    NgayNhapVien DATE,                       -- Ngày nhập viện
    NgayXuatVien DATE NULL,                  -- Ngày xuất viện có thể NULL
    PhongSo NVARCHAR(10),                   -- Số phòng
    GiuongSo NVARCHAR(10),                  -- Số giường
    -- Khóa ngoại liên kết bệnh nhân, xóa tự động khi bệnh nhân bị xóa
    CONSTRAINT FK_PhongBenh_BenhNhan FOREIGN KEY (BenhNhanID)
        REFERENCES BenhNhan(BenhNhanID)
        ON DELETE CASCADE,
    -- Ràng buộc kiểm tra ngày xuất viện ≥ ngày nhập viện
    CONSTRAINT chk_NgayXuatVien CHECK (NgayXuatVien IS NULL OR NgayXuatVien >= NgayNhapVien)
);

-- ==========================================
-- BẢNG TÀI KHOẢN
-- ==========================================
CREATE TABLE TaiKhoan (
    TaiKhoanID VARCHAR(10) PRIMARY KEY,     -- Khóa chính tài khoản
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL, -- Tên đăng nhập duy nhất
    MatKhau NVARCHAR(100) NOT NULL,         -- Mật khẩu (text)
    VaiTro TINYINT NOT NULL DEFAULT 1 CHECK (VaiTro IN (0,1)) -- 0=Admin, 1=User
);


-- ================================
-- CHUYÊN KHOA
-- ================================
INSERT INTO ChuyenKhoa (ChuyenKhoaID, TenChuyenKhoa, MoTa)
VALUES
('CK001', N'Nội khoa', N'Khám và điều trị bệnh nội tạng'),
('CK002', N'Tim mạch', N'Điều trị các bệnh lý về tim'),
('CK003', N'Ngoại khoa', N'Phẫu thuật, chấn thương');


-- ================================
-- BỆNH NHÂN
-- ================================
INSERT INTO BenhNhan (BenhNhanID, HoTen, NgaySinh, DiaChi, GioiTinh, SDT, CCCD, TenThanNhan, SDTThanNhan)
VALUES
('BN001', N'Nguyễn Văn A', '1980-01-15', N'Xã Bình Thạnh Đông, Tỉnh An Giang', N'Nam', '0909123456', '123456789012', N'Nguyễn Văn B', '0911223344'),
('BN002', N'Trần Thị B', '1990-05-10', N'Xã Hòa Lạc, Tỉnh An Giang', N'Nữ', '0911223344', '987654321098', N'Trần Văn C', '0909888777');



-- ================================
-- BÁC SĨ
-- ================================
INSERT INTO BacSi (BacSiID, HoTen, ChuyenKhoaID, SDT, Email, TrinhDo)
VALUES
('BS001', N'Lê Minh Tuấn', 'CK001', '0909000001', 'tuanlm@benhvien.vn', N'Tiến sĩ'),
('BS002', N'Nguyễn Thị Hoa', 'CK002', '0909000002', 'hoant@benhvien.vn', N'Thạc sĩ');

-- ================================
-- HỒ SƠ BỆNH ÁN
-- ================================
INSERT INTO HoSoBenhAn (HoSoID, BenhNhanID, NgayLap, ChanDoan, TrieuChung, TienSuBenh, GhiChu)
VALUES
('HS001', 'BN001', '2025-10-01', N'Viêm phổi', N'Sốt, ho, khó thở', N'Hen suyễn', N'Cần theo dõi sát'),
('HS002', 'BN002', '2025-10-03', N'Rối loạn nhịp tim', N'Đau ngực, mệt', N'Tăng huyết áp', N'Theo dõi tim mạch');



-- ================================
-- ĐIỀU TRỊ
-- ================================
INSERT INTO DieuTri (DieuTriID, HoSoID, BacSiID, NgayDieuTri, PhuongPhap, Thuoc, ChiPhi, KetQua)
VALUES
('DT001', 'HS001', 'BS001', '2025-10-02', N'Tiêm kháng sinh', N'Augmentin', 150000, N'Cải thiện tốt'),
('DT002', 'HS002', 'BS002', '2025-10-04', N'Dùng thuốc điều hòa tim', N'Metoprolol', 200000, N'Ổn định');


-- ================================
-- PHÒNG BỆNH
-- ================================
INSERT INTO PhongBenh (PhongBenhID, BenhNhanID, NgayNhapVien, NgayXuatVien, PhongSo, GiuongSo)
VALUES
('PB001', 'BN001', '2025-10-01', '2025-10-06', N'101', N'01'),
('PB002', 'BN002', '2025-10-03', NULL, N'102', N'02');

-- ================================
-- TÀI KHOẢN
-- ================================
INSERT INTO TaiKhoan (TaiKhoanID, TenDangNhap, MatKhau, VaiTro)
VALUES
('TK001', N'admin', N'admin123', 0),
('TK002', N'user1', N'user123', 1);



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
