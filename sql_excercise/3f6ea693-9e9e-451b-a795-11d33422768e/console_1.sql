create table Bophan (
    MaBP varchar(4) primary key not null,
    TenBP nvarchar(10) null,
)
create table Chucvu (
    MaCV nvarchar(4) primary key not null,
    TenCV nvarchar(20) null,
)
create table Nhanvien (
    MaNV int primary key not null,
    HoNV nvarchar(10) null,
    TenNV nvarchar(6) null,
    Luong int null,
    Phai tinyint null,
    NgaySinh SMALLDATETIME,
    MaCV nvarchar(4) not null,
    MaBP varchar(4) not null,
    constraint fk_MaChucVu foreign key (MaCV) references Chucvu(MaCV) on UPDATE cascade ,
    constraint fk_MaBoPhan foreign key (MaBP) references Bophan(MaBP) on UPDATE cascade,
)

ALTER TABLE Chucvu
ALTER COLUMN TenCV NVARCHAR(50) NOT NULL;
insert into Chucvu values
('AP', N'Phụ tá cho lập trình viên'),
('MGR',N'Trưởng phòng'),
('P',N'Lập trình viên'),
('SA',N'Phân tích viên hệ thống'),
('SP', N'Lập trình viên cao cấp'),
('SSA', N'Phân tích viên hệ thống cao cấp');
insert into Bophan values
('ACCT', N'Kế toán'),
('BUDG', N'Thủ quỹ'),
('PERS', N'Nhân sự');
insert into Nhanvien (MaNV, HoNV, TenNV, Luong, Phai, NgaySinh, MaCV, MaBP) values
(12000, N'Từ Thổn', N'Thức', 54000, 0, '1980-07-07', 'MGR', 'ACCT'),
(12345, N'Trần Văn', N'Tẻo', 32000, 0, '1974-08-11', 'SA', 'BUDG'),
(23456, N'Lê Lưu', N'Luyến', 35500, 1, '1975-02-13', 'SSA', 'BUDG'),
(32456, N'Nguyễn Văn', N'Hậu', 28000, 0, '1977-11-01', 'SP', 'BUDG'),
(30004, N'Trần Thanh', N'Thanh', 51000, 1, '1967-02-19', 'MGR', 'PERS'),
(43214, N'Thái Văn', N'Thoại', 28500, 0, '1978-02-15', 'SP', 'PERS'),
(43223, N'Lý Văn', N'Nghĩa', 30000, 0, '1969-12-09', 'SSA', 'PERS');
