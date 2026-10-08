-- ===================================================================
-- HỌ VÀ TÊN SINH VIÊN: Lê Văn Duy Tùng
-- MÃ SINH VIÊN: 2410900085
-- LỚP: K24CNT2
-- MÔN HỌC: Phát triển ứng dụng Web với ASP.NET Core MVC
-- ĐỀ THI: CSDL MSSQL và AspnetcoreMVC
-- BẢNG DỮ LIỆU: HvtEmployee (Id, HvtName, HvtGender, HvtBirthDay, HvtEmail, HvtPhone, HvtActive)
-- (Ghi chú: Hvt = Họ và tên sinh viên -> Lvdt / Lê Văn Duy Tùng)
-- FILE NỘP: Hvt Employee_MaSV_Db.sql -> Lê Văn Duy Tùng Employee_2410900085_Db.sql
-- ===================================================================

USE master;
GO

-- Tạo mới Cơ sở dữ liệu nếu chưa tồn tại
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'LvdtEmployee_2410900085_Db')
BEGIN
    CREATE DATABASE LvdtEmployee_2410900085_Db;
END
GO

USE LvdtEmployee_2410900085_Db;
GO

-- ===================================================================
-- 1. BẢNG LvdtEmployee (HvtEmployee thay thế Hvt bằng tên viết tắt sinh viên: Lvdt)
-- Cột và Kiểu dữ liệu phù hợp:
-- - Id: INT IDENTITY(1,1) PRIMARY KEY -> Khóa chính, tự động tăng 1 đơn vị
-- - LvdtName: NVARCHAR(100) NOT NULL -> Tên nhân viên (chuỗi Unicode có dấu, tối đa 100 ký tự)
-- - LvdtGender: BIT NULL -> Giới tính (1: Nam, 0: Nữ)
-- - LvdtBirthDay: DATE NULL -> Ngày sinh (kiểu ngày YYYY-MM-DD)
-- - LvdtEmail: VARCHAR(100) NULL -> Thư điện tử (chuỗi ký tự chuẩn)
-- - LvdtPhone: VARCHAR(20) NULL -> Số điện thoại (chuỗi số)
-- - LvdtActive: BIT NOT NULL DEFAULT 1 -> Trạng thái hoạt động (1: Đang làm việc / Hoạt động, 0: Đã khóa / Tạm dừng)
-- ===================================================================

IF OBJECT_ID('LvdtEmployee', 'U') IS NOT NULL
    DROP TABLE LvdtEmployee;
GO

CREATE TABLE LvdtEmployee (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    LvdtName NVARCHAR(100) NOT NULL,
    LvdtGender BIT NULL,
    LvdtBirthDay DATE NULL,
    LvdtEmail VARCHAR(100) NULL,
    LvdtPhone VARCHAR(20) NULL,
    LvdtActive BIT NOT NULL DEFAULT 1
);
GO

-- Chèn dữ liệu mẫu cho bảng LvdtEmployee
INSERT INTO LvdtEmployee (LvdtName, LvdtGender, LvdtBirthDay, LvdtEmail, LvdtPhone, LvdtActive) VALUES
(N'Lê Văn Duy Tùng', 1, '2006-05-15', 'tung.levanduy@gmail.com', '0912345678', 1),
(N'Nguyễn Văn An', 1, '2004-03-20', 'annv@gmail.com', '0987654321', 1),
(N'Trần Thị Mai', 0, '2005-08-12', 'maitt@gmail.com', '0905123456', 1),
(N'Lê Hoàng Nam', 1, '2003-11-25', 'namlh@gmail.com', '0934567890', 0),
(N'Phạm Thu Hà', 0, '2005-01-30', 'hapt@gmail.com', '0978112233', 1),
(N'Vũ Minh Tuấn', 1, '2004-09-18', 'tuanvm@gmail.com', '0966778899', 1),
(N'Đỗ Thị Ngọc Lan', 0, '2006-02-14', 'lanntn@gmail.com', '0944556677', 1);
GO

-- ===================================================================
-- 2. BẢNG HvtEmployee (Giữ nguyên tên bảng HvtEmployee theo đề bài)
-- ===================================================================
IF OBJECT_ID('HvtEmployee', 'U') IS NOT NULL
    DROP TABLE HvtEmployee;
GO

CREATE TABLE HvtEmployee (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HvtName NVARCHAR(100) NOT NULL,
    HvtGender BIT NULL,
    HvtBirthDay DATE NULL,
    HvtEmail VARCHAR(100) NULL,
    HvtPhone VARCHAR(20) NULL,
    HvtActive BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO HvtEmployee (HvtName, HvtGender, HvtBirthDay, HvtEmail, HvtPhone, HvtActive)
SELECT LvdtName, LvdtGender, LvdtBirthDay, LvdtEmail, LvdtPhone, LvdtActive FROM LvdtEmployee;
GO

-- ===================================================================
-- 3. BẢNG LvdtStudent & HvtStudent (Phục vụ yêu cầu 4: CRUD thao tác với bảng HvtStudent / Danh sách sinh viên)
-- ===================================================================
IF OBJECT_ID('LvdtStudent', 'U') IS NOT NULL
    DROP TABLE LvdtStudent;
GO

CREATE TABLE LvdtStudent (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    LvdtName NVARCHAR(100) NOT NULL,
    LvdtGender BIT NULL,
    LvdtBirthDay DATE NULL,
    LvdtEmail VARCHAR(100) NULL,
    LvdtPhone VARCHAR(20) NULL,
    LvdtActive BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO LvdtStudent (LvdtName, LvdtGender, LvdtBirthDay, LvdtEmail, LvdtPhone, LvdtActive) VALUES
(N'Lê Văn Duy Tùng', 1, '2006-05-15', 'tung.levanduy@gmail.com', '0912345678', 1),
(N'Nguyễn Thành Long', 1, '2006-04-10', 'longnt@gmail.com', '0981234567', 1),
(N'Trần Phương Thảo', 0, '2006-07-22', 'thaotp@gmail.com', '0919876543', 1),
(N'Hoàng Văn Bách', 1, '2006-12-05', 'bachhv@gmail.com', '0933221100', 0),
(N'Bùi Thị Thanh Hương', 0, '2006-03-18', 'huongbtt@gmail.com', '0977889900', 1);
GO

IF OBJECT_ID('HvtStudent', 'U') IS NOT NULL
    DROP TABLE HvtStudent;
GO

CREATE TABLE HvtStudent (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HvtName NVARCHAR(100) NOT NULL,
    HvtGender BIT NULL,
    HvtBirthDay DATE NULL,
    HvtEmail VARCHAR(100) NULL,
    HvtPhone VARCHAR(20) NULL,
    HvtActive BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO HvtStudent (HvtName, HvtGender, HvtBirthDay, HvtEmail, HvtPhone, HvtActive)
SELECT LvdtName, LvdtGender, LvdtBirthDay, LvdtEmail, LvdtPhone, LvdtActive FROM LvdtStudent;
GO

-- Kiểm tra dữ liệu vừa tạo
SELECT * FROM LvdtEmployee;
SELECT * FROM LvdtStudent;
GO
