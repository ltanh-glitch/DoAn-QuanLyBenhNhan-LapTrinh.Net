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
GO


-- ==========================================
-- BẢNG 1: BENHNHAN - Lưu thông tin bệnh nhân
-- ==========================================
CREATE TABLE BenhNhan (
    MaBN INT IDENTITY PRIMARY KEY,              -- Mã bệnh nhân (tự tăng, khóa chính, không trùng)
    HoTen NVARCHAR(100) NOT NULL,               -- Họ tên bệnh nhân
    NgaySinh DATE,								-- Ngày sinh
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')), -- Giới tính
    CCCD NVARCHAR(12) UNIQUE,                   -- Căn cước công dân (duy nhất)
    DiaChi NVARCHAR(200) NOT NULL,              -- Địa chỉ
    SDT NVARCHAR(15) UNIQUE,                    -- Số điện thoại (duy nhất)
    ThanNhan NVARCHAR(100)						-- Thân nhân liên hệ
);



-- ==========================================
-- BẢNG 2: BACSI - Lưu thông tin bác sĩ
-- ==========================================
CREATE TABLE BacSi (
    MaBS INT IDENTITY PRIMARY KEY,              -- Mã bác sĩ
    HoTen NVARCHAR(100) NOT NULL,               -- Họ tên
    ChuyenKhoa NVARCHAR(100),					-- Chuyên khoa
    SDT NVARCHAR(15) UNIQUE                     -- Số điện thoại
);



-- ==========================================
-- BẢNG 3: PHONGKHAM - Quản lý các phòng khám
-- ==========================================
CREATE TABLE PhongKham (
    MaPK INT IDENTITY PRIMARY KEY,              -- Mã phòng khám
    TenPhong NVARCHAR(100) UNIQUE,              -- Tên phòng
    ViTri NVARCHAR(100)                         -- Vị trí
);



-- ==========================================
-- BẢNG 4: HOSOBENHAN - Thông tin hồ sơ khám bệnh
-- ==========================================
CREATE TABLE HoSoBenhAn (
    MaHS INT IDENTITY PRIMARY KEY,              -- Mã hồ sơ bệnh án
    MaBN INT FOREIGN KEY REFERENCES BenhNhan(MaBN), -- Liên kết bệnh nhân
    MaBS INT FOREIGN KEY REFERENCES BacSi(MaBS),    -- Liên kết bác sĩ
    MaPK INT FOREIGN KEY REFERENCES PhongKham(MaPK),-- Liên kết phòng khám
    NgayKham DATE NOT NULL DEFAULT GETDATE(),   -- Ngày khám (Nếu không nhập, hệ thống sẽ tự lấy ngày hiện tại.)
    TrieuChung NVARCHAR(200),                   -- Triệu chứng
    ChanDoan NVARCHAR(200)                      -- Chẩn đoán
);



-- ==========================================
-- BẢNG 5: DIEUTRI - Quá trình điều trị
-- ==========================================
CREATE TABLE DieuTri (
    MaDT INT IDENTITY PRIMARY KEY,              -- Mã điều trị
    MaHS INT FOREIGN KEY REFERENCES HoSoBenhAn(MaHS), -- Liên kết hồ sơ
    NgayBatDau DATE NOT NULL DEFAULT GETDATE(), -- Ngày bắt đầu (Nếu không nhập, hệ thống sẽ tự lấy ngày hiện tại.)
    NgayKetThuc DATE NULL,                      -- Ngày kết thúc
    PhuongPhap NVARCHAR(200),                   -- Phương pháp điều trị
    KetQua NVARCHAR(100),                       -- Kết quả (Khỏi, Đang điều trị…)
    GhiChu NVARCHAR(500)                        -- Ghi chú
);



