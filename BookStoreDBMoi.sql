/-- CREATE DATABASE BookStoreDB;
-- USE BookStoreDB;

GO
-- Bảng Vai trò
CREATE TABLE VaiTro
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenVaiTro NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenVaiTro) > 0)
);
GO

-- Bảng Nhà xuất bản
CREATE TABLE NhaXuatBan
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenNXB NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenNXB) > 0)
);
GO

-- Bảng Tác giả
CREATE TABLE TacGia
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenTG NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenTG) > 0)
);
GO

-- Bảng Thể loại
CREATE TABLE TheLoai
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenTL NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenTL) > 0)
);
GO

-- Bảng Nhà cung cấp
CREATE TABLE NhaCungCap
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenNCC) > 0)
);
GO

-- Bảng Sách
CREATE TABLE Sach
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(255) UNIQUE NOT NULL CHECK (LEN(TenSach) > 0),
    IdNXB INT NOT NULL REFERENCES NhaXuatBan(Id) ON DELETE CASCADE,
    NamXuatBan INT NOT NULL CHECK (NamXuatBan >= 1000 AND NamXuatBan <= YEAR(GETDATE()))
);
GO

-- Bảng Tài khoản
CREATE TABLE TaiKhoan
(
    Id INT IDENTITY(1,1) PRIMARY KEY,   
	HoTen NVARCHAR(255) NOT NULL CHECK (LEN(HoTen) > 0),
    SoDienThoai NVARCHAR(10) UNIQUE NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    MatKhau VARBINARY(MAX) NOT NULL,
	NgayTaoTaiKhoan DATE DEFAULT(GETDATE()) CHECK (NgayTaoTaiKhoan <= GETDATE()),
    Luong DECIMAL(10, 2) NULL CHECK (Luong IS NULL OR Luong > 0),
    IdVaiTro INT NOT NULL REFERENCES VaiTro(Id) ON DELETE CASCADE, 
	CONSTRAINT CK_TaiKhoan_SoDienThoai CHECK (SoDienThoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT CK_TaiKhoan_MatKhau CHECK (DATALENGTH(MatKhau) > 0),
    CONSTRAINT CK_TaiKhoan_Email CHECK (Email LIKE '%@%.%')
);
GO

-- Bảng Khách hàng
CREATE TABLE KhachHang
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HoTenKH NVARCHAR(255) NOT NULL CHECK (LEN(HoTenKH) > 0),
    Email NVARCHAR(255) NULL,
    SoDienThoai NVARCHAR(10) NULL,
    DiaChi NVARCHAR(255) NULL,
    CONSTRAINT CK_KhachHang_Email CHECK (Email LIKE '%@%.%'),
    CONSTRAINT CK_KhachHang_SoDienThoai CHECK (SoDienThoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
GO

-- Bảng trung gian Sách - Tác giả
CREATE TABLE Sach_TacGia
(
    IdSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    IdTacGia INT NOT NULL REFERENCES TacGia(Id) ON DELETE CASCADE,
    PRIMARY KEY (IdSach, IdTacGia)
);
GO

-- Bảng trung gian Sách - Thể loại
CREATE TABLE Sach_TheLoai
(
    IdSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    IdTheLoai INT NOT NULL REFERENCES TheLoai(Id) ON DELETE CASCADE,
    PRIMARY KEY (IdSach, IdTheLoai)
);
GO

-- Bảng trung gian Sách - Nhà cung cấp
CREATE TABLE Sach_NhaCungCap
(
    IdSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    IdNhaCungCap INT NOT NULL REFERENCES NhaCungCap(Id) ON DELETE CASCADE,
    PRIMARY KEY (IdSach, IdNhaCungCap)
);
GO

-- Bảng Đơn hàng
CREATE TABLE DonHang
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NgayMuaHang DATETIME DEFAULT(GETDATE()) CHECK (NgayMuaHang <= GETDATE()),
    IdKhachHang INT NOT NULL REFERENCES KhachHang(Id) ON DELETE CASCADE,
    TongTienBan DECIMAL(15, 2) NULL
);
GO

-- Bảng Chi tiết đơn hàng
CREATE TABLE CT_DonHang
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdDonHang INT NOT NULL REFERENCES DonHang(Id) ON DELETE CASCADE,
    IdSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    IdTaiKhoan INT NOT NULL REFERENCES TaiKhoan(Id) ON DELETE CASCADE,
    DonGiaBan DECIMAL(15, 2) NOT NULL CHECK (DonGiaBan > 0),
    SoLuongBan INT NOT NULL CHECK (SoLuongBan > 0)
);
GO


