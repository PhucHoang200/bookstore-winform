
# 📚 BookStore – Phần mềm Quản Lý Cửa Hàng Bán Sách (WinForms C#)

## 1. Giới thiệu

**BookStore** là phần mềm quản lý cửa hàng bán sách được xây dựng bằng **C# – Windows Forms (.NET Framework)** theo mô hình kiến trúc nhiều tầng (3-Layer Architecture).  
Hệ thống hỗ trợ quản lý sách, khách hàng, hóa đơn, nhà cung cấp, kho hàng và báo cáo doanh thu một cách trực quan, chính xác và hiệu quả.

Phần mềm phù hợp cho các cửa hàng sách quy mô nhỏ và vừa, mong muốn số hóa quy trình quản lý truyền thống.

---

## 2. Mục tiêu đề tài

- Xây dựng hệ thống quản lý bán sách có tính tự động hóa cao.
- Đơn giản hóa quy trình bán hàng và quản lý kho.
- Cung cấp báo cáo doanh thu theo nhiều tiêu chí.
- Thiết kế giao diện trực quan, dễ sử dụng.
- Nâng cao kỹ năng phát triển ứng dụng WinForms và SQL Server.

---

## 3. Kiến trúc hệ thống

Project được tổ chức theo mô hình **3-Layer Architecture**:


BookStore/
├── BUS/  (Business Logic Layer)
├── DAL/  (Data Access Layer)
├── DTO/  (Data Transfer Object)
├── GUI/  (Graphical User Interface)
└── BookStore.sln


### 🔹 DTO (Data Transfer Object)
- Định nghĩa các class đại diện cho thực thể:
  - Sách
  - Khách hàng
  - Hóa đơn
  - Nhà cung cấp
  - Nhân viên
  - Tài khoản
  - Phiếu nhập
  - Chi tiết hóa đơn / chi tiết phiếu nhập

### 🔹 DAL (Data Access Layer)
- Kết nối SQL Server
- Thực hiện các thao tác CRUD
- Xử lý truy vấn và tương tác cơ sở dữ liệu

### 🔹 BUS (Business Logic Layer)
- Xử lý nghiệp vụ
- Kiểm tra dữ liệu đầu vào
- Tính toán tổng tiền, doanh thu
- Cập nhật tồn kho

### 🔹 GUI (Windows Forms)
- Giao diện người dùng
- Form quản lý sách, hóa đơn, kho
- Biểu đồ thống kê
- Xuất báo cáo

---

## 4. Cấu trúc thư mục ngoại vi


WinForm/
├── BaoCao/      (Chứa file PDF báo cáo)
├── HoaDon/      (Chứa file PDF hóa đơn)
├── PhieuNhap/   (Chứa file PDF phiếu nhập)
├── .gitignore
├── BookStoreDBMoi.sql
├── LICENSE
└── README.md


---

## 5. Công nghệ sử dụng

| Thành phần | Công nghệ |
|------------|-----------|
| Ngôn ngữ | C# |
| Nền tảng | Windows Forms (.NET Framework) |
| CSDL | SQL Server |
| Công cụ quản lý CSDL | SQL Server Management Studio |
| Xuất báo cáo | Spire.Office |
| Quản lý mã nguồn | Git |
| Thiết kế UML | StarUML |

---

## 6. Chức năng chính

### 📚 6.1 Quản lý sách
- Thêm / Sửa / Xóa sách
- Tìm kiếm theo:
  - Tên sách
  - Tác giả
  - Thể loại
- Quản lý tồn kho
- Lịch sử nhập sách
- Tính giá nhập trung bình

---

### 🧾 6.2 Quản lý hóa đơn (Đơn hàng)

#### Tạo đơn hàng
- Tự động sinh mã đơn
- Lưu thông tin khách hàng
- Thêm danh sách sản phẩm
- Tự động tính tổng tiền
- Tự động trừ tồn kho

#### Danh sách đơn hàng
- Tìm kiếm theo:
  - Mã đơn
  - Tên khách hàng
  - Số điện thoại
- Lọc theo ngày
- Sắp xếp theo giá trị / thời gian

---