-- ==========================================
-- BẢNG 6: THUOC - Quản lý & kê thuốc
-- (đơn giản: thuốc kê cho từng hồ sơ bệnh án)
-- ==========================================
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY PRIMARY KEY,               -- Mã thuốc
    TenThuoc NVARCHAR(100) NOT NULL,                -- Tên thuốc
    DonVi NVARCHAR(50),                             -- Đơn vị (viên, ống…)
    Gia DECIMAL(18,2),                              -- Giá
    SoLuong INT CHECK (SoLuong >= 0),               -- Số lượng kê
    LieuDung NVARCHAR(200),                         -- Liều dùng
    MaHS INT FOREIGN KEY REFERENCES HoSoBenhAn(MaHS) -- Liên kết hồ sơ bệnh án
);



-- ==========================================
-- BẢNG 7: TAIKHOAN - Đăng nhập & phân quyền
-- ==========================================
CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY PRIMARY KEY,                 -- Mã tài khoản
    TenDangNhap NVARCHAR(50) UNIQUE,               -- Username
    MatKhau NVARCHAR(100) NOT NULL,                -- Password
    Quyen NVARCHAR(20) CHECK (Quyen IN ('Admin', 'BacSi', 'NhanVien')), -- Vai trò
    MaBS INT NULL FOREIGN KEY REFERENCES BacSi(MaBS) -- Nếu là bác sĩ
);



-- ==========================================
-- DỮ LIỆU MẪU
-- ==========================================

-- Thêm bệnh nhân
INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, CCCD, DiaChi, SDT, ThanNhan) VALUES
(N'Nguyễn Văn An', '1990-05-10', N'Nam', '089345678935', N'Hà Nội', '0901234567', N'Nguyễn Thị Bích'),
(N'Trần Thị Linh', '1985-11-20', N'Nữ', '089987654321', N'Hồ Chí Minh', '0912345678', N'Trần Văn Danh');

-- Thêm bác sĩ
INSERT INTO BacSi (HoTen, ChuyenKhoa, SDT) VALUES
(N'Lê Tuấn Anh', N'Nội tổng quát', '0931234567'),
(N'Nguyễn Tâm Như', N'Nhi khoa', '0942345678');

-- Thêm phòng khám
INSERT INTO PhongKham (TenPhong, ViTri) VALUES
(N'Phòng Khám Nội', N'Tầng 2 - Khu A'),
(N'Phòng Khám Nhi', N'Tầng 3 - Khu B');

-- Thêm hồ sơ bệnh án
INSERT INTO HoSoBenhAn (MaBN, MaBS, MaPK, NgayKham, TrieuChung, ChanDoan) VALUES
(1, 1, 1, '2025-09-01', N'Sốt cao, ho', N'Cảm cúm'),
(2, 2, 2, '2025-09-05', N'Đau bụng', N'Viêm dạ dày');

-- Thêm điều trị
INSERT INTO DieuTri (MaHS, NgayBatDau, PhuongPhap, KetQua, GhiChu) VALUES
(1, '2025-09-01', N'Uống thuốc theo toa', N'Đang điều trị', N'Theo dõi nhiệt độ hằng ngày'),
(2, '2025-09-05', N'Nội soi + thuốc', N'Khỏi', N'Ăn uống kiêng cay nóng');

-- Thêm thuốc
INSERT INTO Thuoc (TenThuoc, DonVi, Gia, SoLuong, LieuDung, MaHS) VALUES
(N'Paracetamol', N'Viên', 2000, 10, N'Uống 2 viên/ngày sau ăn', 1),
(N'Vitamin C', N'Viên', 1500, 20, N'Uống 1 viên/ngày buổi sáng', 1),
(N'Omeprazole', N'Viên', 5000, 14, N'Uống 1 viên/ngày trước ăn sáng', 2);

-- Thêm tài khoản
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen) VALUES
('admin', '123456', 'Admin'),
('bacsi', '123456', 'BacSi'),
('nhanvien', '123456', 'NhanVien');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen, MaBS) VALUES
('bs_anh', '123456', 'BacSi', 1),
('bs_nhu', '123456', 'BacSi', 2);


-- ==========================================
-- KIỂM TRA DỮ LIỆU
-- ==========================================
SELECT * FROM BenhNhan;     -- Xem danh sách bệnh nhân
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