-- Bảng Kho
CREATE TABLE Kho
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    SoLuongTon INT NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0),
    DonGiaNhap DECIMAL(15, 2) NULL,
    DonGiaBan DECIMAL(15, 2) NULL
);
GO

-- Bảng Phiếu nhập sách
CREATE TABLE PhieuNhapSach
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
	MaNCC INT NOT NULL REFERENCES NhaCungCap(Id) ON DELETE CASCADE,
    NgayNhapSach DATETIME DEFAULT(GETDATE()) CHECK (NgayNhapSach <= GETDATE()),
    TongTienNhap DECIMAL(15, 2) NULL
);
GO

-- Bảng Chi tiết phiếu nhập
CREATE TABLE CT_PhieuNhap
(
    Id INT IDENTITY PRIMARY KEY,
    MaPhieuNhap INT NOT NULL REFERENCES PhieuNhapSach(Id) ON DELETE CASCADE,
    MaSach INT NOT NULL REFERENCES Sach(Id) ON DELETE CASCADE,
    SoLuongNhap INT NOT NULL CHECK (SoLuongNhap > 0),
    DonGiaNhap DECIMAL(15, 2) NOT NULL CHECK (DonGiaNhap >= 0),
    DonGiaBan DECIMAL(15, 2) NOT NULL CHECK (DonGiaBan >= 0),
    ThanhTien AS (SoLuongNhap * DonGiaNhap) PERSISTED,
	CONSTRAINT CHK_DonGiaNhap_DonGiaBan CHECK (DonGiaNhap <= DonGiaBan)
);
GO

-- Trigger cập nhật tồn kho sau khi thêm đơn hàng
CREATE TRIGGER trg_UpdateStock_AfterInsertOrder
ON CT_DonHang
AFTER INSERT
AS
BEGIN
    UPDATE Kho
    SET SoLuongTon = SoLuongTon - ISNULL((
        SELECT SUM(SoLuongBan)
        FROM inserted
        WHERE Kho.IdSach = inserted.IdSach
    ), 0)
    WHERE EXISTS (SELECT 1 FROM inserted WHERE Kho.IdSach = inserted.IdSach);
END;
GO

-- Trigger cập nhật tồn kho sau khi nhập sách
CREATE TRIGGER trg_UpdateStock_AfterInsertReceipt
ON CT_PhieuNhap
AFTER INSERT
AS
BEGIN
    UPDATE Kho
    SET SoLuongTon = SoLuongTon + ISNULL((
        SELECT SUM(SoLuongNhap)
        FROM inserted
        WHERE Kho.IdSach = inserted.MaSach
    ), 0)
    WHERE EXISTS (SELECT 1 FROM inserted WHERE Kho.IdSach = inserted.MaSach);
END;
GO


-- Trigger cập nhật tổng tiền bán trong đơn hàng
CREATE TRIGGER trg_UpdateTongTienBan
ON CT_DonHang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Cập nhật tổng tiền bán trong bảng DonHang
    UPDATE DonHang
    SET TongTienBan = (
        SELECT ISNULL(SUM(DonGiaBan * SoLuongBan), 0)
        FROM CT_DonHang
        WHERE CT_DonHang.IdDonHang = DonHang.Id
    )
    WHERE DonHang.Id IN (
        SELECT IdDonHang FROM inserted
        UNION
        SELECT IdDonHang FROM deleted
    );
END;
GO


