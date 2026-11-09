create table NHACUNGCAP (
    MANCC varchar(5) primary key not null,
    TENNCC nvarchar(50) not null,
    DIACHI nvarchar(100) null,
    DIENTHOAI varchar(15) unique,
)
create table LOAIHANG (
    MALOAI varchar(5) primary key not null,
    TENLOAI nvarchar(50) not null
)
create table HANGHOA (
    MAHH varchar(5) primary key not null,
    TENHH nvarchar(50) not null,
    MALOAI varchar(5) not null,
    DONGIA decimal(18,2) check (DONGIA > 0),
    SOLUONG int default 0 check (SOLUONG>=0),
    constraint fk_MaLoai foreign key (MALOAI) references LOAIHANG(MALOAI),
)
create table PHIEUNHAP (
    MAPN varchar(5) primary key not null,
    MANCC varchar(5) not null,
    NGAYNHAP date default getdate(),
    GHICHU nvarchar(100) null,
    constraint fk_MaNcc foreign key (MANCC) references NHACUNGCAP(MANCC),
)

INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI, DIENTHOAI)
VALUES
('NCC01', N'Công ty An Phát', N'Hà Nội', '0901234567'),
('NCC02', N'Công ty Minh Long', N'Hải Phòng', '0912345678'),
('NCC03', N'Công ty Hoàng Gia', N'Đà Nẵng', '0923456789');
INSERT INTO LOAIHANG (MALOAI, TENLOAI)
VALUES
('LH001', N'Điện tử'),
('LH002', N'Gia dụng');
INSERT INTO HANGHOA (MAHH, TENHH, MALOAI, DONGIA, SOLUONG)
VALUES
('HH001', N'Laptop Dell Inspiron', 'LH001', 15000000, 10),
('HH002', N'Chuột Logitech G102', 'LH001', 350000, 25),
('HH003', N'Nồi cơm điện Sharp', 'LH002', 1200000, 15),
('HH004', N'Quạt điện Panasonic', 'LH002', 850000, 20);
INSERT INTO PHIEUNHAP (MAPN, MANCC, NGAYNHAP, GHICHU)
VALUES
('PN001', 'NCC01', '2026-10-20', N'Nhập hàng điện tử'),
('PN002', 'NCC02', '2026-10-22', N'Nhập hàng gia dụng'),
('PN003', 'NCC03', '2026-10-25', N'Nhập hàng bổ sung');

create view V_DANHSACHHANG as
    SELECT MAHH,TENLOAI,DONGIA,SOLUONG FROM HANGHOA, LOAIHANG