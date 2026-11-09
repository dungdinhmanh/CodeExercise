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
()