-- Trigger cập nhật tổng tiền nhập trong phiếu nhập sách
CREATE TRIGGER trg_UpdateTongTienNhap
ON CT_PhieuNhap
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Cập nhật tổng tiền nhập trong bảng PhieuNhapSach
    UPDATE PhieuNhapSach
    SET TongTienNhap = (
        SELECT ISNULL(SUM(SoLuongNhap * DonGiaNhap), 0)
        FROM CT_PhieuNhap
        WHERE CT_PhieuNhap.MaPhieuNhap = PhieuNhapSach.Id
    )
    WHERE PhieuNhapSach.Id IN (
        SELECT MaPhieuNhap FROM inserted
        UNION
        SELECT MaPhieuNhap FROM deleted
    );
END;
GO


-- Trigger cập nhật DonGiaNhap và DonGiaBan trong bảng Kho từ CT_PhieuNhap
CREATE TRIGGER trg_UpdateKhoFromCT_PhieuNhap
ON CT_PhieuNhap
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật DonGiaNhap và DonGiaBan trong bảng Kho từ bảng CT_PhieuNhap
    UPDATE Kho
    SET Kho.DonGiaNhap = CT_PhieuNhap.DonGiaNhap,
        Kho.DonGiaBan = CT_PhieuNhap.DonGiaBan
    FROM Kho
    INNER JOIN inserted ON Kho.IdSach = inserted.MaSach
    INNER JOIN CT_PhieuNhap ON CT_PhieuNhap.MaSach = inserted.MaSach
                              AND CT_PhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
    WHERE Kho.IdSach = inserted.MaSach;
END;


--Nhập thông tin ở đây

-- Thêm dữ liệu cho bảng VaiTro (Admin và Nhân viên)
INSERT INTO VaiTro (TenVaiTro)
VALUES 
(N'Admin'), 
(N'Nhân viên');
GO
-- Thêm dữ liệu cho bảng NhaXuatBan
INSERT INTO NhaXuatBan (TenNXB)
VALUES 
(N'NXB Trẻ'),
(N'NXB Kim Đồng'),
(N'NXB Giáo Dục Việt Nam'),
(N'NXB Văn Học'),
(N'NXB Lao Động'),
(N'NXB Tổng Hợp TP.HCM'),
(N'NXB Hội Nhà Văn'),
(N'NXB Chính Trị Quốc Gia'),
(N'NXB Dân Trí'),
(N'NXB Phụ Nữ Việt Nam');
GO
-- Thêm dữ liệu cho bảng TacGia
INSERT INTO TacGia (TenTG)
VALUES 
(N'Nguyễn Nhật Ánh'),
(N'J.K. Rowling'),
(N'George Orwell'),
(N'Yuval Noah Harari'),
(N'Nguyễn Văn Dân'),
(N'Paulo Coelho'),
(N'Gabriel García Márquez'),
(N'Dan Brown'),
(N'Isaac Asimov'),
(N'Erich Fromm');
GO
-- Thêm dữ liệu cho bảng TheLoai
INSERT INTO TheLoai (TenTL)
VALUES 
(N'Văn học Việt Nam'),
(N'Văn học nước ngoài'),
(N'Khoa học viễn tưởng'),
(N'Tâm lý học'),
(N'Kinh tế học'),
(N'Giáo dục'),
(N'Thể thao'),
(N'Kỹ năng sống'),
(N'Lịch sử'),
(N'Tôn giáo');
GO
-- Thêm dữ liệu cho bảng NhaCungCap
INSERT INTO NhaCungCap (TenNCC)
VALUES 
(N'Công ty Fahasa'),
(N'Công ty Phương Nam'),
(N'Công ty Văn Hóa Sài Gòn'),
(N'Công ty Sách Alpha'),
(N'Công ty Sách Minh Long'),
(N'Công ty Sách Đông A'),
(N'Công ty Sách Nhã Nam'),
(N'Công ty Sách Tân Việt'),
(N'Công ty Sách Huy Hoàng'),
(N'Công ty Sách Tri Thức');
GO

