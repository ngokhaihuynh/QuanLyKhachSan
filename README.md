# Ứng Dụng Đặt Phòng Khách Sạn

Ứng dụng Đặt Phòng Khách Sạn là hệ thống giúp khách hàng tìm kiếm và đặt phòng tại các khách sạn. Hệ thống hỗ trợ các tính năng như đăng ký tài khoản, xem danh sách phòng, đặt phòng và quản lý thông tin khách hàng. Dự án được xây dựng bằng WinForms và kết nối với cơ sở dữ liệu SQL Server.

## Chức Năng Chính

### 1. Quản Lý 
- **Đăng nhập**: Người quản lý có thể đăng nhập vào hệ thống bằng tài khoản và mật khẩu.

### 2. Quản Lý Phòng
- **Xem danh sách phòng**: Hiển thị danh sách phòng khách sạn hiện có.
- **Chọn phòng**: Có thể chọn phòng từ danh sách phòng có sẵn.

### 3. Đặt Phòng
- **Chọn phòng và đặt phòng**: Người dùng chọn phòng, điền thông tin ngày nhận phòng và trả phòng, sau đó thực hiện đặt phòng.
- **Thanh toán**: Thanh toán cho đơn đặt phòng.

## Yêu Cầu Hệ Thống
- **Ngôn ngữ lập trình**: C# (WinForms)
- **Cơ sở dữ liệu**: SQL Server
- **Hệ điều hành**: Windows

## Cài Đặt

1. **Clone repository**:
    ```bash
    git clone https://github.com/ngokhaihuynh/QuanLyKhachSan.git
    cd hotel-booking-winforms
    ```

2. **Mở dự án trong Visual Studio**:
   Mở file `.sln` trong **Visual Studio**.

3. **Cấu hình cơ sở dữ liệu**:
   - Mở **SQL Server Management Studio** (SSMS) và kết nối với SQL Server.
   - Cấu hình chuỗi kết nối trong `App.config`:
     ```xml
     <connectionStrings>
         <add name="HotelDbConnection" 
              connectionString="Server=your_server_name;Database=HotelManagement;Integrated Security=True;" 
              providerName="System.Data.SqlClient"/>
     </connectionStrings>
     ```


4. **Chạy ứng dụng**:
   - Trong **Visual Studio**, nhấn **F5** hoặc chọn **Start Debugging** để chạy ứng dụng.
   - Ứng dụng sẽ khởi chạy và bạn có thể sử dụng các chức năng như đặt phòng, xem danh sách phòng, và quản lý hồ sơ người dùng.

## Hướng Dẫn Sử Dụng
- **Đăng nhập**: Sử dụng email và mật khẩu để đăng nhập vào hệ thống.
- **Đặt phòng**: Chọn phòng từ danh sách và nhập ngày nhận phòng, ngày trả phòng. Sau đó thực hiện thanh toán.

## Liên Hệ
- Email: nkhuynh145@gmail.com
  
