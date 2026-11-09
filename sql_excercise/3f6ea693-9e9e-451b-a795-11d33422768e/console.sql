create table KHACHHANG (
    MAKH VARCHAR(9) not null primary key,
    HOTEN nvarchar(50) null,
    NGAYSINH SMALLDATETIME NULL ,
    DIACHI NVARCHAR(100) null,
    CMND VARCHAR(12) NULL,
)
create table TAIKHOAN (
    MATK varchar(9) not null primary key,
    MAKH varchar(9) null,
    LOAITK nvarchar(20) null,
    SODU FLOAT NULL,
    NGAYMO smalldatetime null,
    constraint fk_MAKH foreign key (MAKH) references KHACHHANG(MAKH)
)
create table NHANVIEN (
    MANV varchar(9) not null primary key,
    HOTEN nvarchar(50) null,
    CHUCVU nvarchar(30) null,
    LUONG float null,
)
create table GIAODICH (
    MAGD varchar(9) not null primary key,
    MATK varchar(9) null,
    MANV varchar(9) null,
    NGAYGD smalldatetime null,
    LOAIGD nvarchar(20) null,
    SOTIEN float null,
    constraint fk_MaTK foreign key (MATK) references TAIKHOAN(MATK),
    constraint fk_MaNV foreign key (MANV) references NHANVIEN(MANV)
)

INSERT INTO KHACHHANG (MAKH, HOTEN, NGAYSINH, DIACHI, CMND) VALUES
('KH001', N'Nguyễn Văn An', '1990-05-15', N'123 Nguyễn Trãi, Quận 5, TP.HCM', '079090001234'),
('KH002', N'Trần Thị Bích', '1995-09-20', N'456 Lê Lợi, Quận 1, TP.HCM', '079095005678'),
('KH003', N'Lê Hoàng Nam', '1988-12-02', N'789 Cách Mạng Tháng 8, Tân Bình, TP.HCM', '079088009012'),
('KH004', N'Phạm Minh Thư', '2000-01-25', N'12 Đại Lộ Bình Dương, Thủ Dầu Một, Bình Dương', '065000003456'),
('KH005', N'Vũ Hoàng Long', '1993-07-08', N'34 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '001093007890');
INSERT INTO TAIKHOAN (MATK, MAKH, LOAITK, SODU, NGAYMO) VALUES
('TK001', 'KH001', N'Thanh toán', 5000000, '2020-01-10'),
('TK002', 'KH001', N'Tiết kiệm', 150000000, '2021-06-15'),
('TK003', 'KH002', N'Thanh toán', 2350000, '2022-03-22'),
('TK004', 'KH003', N'Thanh toán', 89000000, '2019-11-05'),
('TK005', 'KH004', N'Tiết kiệm', 50000000, '2025-08-14');
INSERT INTO NHANVIEN (MANV, HOTEN, CHUCVU, LUONG) VALUES
('NV001', N'Nguyễn Minh Triết', N'Giao dịch viên', 12000000),
('NV002', N'Lê Thị Hồng', N'Giao dịch viên', 12500000),
('NV003', N'Phạm Thành Nam', N'Kiểm soát viên', 18000000),
('NV004', N'Hoàng Đình Bảo', N'Quản lý chi nhánh', 30000000),
('NV005', N'Đặng Mỹ Linh', N'Giao dịch viên', 11500000);
INSERT INTO GIAODICH (MAGD, MATK, MANV, NGAYGD, LOAIGD, SOTIEN) VALUES
('GD001', 'TK001', 'NV001', '2026-01-15 09:30:00', N'Nạp tiền', 2000000),
('GD002', 'TK001', 'NV001', '2026-02-20 14:15:00', N'Rút tiền', 500000),
('GD003', 'TK003', 'NV002', '2026-03-10 10:00:00', N'Chuyển khoản', 1200000),
('GD004', 'TK004', 'NV002', '2026-05-05 16:45:00', N'Nạp tiền', 10000000),
('GD005', 'TK002', 'NV003', '2026-06-18 11:20:00', N'Rút gốc tiết kiệm', 50000000);

