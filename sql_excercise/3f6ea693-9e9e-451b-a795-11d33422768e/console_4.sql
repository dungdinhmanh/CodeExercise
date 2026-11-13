create table KHACHHANG (
    MAKHACHHANG char(10) not null primary key,
    TENCONGTY nvarchar(100) null,
    TENGIAODICH nvarchar(100) null,
    DIACHI nvarchar(200) null,
    EMAIL varchar(100) null,
    DIENTHOAI varchar(20) null,
    FAX varchar(20) null
);
create table LOAIHANG (
    MALOAIHANG char(10) not null primary key,
    TENLOAIHANG nvarchar(100) null,
);
create table NHACUNGCAP (
    MACONGTY char(10) not null primary key,
    TENCONGTY nvarchar(100) null,
    TENGIAODICH nvarchar(100) null,
    DIACHI nvarchar(200) null,
    EMAIL varchar(100) null,
    DIENTHOAI varchar(20) null,
    FAX varchar(20) null
);
create table NHANVIEN (
    MANHANVIEN char(10) not null primary key,
    HO nvarchar(50),
    TEN nvarchar(50),
    NGAYSINH date,
    NGAYLAMVIEC date,
    DIACHI nvarchar(200),
    DIENTHOAI varchar(20),
    LUONGCOBAN decimal(18,2),
    PHUCAP decimal(18,2)
);
create table MATHANG (
    MAHANG char(10) not null primary key,
    TENHANG nvarchar(100) null,
    MACONGTY char(10) not null,
    MALOAIHANG char(10) not null,
    SOLUONG int null,
    DONVITINH nvarchar(50) null,
    GIAHANG decimal(18,2) null,
    constraint fk_MaCT foreign key (MACONGTY) references NHACUNGCAP(MACONGTY) on UPDATE cascade,
    constraint fk_MaLoaiHang foreign key (MALOAIHANG) references LOAIHANG(MALOAIHANG) on UPDATE cascade,
);
create table DONDATHANG (
    SOHOADON char(10) not null primary key,
    MAKHACHHANG char(10) not null,
    MANHANVIEN char(10) not null,
    NGAYDATHANG date null,
    NGAYGIAOHANH date null,
    NGAYCHUYENHANG date null,
    NOIGIAOHANG nvarchar(200) null,
    constraint fk_MaKH foreign key (MAKHACHHANG) references KHACHHANG(MAKHACHHANG) on UPDATE cascade,
    constraint fk_MaNV foreign key (MANHANVIEN) references NHANVIEN(MANHANVIEN) on UPDATE cascade
);
create table CHITIETDATHANG (
    SOHOADON char(10) not null,
    MAHANG char(10) not null,
    GIABAN decimal(18,2) null,
    SOLUONG int null,
    MUCGIAMGIA decimal(5,2) null,
    constraint fk_SoHD foreign key (SOHOADON) references DONDATHANG(SOHOADON) on UPDATE cascade,
    constraint fk_MaHang foreign key (MAHANG) references MATHANG(MAHANG) on UPDATE cascade,
);

