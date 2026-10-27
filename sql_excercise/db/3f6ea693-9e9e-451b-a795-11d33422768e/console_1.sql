create table KhackHang (
    MaKH VARCHAR(5) PRIMARY KEY NOT NULL,
    TenKH NVARCHAR(50) not null ,
    DiaChi NVARCHAR(50) null ,
    SoDT VARCHAR(11) null
);
create table LoaiSanPham (
    MaLoai VARCHAR(5) primary key not null,
    TenLoai NVARCHAR(10) NULL,
);
create table SanPham (
    MaSP VARCHAR(5) primary key not null,
    TenSP NVARCHAR(50) not null,
    DonGia INT NULL,
    SoLuong int null,
    MaLoai VARCHAR (5) not null,
    constraint fk_MaLoai foreign key (MaLoai) references LoaiSanPham(MaLoai)
);
create table HoaDon (
    MaHD VARCHAR(5) primary key not null,
    NgayLap DATE NOT NULL,
    MaKH VARCHAR(5) NOT NULL,
    constraint fk_MaKH foreign key (MaKH) references KhackHang(MaKH),
);
create table ChiTietHD (
    MaHD VARCHAR(5) NOT NULL,
    MaSP VARCHAR(5) not null,
    constraint fk_MaHD foreign key (MaHD) references HoaDon(MaHD),
    constraint fk_MaSP foreign key (MaSP) references SanPham(MaSP),
    SoLuong int
)