-- Thêm dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (HoTen, SoDienThoai, Email, MatKhau, IdVaiTro)
VALUES
(N'Võ Thành Hoàng Phúc', N'0123456789', N'phucphuc2004444@gmail.com', HASHBYTES('SHA2_256', 'Hoangphuc@123'), 1),
(N'Võ Thành Hoàng Phúc', N'0987654321', N'phucphucvo2004444@gmail.com', HASHBYTES('SHA2_256', 'Hoangphuc@123'), 2);

GO
-- Thêm dữ liệu cho bảng Sach
INSERT INTO Sach (TenSach, IdNXB, NamXuatBan)
VALUES 
(N'Tôi thấy hoa vàng trên cỏ xanh', 1, 2010),
(N'Harry Potter và Hòn đá phù thủy', 2, 2001),
(N'1984', 4, 1949),
(N'Sapiens: Lược sử loài người', 6, 2014),
(N'Một đời thương thuyết', 3, 2017),
(N'Nhà giả kim', 7, 1988),
(N'Trăm năm cô đơn', 5, 1967),
(N'Mật mã Da Vinci', 8, 2003),
(N'Nền văn minh vũ trụ', 9, 1951),
(N'Tự do hay là chết', 10, 1941),
(N'Tiếng gọi nơi hoang dã', 2, 1903),
(N'Chạng vạng', 3, 2005),
(N'The Great Gatsby', 4, 1925),
(N'Trăm năm yêu thương', 5, 2000),
(N'Lược sử thời gian', 6, 1988),
(N'Hoàng tử bé', 7, 1943),
(N'Tội ác và hình phạt', 8, 1866),
(N'Cuốn theo chiều gió', 9, 1936),
(N'Chí Phèo', 1, 1941),
(N'Dế mèn phiêu lưu ký', 1, 1942),
(N'Bố già', 5, 1969),
(N'Thuật xử thế', 6, 1936),
(N'Nghệ thuật đàm phán', 10, 1991),
(N'Tâm lý học đám đông', 4, 1895),
(N'Phía Tây không có gì lạ', 8, 1929),
(N'Một thoáng ta rực rỡ ở nhân gian', 9, 2019),
(N'Cô gái đến từ hôm qua', 1, 1990),
(N'Hạt giống tâm hồn', 6, 1999),
(N'Làng', 1, 1948);