### 👤 6.3 Quản lý khách hàng
- Thêm / Sửa / Xóa
- Tìm kiếm nhanh
- Thống kê doanh thu theo khách hàng

---

### 👨‍💼 6.4 Quản lý nhân viên
- Lưu thông tin nhân viên
- Quản lý ngày bắt đầu làm việc

---

### 🔐 6.5 Quản lý tài khoản
- Tạo tài khoản mới
- Phân quyền sử dụng hệ thống

---

### 🏬 6.6 Quản lý kho

#### Nhà cung cấp
- Thêm / Sửa / Xóa
- Danh sách nhà cung cấp

#### Phiếu nhập
- Nhập sách mới
- Nhập bổ sung sách
- Lưu lịch sử nhập
- Xem chi tiết phiếu nhập

---

### 📊 6.7 Báo cáo & Thống kê

#### Thống kê tổng quan
- Tổng số đơn hàng
- Tổng doanh thu

#### Theo thời gian
- Ngày
- Tháng
- Năm
- Khoảng thời gian tùy chọn

#### Theo sản phẩm
- Số lượng bán
- Doanh thu từng sản phẩm
- Lọc theo thể loại

#### Theo khách hàng
- Tổng đơn hàng
- Doanh thu mang lại

---

## 7. Xuất báo cáo

Hệ thống hỗ trợ xuất dữ liệu dưới nhiều định dạng:

- PDF (.pdf)
- Excel (.xlsx)
- CSV (.csv)

### Nội dung báo cáo bao gồm:
- Tổng quan doanh thu
- Doanh thu theo thời gian
- Doanh thu theo sản phẩm
- Doanh thu theo khách hàng
- Danh sách sản phẩm bán chạy
- Sản phẩm tồn kho thấp

Các file được lưu trong:


WinForm/BaoCao/
WinForm/HoaDon/
WinForm/PhieuNhap/

````

---

## 8. Hướng dẫn cài đặt

### Bước 1: Clone repository
```bash
git clone <repository-url>
````

### Bước 2: Khởi tạo cơ sở dữ liệu

1. Mở **SQL Server Management Studio**
2. Chạy file:

```
BookStoreDBMoi.sql
```

### Bước 3: Cấu hình chuỗi kết nối

* Mở file cấu hình trong DAL
* Chỉnh sửa `Connection String` phù hợp với SQL Server của bạn

### Bước 4: Chạy project

* Mở `BookStore.sln` bằng Visual Studio
* Build và Run

---

## 9. Phạm vi và đối tượng nghiên cứu

* Đối tượng: Quy trình quản lý cửa hàng bán sách
* Phạm vi: Ứng dụng desktop trên nền tảng Windows

---

## 10. Kết quả đạt được

* Hệ thống quản lý hoàn chỉnh
* Giảm sai sót so với quản lý thủ công
* Báo cáo doanh thu chính xác
* Giao diện trực quan, dễ sử dụng
* Có thể ứng dụng thực tế cho cửa hàng nhỏ và vừa

---

## 11. Hạn chế

* Chỉ hỗ trợ nền tảng Windows
* Bảo mật còn cơ bản
* Chưa có phiên bản Web/Mobile

---

## 12. Hướng phát triển

* Phát triển phiên bản Web (ASP.NET Core)
* Xây dựng ứng dụng Mobile
* Tích hợp thanh toán online
* Cải thiện bảo mật (mã hóa mật khẩu, phân quyền nâng cao)
* Tối ưu hiệu năng khi dữ liệu lớn

---

## 13. Phương pháp nghiên cứu

* Nghiên cứu tài liệu WinForms & SQL Server
* Phân tích yêu cầu hệ thống
* Thực nghiệm và kiểm thử
* So sánh hiệu quả trước và sau khi áp dụng

---

## 14. License

Dự án được phát hành theo file `LICENSE` đi kèm repository.

---

# 📌 Kết luận

BookStore là một hệ thống quản lý cửa hàng bán sách được xây dựng bài bản theo kiến trúc nhiều tầng, đáp ứng đầy đủ các yêu cầu quản lý thực tế.
Phần mềm giúp tối ưu hóa quy trình vận hành, nâng cao tính chính xác và hỗ trợ ra quyết định thông qua hệ thống báo cáo thống kê chi tiết.