Insert Into LOAIHANG VALUES
('LH01', N'Thực phẩm'),
('LH02', N'Dệt may'),
('LH03', N'Sữa & Đồ uống'),
('LH04', 'Vật tư');
insert into KHACHHANG values
('KH01', N'Công ty Sữa Việt', 'VINAMILK', '123 Lê Lợi, HN', 'contact@vinamilk.vn', '024-123456', '024-111111'),
('KH02', N'Công ty Dệt May', 'VIETTIEN', N'45 Trần Phú, HN', 'sales@viettien.vn', '024-222222', NULL),
('KH03', N'Cửa hàng ABC', 'ABC-STORE', N'78 Hai Bà Trưng, HCM', 'abc@store.vn', '028-333333', '028-333334'),
('KH04', N'Công ty Thực Phẩm', 'FOODCO', N'9 Nguyễn Huệ, HCM', 'info@foodco.vn', '028-444444', NULL),
('KH05', N'Công ty Hợp nhất', 'VINAMIX', N'200 Đường A, HN', 'vinamix@vn', '024-555555', NULL),
('KH06', N'Công ty Cung Ứng Chung', 'SUPPLYCO', N'10 Bùi Thị Xuân, HN', 'supplyco@vn', '024-666666', '024-666667'),
('KH07', N'Khách Vãng Lai', 'VANGLAI', N'50 Phố X, HN', 'vl@vn', '024-777777', NULL);
INSERT INTO MATHANG VALUES
('MH01', N'Sữa Hộp Cao Cấp', 'NCC01', 'LH03', 120, N'Hộp', 150000),
('MH02', N'Sữa Bột Trẻ Em', 'NCC05', 'LH03', 40, N'Gói', 250000),
('MH03', N'Áo Thun Nam', 'NCC02', 'LH02', 200, N'Cái', 120000),
('MH04', N'Bánh Quy', 'NCC03', 'LH01', 30, N'Hộp', 50000),
('MH05', N'Kẹo Dẻo', 'NCC04', 'LH04', 0, N'Chai', 20000),
('MH06', N'Sữa Chua Ly', 'NCC01', 'LH03', 80, N'Hộp', 80000);
INSERT INTO NHACUNGCAP VALUES
('NCC01', N'Công ty Sữa Việt', 'VINAMILK', N'123 Lê Lợi, HN', '024-123456', '024-111111', 'sup@vinamilk.vn'),
('NCC02', N'Công ty Dệt May', 'VIETTIEN', N'45 Trần Phú, HN', '024-222222', NULL, 'contact@viettien.vn'),
('NCC03', N'Công ty Thực Phẩm', 'FOODCO', N'9 Nguyễn Huệ, HCM', '028-444444', NULL, 'supply@foodco.vn'),
('NCC04', N'Công ty Cung Ứng Chung', 'SUPPLYCO', N'10 Bùi Thị Xuân, HN', '024-666666', '024-666667', 'supplyco@vn'),
('NCC05', N'Công ty Sữa Nhỏ', 'MINI-MILK', N'77 Phố Y, HN', '024-888888', NULL, 'mini@milk.vn');
INSERT INTO NHANVIEN VALUES
('NV01', N'Nguyễn', N'An', '1970-05-15', '1985-06-01', N'1 A St, HN', '024-900001', 5000000, 500000),
('NV02', N'Trần', N'Bình', '1980-07-20', '2002-03-15', N'2 B St, HN', '024-900002', 4500000, 300000),
('NV03', N'Lê', N'Chi', '1985-07-20', '2003-01-10', N'3 C St, HN', '024-900003', 4000000, 200000),
('NV04', N'Phạm', N'Dũng', '1982-01-01', '1999-09-01', N'4 D St, HN', '024-900004', 3500000, 100000),
('NV05', N'Huỳnh', N'Em', '1980-07-20', '2005-05-01', N'5 E St, HN', '024-900005', 4200000, 250000);
INSERT INTO DONDATHANG VALUES
(1, 'KH01', 'NV01', '20060110', '20060115', NULL, N'Văn phòng KH01'),
(2, 'KH02', 'NV02', '20030520', '20030525', '20030524', N'Xưởng VIETTIEN'),
(3, 'KH03', 'NV02', '20060305', '20060309', NULL, N'Kho ABC'),
(4, 'KH01', 'NV03', '20061230', '20070102', '20070101', N'Nhà KH01'),
(5, 'KH04', 'NV01', '19991111', '19991115', '19991114', N'Kho FOODCO'),
(6, 'KH06', 'NV01', '20060610', '20060612', NULL, NULL),
(7, 'KH02', 'NV05', '20020909', '20020912', '20020911', N'Văn phòng VIETTIEN');
INSERT INTO CHITIETDATHANG VALUES
(1, 'MH01', 150000, 10, 5),
(1, 'MH06', 80000, 20, 0),
(2, 'MH03', 120000, 5, 0),
(3, 'MH01', 150000, 2, 0),
(3, 'MH04', 50000, 10, 10),
(4, 'MH02', 250000, 1, 0),
(5, 'MH04', 50000, 3, 0),
(6, 'MH05', 20000, 10, 0),
(7, 'MH03', 120000, 2, 0);

--13
Select KH.TENCONGTY, NCC.TENCONGTY
from KHACHHANG KH, NHACUNGCAP NCC
where KH.TENGIAODICH = NCC.TENGIAODICH
--14
Select (A.HO + ' ' + A.TEN) AS HOTEN, A.NGAYSINH
from NHANVIEN A, NHANVIEN B
where A.NGAYSINH = B.NGAYSINH and A.MANHANVIEN <> B.MANHANVIEN
--15

--16
SELECT TENCONGTY, TENGIAODICH, DIACHI, DIENTHOAI
FROM KHACHHANG
UNION
SELECT TENCONGTY, TENGIAODICH, DIACHI, DIENTHOAI
FROM NHACUNGCAP;