GO
-- Thêm dữ liệu cho bảng KhachHang
INSERT INTO KhachHang (HoTenKH, Email, SoDienThoai, DiaChi)
VALUES 
(N'Trần Văn An', N'vana@example.com', N'0901234567', N'123 Đường Trần Hưng Đạo, Quận 1, TP.HCM'),
(N'Nguyễn Thị Hồng Nhung', N'nthn@example.com', N'0902345678', N'456 Đường Lý Thái Tổ, Quận 3, TP.HCM'),
(N'Lê Văn Chí', N'lvc@example.com', N'0903456789', N'789 Đường Lý Thường Kiệt, Quận 5, TP.HCM'),
(N'Phạm Thị Thùy Dương', N'ptd@example.com', N'0904567890', N'123 Đường Nguyễn Văn Linh, Quận 7, TP.HCM'),
(N'Hoàng Văn Thụ', N'hve@example.com', N'0905678901', N'456 Đường 3/2, Quận 10, TP.HCM'),
(N'Vũ Thị Cẩm', N'vtf@example.com', N'0906789012', N'789 Đường Xô Viết Nghệ Tĩnh, Quận Bình Thạnh, TP.HCM'),
(N'Đặng Văn Giàu', N'dvg@example.com', N'0907890123', N'123 Đường Lê Trọng Tấn, Quận Tân Bình, TP.HCM'),
(N'Bùi Thị Hồng', N'bth@example.com', N'0908901234', N'456 Đường An Thạnh, Quận Phú Nhuận, TP.HCM'),
(N'Đỗ Văn Kiệt', N'dvi@example.com', N'0909012345', N'789 Đường Phạm Văn Đồng, Quận Gò Vấp, TP.HCM'),
(N'Nguyễn Thị Thập', N'ntj@example.com', N'0900123456', N'123 Đường Võ Chí Công, Quận 2, TP.HCM');
GO
INSERT INTO Sach_TacGia (IdSach, IdTacGia)
VALUES 
(1, 1), -- Nguyễn Nhật Ánh
(2, 2), -- J.K. Rowling
(3, 3), -- George Orwell
(4, 4), -- Yuval Noah Harari
(5, 5), -- Nguyễn Văn Dân
(6, 6), -- Paulo Coelho
(7, 7), -- Gabriel García Márquez
(8, 8), -- Dan Brown
(9, 9), -- Isaac Asimov
(10, 10), -- Erich Fromm
(11, 3),
(12, 2),
(13, 5),
(14, 7),
(15, 9),
(16, 6),
(17, 1),
(18, 5),
(19, 8),
(20, 1),
(21, 1),
(22, 7),
(23, 10),
(24, 10),
(25, 4),
(26, 4),
(27, 8),
(28, 1),
(29, 6);
GO
-- Thêm dữ liệu cho bảng Sach_TheLoai (liên kết sách với thể loại)
INSERT INTO Sach_TheLoai (IdSach, IdTheLoai)
VALUES 
(1, 1), -- Văn học Việt Nam
(2, 2), -- Văn học nước ngoài
(3, 2), -- Văn học nước ngoài
(4, 9), -- Lịch sử
(5, 8), -- Kỹ năng sống
(6, 8), -- Kỹ năng sống
(7, 2), -- Văn học nước ngoài
(8, 3), -- Khoa học viễn tưởng
(9, 3), -- Khoa học viễn tưởng
(10, 4), -- Tâm lý học
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 3),
(16, 9),
(17, 2),
(18, 1),
(19, 3),
(20, 1),
(21, 1),
(22, 4),
(23, 8),
(24, 8),
(25, 4),
(26, 9),
(27, 2),
(28, 1),
(29, 6);
GO
-- Thêm dữ liệu cho bảng Sach_NhaCungCap (liên kết sách với nhà cung cấp)
INSERT INTO Sach_NhaCungCap (IdSach, IdNhaCungCap)
VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 1),
(12, 2),
(13, 3),
(14, 4),
(15, 5),
(16, 6),
(17, 7),
(18, 8),
(19, 9),
(20, 10),
(21, 1),
(22, 2),
(23, 3),
(24, 4),
(25, 5),
(26, 6),
(27, 7),
(28, 8),
(29, 9);
GO
-- Thêm dữ liệu cho bảng DonHang
INSERT INTO DonHang (IdKhachHang)
VALUES 
(1),
(2);

GO
-- Thêm dữ liệu cho bảng CT_DonHang (Chi tiết đơn hàng)
INSERT INTO CT_DonHang (IdDonHang, IdSach, IdTaiKhoan, DonGiaBan, SoLuongBan)
VALUES 
(1, 1, 1, 70000, 20),
(1, 2, 1, 90000, 10),
(2, 3, 2, 100000, 10),
(2, 4, 2, 120000, 30);

GO
-- Thêm dữ liệu cho bảng Kho
INSERT INTO Kho (IdSach, SoLuongTon)
VALUES 
(1, 100),
(2, 150),
(3, 200),
(4, 280),
(5, 120),
(6, 600),
(7, 500),
(8, 700),
(9, 400),
(10, 300),
(11, 350),
(12, 450),
(13, 250),
(14, 400),
(15, 700),
(16, 390),
(17, 980),
(19, 430),
(20, 110),
(21, 100),
(22, 520),
(23, 304),
(24, 256),
(25, 703),
(26, 801),
(27, 408),
(28, 954),
(29, 609);

GO
-- Thêm dữ liệu cho bảng PhieuNhapSach
INSERT INTO PhieuNhapSach (MaNCC)
VALUES 
(1),
(2);

GO
-- Thêm dữ liệu cho bảng CT_PhieuNhap (Chi tiết phiếu nhập)
INSERT INTO CT_PhieuNhap (MaPhieuNhap, MaSach, SoLuongNhap, DonGiaNhap, DonGiaBan)
VALUES 
(1, 1, 30, 50000, 70000),
(1, 2, 40, 60000, 90000),
(2, 3, 20, 70000, 100000),
(2, 4, 25, 85000, 120000);


 