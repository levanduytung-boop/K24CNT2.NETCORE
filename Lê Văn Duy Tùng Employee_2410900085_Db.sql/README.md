# BÀI THI KẾT THÚC HỌC PHẦN - ASP.NET CORE MVC & MSSQL

- **Sinh viên thực hiện:** Lê Văn Duy Tùng
- **Mã sinh viên:** 2410900085
- **Lớp:** K24CNT2
- **Môn học:** Phát triển ứng dụng Web với ASP.NET Core MVC

---

## 1. CƠ SỞ DỮ LIỆU MSSQL (YÊU CẦU 1)
- **Tên CSDL:** `LvdtEmployee_2410900085_Db`
- **Tập tin SQL script nộp:**
  - `LvdtEmployee_2410900085_Db.sql`
  - `HvtEmployee_2410900085_Db.sql`
- **Cấu trúc bảng và kiểu dữ liệu lựa chọn:**
  - `Id`: `INT IDENTITY(1,1) PRIMARY KEY` - Khóa chính tự động tăng
  - `LvdtName` / `HvtName`: `NVARCHAR(100) NOT NULL` - Họ và tên nhân viên (Unicode có dấu)
  - `LvdtGender` / `HvtGender`: `BIT` - Giới tính (1: Nam, 0: Nữ)
  - `LvdtBirthDay` / `HvtBirthDay`: `DATE` - Ngày sinh
  - `LvdtEmail` / `HvtEmail`: `VARCHAR(100)` - Thư điện tử
  - `LvdtPhone` / `HvtPhone`: `VARCHAR(20)` - Số điện thoại
  - `LvdtActive` / `HvtActive`: `BIT NOT NULL DEFAULT 1` - Trạng thái hoạt động (1: Hoạt động, 0: Khóa)
- *Ghi chú:* Database đã được tạo sẵn cả 2 bảng `LvdtEmployee` (và `HvtEmployee`) cùng bảng `LvdtStudent` (và `HvtStudent`) kèm dữ liệu mẫu tiếng Việt.

---

## 2. ỨNG DỤNG ASP.NET CORE MVC (YÊU CẦU 2)
- **Tên project:** `LeVanDuyTung2410900085_exam`
- **Framework:** .NET 10.0 (hoặc .NET 8.0)
- **Kiến trúc:** Model - View - Controller (MVC Template)
- **ORM:** Entity Framework Core 10 với Microsoft SQL Server

---

## 3. TRANG THÔNG TIN SINH VIÊN (YÊU CẦU 3)
- **Menu link trên Layout:** `Thông tin sinh viên (HvtAbout)`
- **Controller:** `HomeController`
- **Action:** `HvtAbout` (hỗ trợ cả alias `LvdtAbout`)
- **Đường dẫn URL:** `http://localhost:5200/Home/HvtAbout`
- **Nội dung hiển thị:** Hồ sơ sinh viên Lê Văn Duy Tùng, MSV 2410900085, Lớp K24CNT2, Khoa CNTT với giao diện Profile Card Bootstrap 5 chuyên nghiệp.

---

## 4. QUẢN LÝ CRUD VỚI SCAFFOLDING & GIAO DIỆN BOOTSTRAP (YÊU CẦU 4)
- **Menu link trên Layout:**
  - `Danh sách sinh viên (HvtStudent)`: Thao tác CRUD bảng sinh viên
  - `Danh sách nhân viên (HvtEmployee)`: Thao tác CRUD bảng nhân viên
- **Công cụ sinh mã:** Sử dụng `dotnet scaffold aspnet mvccontroller-crud`
- **Chức năng:**
  - **Index:** Xem danh sách dạng bảng, badge giới tính (Nam/Nữ) và trạng thái (Hoạt động/Tạm dừng)
  - **Create:** Thêm mới dữ liệu với form validation và switch button
  - **Edit:** Cập nhật thông tin bản ghi
  - **Details:** Xem chi tiết dạng bảng thông tin hồ sơ
  - **Delete:** Xác nhận xóa bản ghi với cảnh báo an toàn
- **Giao diện:** Tùy biến toàn bộ với Bootstrap 5, Bootstrap Icons, responsive và shadow styling.

---

## HƯỚNG DẪN CHẠY ỨNG DỤNG
1. Khởi động SQL Server (Instance: `.\SQLEXPRESS` hoặc cấu hình chuỗi kết nối trong `appsettings.json`).
2. Mở Solution `LeVanDuyTung2410900085_exam.sln` bằng Visual Studio hoặc chạy lệnh:
   ```powershell
   dotnet run --project LeVanDuyTung2410900085_exam\LeVanDuyTung2410900085_exam.csproj
   ```
3. Truy cập trình duyệt tại: `http://localhost:5200` hoặc cổng được hiển thị trong terminal.
