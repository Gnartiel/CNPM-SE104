create database QLPM
use QLPM
set dateformat DMY
-----------------------------------TABLE NHANVIEN------------------------------------------------------
CREATE TABLE NHANVIEN
(
	MaNhanVien char(5) not null,
	HoTenNhanVien nvarchar(50),
	TenDangNhap varchar(20),
	MatKhau varchar(20),
	LoaiNV char(10),
)
ALTER TABLE NHANVIEN ADD
CONSTRAINT NV_MaNhanVien_PK PRIMARY KEY (MaNhanVien)
-----------------------------------TABLE PHANQUYEN------------------------------------------------------
CREATE TABLE PHANQUYEN
(
	MaLoai char(5) not null,
	Quyen nvarchar(30),
	DoiTuong nvarchar(50),
)
ALTER TABLE PHANQUYEN ADD CONSTRAINT PQ_Loai_PK PRIMARY KEY (MaLoai)

-----------------------------------TABLE BENHNHAN------------------------------------------------
CREATE TABLE BENHNHAN
(
	MaBenhNhan char(5) not null,
	HoTenBenhNhan nvarchar(50),
	GioiTinh nvarchar(3),
	NamSinh smallint,
	DiaChi nvarchar(100),
)
ALTER TABLE BENHNHAN ADD
CONSTRAINT BN_MaBenhNhan_PK PRIMARY KEY (MaBenhNhan)
select * from BENHNHAN

-----------------------------------TABLE DONVI------------------------------------------------
CREATE TABLE DONVI
(
	MaDonVi char(5) not null,
	TenDonVi nvarchar(10),
)
ALTER TABLE DONVI ADD
CONSTRAINT DV_MaDonVi_PK PRIMARY KEY (MaDonVi)

-----------------------------------TABLE CACHDUNG--------------------------------------------------
CREATE TABLE CACHDUNG
(
	MaCachDung char(5) not null,
	TenCachDung nvarchar(20),
)
ALTER TABLE CACHDUNG ADD
CONSTRAINT CD_MaCachDung_PK PRIMARY KEY (MaCachDung)

-----------------------------------TABLE THUOC-------------------------------------------------
CREATE TABLE THUOC
(
	MaThuoc char(5)not null,
	TenThuoc varchar(30) not null,
	MaDonVi char(5),
	MaCachDung char(5),
	CongDung nvarchar(200),
	HuongDanSuDung nvarchar(200),
	SoLuongTon int,
	DonGiaBan int,
)

ALTER TABLE THUOC ADD 
CONSTRAINT TH_MaThuoc_PK PRIMARY KEY (MaThuoc),
CONSTRAINT TH_MaDV_FK FOREIGN KEY (MaDonVi) REFERENCES DONVI(MaDonVi),
CONSTRAINT TH_MaCD_FK FOREIGN KEY (MaCachDung) REFERENCES CACHDUNG(MaCachDung)

-----------------------------------TABLE PHIEUKHAMBENHBENH-------------------------------------------------
CREATE TABLE PHIEUKHAMBENH
(
	MaPhieuKhamBenh char(5) not null,
	MaBenhNhan char (5),
	NgayKham smalldatetime,
	TrieuChung nvarchar(50),
	TienKham int,
	TienThuoc int,
	TongTien int,
)update PHIEUKHAMBENH set TienKham=2, TongTien=30000 where MaPhieuKhamBenh='PK011'
select * from PHIEUKHAMBENH
ALTER TABLE PHIEUKHAMBENH ADD
CONSTRAINT PK_MaPhieuKhamBenh_PK PRIMARY KEY (MaPhieuKhamBenh),
CONSTRAINT PK_MaBN_FK FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan)


-----------------------------------TABLE CT_PHIEUKHAMBENHBENH---------------------------------------------------
CREATE TABLE CT_PHIEUKHAMBENH
(
	MaPhieuKhamBenh char(5) not null,
	MaThuoc char(5) not null,
	SoLuong int,
	LieuDung nvarchar(100),
	ThanhTien int,
)
ALTER TABLE CT_PHIEUKHAMBENH ADD
CONSTRAINT PKB_MaThuoc_MaPK_PK PRIMARY KEY (MaPhieuKhamBenh, MaThuoc),
CONSTRAINT PKB_MaPhieuKhamBenh_FK FOREIGN KEY (MaPhieuKhamBenh) REFERENCES PHIEUKHAMBENH(MaPhieuKhamBenh),
CONSTRAINT PKB_MaThuoc_FK FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc)

-----------------------------------TABLE PHIEUNHAPTHUOC----------------------------------------------------
CREATE TABLE PHIEUNHAPTHUOC
(
	MaPhieuNhap char(5) not null,
	NgayNhap smalldatetime,
	SoLuong int,
	TongTienNhap bigint,
)
ALTER TABLE PHIEUNHAPTHUOC ADD
CONSTRAINT PNT_MaPhieuNhap_PK PRIMARY KEY (MaPhieuNhap)
SELECT * FROM PHIEUNHAPTHUOC;
-----------------------------------TABLE CT_PHIEUNHAPTHUOC-----------------------------------------------
CREATE TABLE CT_PHIEUNHAPTHUOC
(
	MaPhieuNhap char(5) not null,
	MaThuoc char(5) not null,
	SoLuong int,
	DonGiaNhap int,
	DonGiaVAT int,
	ThanhTienVAT bigint,
)
ALTER TABLE CT_PHIEUNHAPTHUOC ADD
CONSTRAINT CT_PNT_PK PRIMARY KEY (MaPhieuNhap, MaThuoc),
CONSTRAINT CT_PNT_MaPhieuNhap_FK FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAPTHUOC(MaPhieuNhap),
CONSTRAINT CT_PNT_MaThuoc_FK FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc)

-----------------------------------TABLE LOAIBENH-----------------------------------------------
CREATE TABLE LOAIBENH
(
	MaLoaiBenh char(5) not null,
	TenLoaiBenh nvarchar(30),
	TrieuChung nvarchar(200),
)
ALTER TABLE LOAIBENH ADD 
CONSTRAINT LB_PK PRIMARY KEY (MaLoaiBenh)
select * from LOAIBENH
-----------------------------------TABLE CT_BENH--------------------------------------------------
CREATE TABLE CT_BENH
(
	MaPhieuKhamBenh char(5) not null,
	MaLoaiBenh char(5) not null,
)
ALTER TABLE CT_BENH ADD
CONSTRAINT CT_BH_PK PRIMARY KEY (MaPhieuKhamBenh, MaLoaiBenh),
CONSTRAINT CT_BH_MaPhieuKhamBenh_FK FOREIGN KEY (MaPhieuKhamBenh) REFERENCES PHIEUKHAMBENH(MaPhieuKhamBenh),
CONSTRAINT CT_BH_MaLoaiBenh_FK FOREIGN KEY (MaLoaiBenh) REFERENCES LOAIBENH (MaLoaiBenh)

-----------------------------------TABLE BAOCAODOANHTHU-----------------------------------------------

CREATE TABLE BAOCAODOANHTHU
(
	Thang smallint not null,
	Nam smallint not null,
	TongDoanhThu int,
)
ALTER TABLE BAOCAODOANHTHU ADD
CONSTRAINT BCDT_NgayThangNam_PK PRIMARY KEY (Thang, Nam)
/*CONSTRAINT BCDT_Ngay_PK FOREIGN KEY (Thang),
CONSTRAINT BCDT_Thang_PK FORKEY (Nam)*/

-----------------------------------TABLE CT_BAOCAODOANHTHU---------------------------------------------------
CREATE TABLE CT_BAOCAODOANHTHU
(
	Ngay smallint not null,
	Thang smallint not null,
	Nam smallint not null,
	DoanhThu int,
	SoBenhNhan int,
	TyLe float(2),
)
ALTER TABLE CT_BAOCAODOANHTHU ADD
CONSTRAINT CT_BCDT_NgayThangNam_PK PRIMARY KEY (Ngay, Thang, Nam)
/*CONSTRAINT CT_BCDT_Ngay_PK PRIMARY KEY (Ngay),
CONSTRAINT CT_BCDT_Thang_PK PRIMARY KEY (Thang),
CONSTRAINT CT_BCDT_Nam_PK PRIMARY KEY (Nam)*/

-----------------------------------TABLE BAOCAOSUDUNGTHUOC-------------------------------------------------
CREATE TABLE BAOCAOSUDUNGTHUOC
(
	Thang smallint not null,
	Nam smallint not null,
	MaThuoc char(5) not null,
	SoLuongDung int,
	SoLanDung int,
)
ALTER TABLE BAOCAOSUDUNGTHUOC ADD
CONSTRAINT BCSDT_ThangNamThuoc_PK PRIMARY KEY (Thang, Nam, MaThuoc),
CONSTRAINT BCSDT_MaThuoc_FK FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc)

-----------------------------------TABLE THAMSO------------------------------------------------------
CREATE TABLE THAMSO
(
	TenThamSo varchar(50) not null,
	GiaTri float,
)
ALTER TABLE THAMSO ADD
CONSTRAINT TS_TenThamSo_PK PRIMARY KEY (TenThamSo)

DELETE FROM THAMSO
SET DATEFORMAT DMY
-----------------------------------VALUES THAMSO------------------------------------------------------
INSERT INTO THAMSO (TenThamSo, GiaTri)
VALUES (N'BNToiDa', 40)
INSERT INTO THAMSO (TenThamSo, GiaTri)
VALUES (N'TienKham', 30000)
INSERT INTO THAMSO (TenThamSo, GiaTri)
VALUES (N'ThangSoBanLe', 10)
INSERT INTO THAMSO (TenThamSo, GiaTri)
VALUES (N'VAT', 5)
select * from THAMSO
select HoTenBenhNhan,NgayKham,PHIEUKHAMBENH.TrieuChung
from BENHNHAN,PHIEUKHAMBENH
where HoTenBenhNhan=N'Hồ Thị Thu Thủy' and PHIEUKHAMBENH.MaBenhNhan=BENHNHAN.MaBenhNhan 
delete from PHIEUKHAMBENH where NgayKham='04/06/2022'
-----------------------------------TABLE NHANVIEN------------------------------------------------------
INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV)
VALUES('NV001',N'Nguyễn Thị Tú Vân',	'admin',	'123', N'Admin')
INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV)
VALUES('NV002',N'Lê Ngọc Mỹ Trang',	'tranglnm',	'tranglnm', N'BS')	
INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV)
VALUES('NV003',N'Nguyễn Lê Hương Lan',	'lannlh',	'lannlh', N'DS')
INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV)
VALUES('NV004',N'Phan Huyền Trang',	'trangph',	'trangph',N'KT')
INSERT INTO NHANVIEN (MaNhanVien,HoTenNhanVien, TenDangNhap, MatKhau, LoaiNV)
VALUES('NV005',N'Nguyễn Thị Thảo Vy',	'vyntt',	'vyntt',N'YT')

Select * from NHANVIEN


-----------------------------------VALUES PHANQUYEN------------------------------------------------------
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('DS', N'Danh Sách', N'Admin, BS, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('CD', N'Cài Đặt', N'Admin')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('KX', N'Kết Xuất', N'Admin, KT, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('TC', N'Tra Cứu', N'Admin, BS, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('BCDT', N'Báo Cáo Doanh Thu', N'Admin, KT')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('BCSDT', N'Báo Cáo Sử Dụng Thuốc', N'Admin, KT, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('BN', N'Bệnh Nhân', N'Admin, BS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('LB', N'Loại Bệnh', N'Admin, BS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('TH', N'Thuốc', N'Admin, BS, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('DVCD', N'Đơn Vị _ Cách Dùng', N'Admin, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('PKB', N'Phiếu Khám Bệnh', N'Admin, BS, DS')
INSERT INTO PHANQUYEN (MaLoai, Quyen, DoiTuong)
VALUES ('PNT', N'Phiếu Nhập Thuốc', N'Admin, BS, DS')

-----------------------------------VALUES BENHNHAN------------------------------------------------------
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN001',N'Hồ Thị Thu Thủy',	'1997', N'100 Lý Thường Kiệt, Phường 14, Quận 10, Hồ Chí Minh', N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN002',N'Nguyễn Văn Trường', '1998',N'212 Lý Thường Kiệt, Phường 14, Quận 10, Hồ Chí Minh',N'Nam')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN003',N'Trần Văn A',	'1976',N'33 Lý Chính Thắng, Phường 8, Quận 3, Tp Hồ Chí Minh',N'Nam')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN004',N'Võ Văn Hồng Nhật','1970', N'Tô Vĩnh Diện, Đông Hoà, Dĩ An, Bình Dương',N'Nam')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN005',N'Nguyễn Thị Thương', '2012',N'248 Lý Chính Thắng, Phường 9, Quận 3, Hồ Chí Minh',N'Nữ')	
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN006',N'Nguyễn Thị Hồng Tú','1988',N'87 Sư Vạn Hạnh, Phường 10, Quận 10, Hồ Chí Minh',N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN007',N'Trần Quốc Trung', '1998',N'Tô Vĩnh Diện, Đông Hoà, Dĩ An, Bình Dương', N'Nam')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN008',N'Nguyễn Thị Kiều Oanh',	'1996', N'Ba Tháng Hai, Xuân Khánh, Ninh Kiều, Cần Thơ', N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN009',N'Nguyễn Thị Ngọc Thùy',	'1998', N'Lãnh Tú, Xuân Lãnh, Đồng Xuân, Phú Yên', N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN010',N'Võ Thị Vân',	'1999',	N'Lãnh Trường , Xuân Lãnh, Đồng Xuân, Phú Yên', N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN011',N'Trần Đình Sỹ',	'1990',	N'133/123C Tô Hiến Thành, Phường 13, Quận 10, Hồ Chí Minh',N'Nam')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN012',N'Ngô Mỹ Anh',	'2005',	N'Phường Cầu Ông Lãnh, District 1, Ho Chi Minh City',N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN013',N'Trần Vân',	'1995',	N'484 Lê Văn Việt, Tăng Nhơn Phú A, Quận 9, Hồ Chí Minh',N'Nữ')
INSERT INTO BENHNHAN (MaBenhNhan,HoTenBenhNhan, NamSinh, DiaChi, GioiTinh)
VALUES('BN014',N'Nguyễn Song Nguyên', '1992',	N'121 Nguyễn Xí, phường 26, Bình Thạnh, Hồ Chí Minh',N'Nam')

-----------------------------------VALUES DONVI------------------------------------------------------
INSERT INTO DONVI (MaDonVi, TenDonVi)
VALUES ('DV001',N'Viên')
INSERT INTO DONVI (MaDonVi, TenDonVi)
VALUES ('DV002',N'Chai')

-----------------------------------VALUES CACHDUNG------------------------------------------------------
INSERT INTO CACHDUNG (MaCachDung, TenCachDung)
VALUES ('CD001', N'Uống')
INSERT INTO CACHDUNG (MaCachDung, TenCachDung)
VALUES ('CD002', N'Tiêm')
INSERT INTO CACHDUNG (MaCachDung, TenCachDung)
VALUES ('CD003', N'Ngậm')
INSERT INTO CACHDUNG (MaCachDung, TenCachDung)
VALUES ('CD004', N'Xịt')

-----------------------------------VALUES THUOC------------------------------------------------------
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH001','Telfast','DV001', 'CD001', N'Điều trị dị ứng theo mùa cho người lớn và trẻ em trên 12 tuổi',N'Uống với nước, uống trước khi ăn, không nên kết hợp với nước hoa quả',50,40700)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH002','Fexofenadine','DV001', 'CD001', N'Điều trị viêm mũi dị ứng',N'Dùng 30 mg cho trẻ uống hai lần một ngày',3,20000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH003','Augmentin',	'DV001', 'CD001', N'Thuốc kháng sinh điều trị bệnh nhiễm trùng',N'Uống thuốc với một cốc nước đầy. Uống ở đầu bữa ăn để tránh gây rối loạn tiêu hóa và dùng thuốc trong thời điểm cố định mỗi ngày',22,21000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH004','Augmental',	'DV001', 'CD003', N'Thuốc kháng sinh điều trị bệnh nhiễm trùng họng',N'Ngậm không quá 4 viên/ngày',0,30000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH005','Minoxidil',	'DV002', 'CD004', N'Điều trị rụng tóc ở mức độ trung bình',N'Xịt lên trung tâm da đầu cần điều trị',129,15000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH006','Paracetamol','DV001','CD001', N'Điều trị giảm đau, sốt từ nhẹ đến vừa',N'Không uống rượu khi đang dùng thuốc, tăng nguy cơ tổn thương gan',0,5000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH007','Feldene', 'DV001','CD001', N'Thuốc chống viêm không steroid, giảm đau, hạ sốt',N'Không nên nghiền nát hoặc bẻ vỡ trước khi uống',86,34600000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH008','Fenofibrat', 'DV001', 'CD001', N'Giảm Cholesterol, chất béo "xấu", tăng enzym phân hủy chất béo trong máu',N'Sử dụng đúng liều bác sĩ kê, không nghiền thuốc',0,8000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH009','Fenoprofen', 'DV001', 'CD001', N'Giảm cơn đau từ nhẹ đến trung bình, giảm sưng cứng viêm khớp',N'Đừng nằm xuống trong ít nhất 10 phút. Uống thuốc với thực phẩm, sữa hoặc thuốc kháng axit',2,30000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH010','Dacarbazine', 'DV002', 'CD002', N'Điều trị một số bệnh ung thư da di căn',N'Tiêm trong điều kiện vô khuẩn',56,64000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH011','Dantrolene', 'DV002', 'CD002', N'Điều trị căng cơ chuột rút do rối loạn thần kinh nhất định',N'Cần pha lọ bột tiêm với dung dịch vô khuẩn đi kèm sao cho nồng độ dung dịch tiêm đạt 0.333mg/ml',0,6483000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH012','Daptomycin', 'DV002', 'CD002', N'Điều trị các bệnh nhiễm trùng da, nhiễm khuẩn huyết, viêm nội tâm mạc',N'Tiêm vào tĩnh mạch',0,40700000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH013','Heparin', 'DV002', 'CD002', N'Phòng và điều trị huyết khối tĩnh mạch sâu, huyết khối nghẽn mạch phổi, nhồi máu cơ tim',N'Tiêm ở mô dưới da vùng bụng thắt kluwng phía trước và phía sau ở cả hai bên',0,24300)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH014','Ganirelix',	'DV001', 'CD002', N'Điều trị, ngăn ngừa vô sinh, kiểm soát sự rụng trứng tự do',N'Ganirelix được dùng thuận tiện nhất ở vùng bụng quanh rốn hoặc đùi trên',0,2170000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH015','Kaleorid',	'DV001','CD001', N'Thuốc điện giải bổ sung Kali',N'Uống cả viên thuốc với 1 ly nước đầy',12,17000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH016','Panadol', 'DV001','CD001', N'Hạ sốt, giảm đau đầu, đau cơ, đau họng',N'Uống ba bữa trong ngày và sau khi ăn',11,15000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH017','Migrin', 'DV001', 'CD001', N'Giảm đau đầu, điều trị rối loạn tiền đình, thiếu máu não',N'Dùng sau bữa ăn',0,86540000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH018','Methylen', 'DV002', 'CD001', N'Điều trị methemoglobin-huyết, ngộ độc cyanid, bệnh do virus herpes, chốc lở',N'Sau bữa ăn, uống với ly nước đầy',29,24300000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH019','Methionin',	'DV001', 'CD001', N'Cải thiện làm lành vết thương',N'Uống với nước, trong bữa ăn hoặc khi no',0,8000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH020','Dimercaprol', 'DV002', 'CD002',N'Điều trị ngộ độc kim loại nặng',N'Tiêm ngay khi nhiễm kim loại nặng',0,500000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH021','Deferoxamin mesylat', 'DV001', 'CD002', N'Điều trị tình trạng tích luỹ nhôm',N'Tiêm bắp 1 g lúc đầu, sau dùng tiếp 2 liều 0,5 g, cách nhau 4 giờ',11,1265000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH022','Atropin sulfat', 'DV002', 'CD002', N'Làm giảm co thắt & tăng động trong các bệnh lý đường tiêu hóa & tiết niệu',N'Dùng khi xảy ra tình trạng co thắt đường tiêu hóa hoặc đường niệu',36,1569000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH023','Promethazin hydroclorid', 'DV001', 'CD001', N'Dùng để chữa triệu chứng hoặc đề phòng các phản ứng quá mẫn',N'Dùng sau bữa ăn',38,60000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH024','Prednisolon', 'DV001', 'CD001', N'Có tác dụng giảm viêm',N'Uống kèm với thức ăn, để không gây ảnh hưởng đến dạ dày và giấc ngủ của bạn',61,64600000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH025','Methylprednisolon',	'DV001', 'CD001', N'Kháng viêm, chống dị ứng và ức chế miễn dịch',N'Uống sau bữa ăn',37,69000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH026','Dexamethason', 'DV001',	'CD001', N'Kháng viêm, kháng dị ứng và ức chế miễn dịch',N'Sử dụng giữa các liều cách nhau ít nhất 6 tiếng',5,20000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH027','Clorpheniramin maleat',	'DV001', 'CD001', N'Dị ứng ngoài da như mày đay, eczema, dị ứng đường hô hấp như sổ mũi, ngạt mũi',N' Uống thuốc với thực phẩm, sữa',19,58000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH028','Alimemazin', 'DV001', 'CD001', N'Điều trị các phản ứng quá mẫn như dị ứng hô hấp, tình trạng sảng rượu cấp',N'Dùng từ 2-3 viên khi xuất hiện tình trạng bệnh',50,28000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH029','Midazolam',	'DV002', 'CD002', N'Có tác dụng ngắn được dùng trong gây mê',N'Sử dụng dựa theo chỉ định của bác sĩ',28,2840000)
INSERT INTO THUOC (MaThuoc, TenThuoc, MaDonVi, MaCachDung, CongDung, HuongDanSuDung, SoLuongTon, DonGiaBan)
VALUES('TH030','Lactulose',	'DV001', 'CD001', N'thường được dùng để tạo phân mềm ở người bị táo bón',N'Uống thuốc vào buổi sáng',3,129000)

-----------------------------------VALUES PHIEUKHAMBENH------------------------------------------------------
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK001','BN001','12/05/2022',N'Các khớp thường xuyên sưng tấy, viêm đỏ', 30000, 2182950, 2212950)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK002','BN005','12/08/2021',N'Thường xuyên xuất hiện ảo giác', 30000, 912450, 942450)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK003','BN006','12/01/2022',N'Các khớp thường xuyên sưng tấy, viêm đỏ', 30000, 439613790, 439643790)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK004','BN007','1/05/2022',N'Thường xuyên khó thở, thở gấp', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK005','BN008','12/05/2020',N'Tim đập nhanh thường xuyên', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK006','BN012','18/05/2022',N'Các khớp thường xuyên sưng tấy, viêm đỏ', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK007','BN003','12/10/2021',N'Tim đập nhanh thường xuyên', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK008','BN010','12/01/2020',N'Các khớp thường xuyên sưng tấy, viêm đỏ', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK009','BN004','16/05/2021',N'Thường xuyên khó tiêu', 30000, 0, 30000)
INSERT INTO PHIEUKHAMBENH (MaPhieuKhamBenh, MaBenhNhan, NgayKham, TrieuChung, TienKham, TienThuoc, TongTien)
VALUES ('PK010','BN009','1/05/2020',N'Tim đập nhanh thường xuyên', 30000, 0, 30000)

-----------------------------------VALUES CT_PHIEUKHAMBENH------------------------------------------------------
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK001', 'TH001', 15, N'1 viên/lần, uống sáng-trưa-chiều, sau khi ăn no', 346500)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK001', 'TH002', 10, N'30mg/lần, uống sáng-chiều, sau khi ăn no', 231000)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK001', 'TH026', 5, N'1 viên/lần, uống sáng-chiều, sau khi ăn no', 115500 )
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK001', 'TH030', 10, N'1 viên/lần, uống sáng, sau khi ăn no', 1489950)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK002', 'TH001', 1, N'1 viên/lần, uống sáng-trưa-chiều, sau khi ăn no', 23100)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK002', 'TH009', 15, N'1 viên/lần, uống sáng-trưa-chiều, sau khi ăn no', 519750)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK002', 'TH015', 10, N'1 viên/lần, uống sáng-chiều, trước khi ăn', 196350)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK002', 'TH016', 10, N'1 viên/lần, uống sáng-trưa-chiều, sau khi ăn no', 173250)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK003', 'TH009', 10, N'1 viên/lần, uống sáng-chiều, sau khi ăn no', 346500)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK003', 'TH010', 2, N'Tiêm tại bệnh viện, cách 1 ngày, 1 mũi/ngày', 147840)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK003', 'TH018', 15, N'1 viên/lần, uống sáng-trưa-chiều, sau khi ăn no', 420997500)
INSERT INTO CT_PHIEUKHAMBENH(MaPhieuKhamBenh, MaThuoc, SoLuong, LieuDung, ThanhTien)
VALUES ('PK003', 'TH022', 10, N'1 viên/lần, uống sáng-chiều, trước khi ăn', 18121950)

-----------------------------------VALUES PHIEUNHAPTHUOC------------------------------------------------------
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN001', '12-10-2021', 2, 5658450)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN002', '20-10-2021', 2, 75996900)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN003', '27-10-2021', 2, 156737700)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN004', '05-09-2020', 1, 1157100)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN005', '20-04-2021', 2, 14916930)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN007', '20-04-2021', 2, 85890000)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN008', '31-07-2021', 1, 674730000)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN009', '01-02-2022', 1, 2070810000)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN010', '29-06-2020', 2, 1123145100)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN011', '28-12-2021', 2, 2522129400)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN012', '24-12-2020', 2, 4138118250)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN013', '14-08-2020', 3, 6549361140)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN014', '17-04-2021', 4, 2638306650)
INSERT INTO PHIEUNHAPTHUOC(MaPhieuNhap, NgayNhap,SoLuong, TongTienNhap)
VALUES ('PN015', '07-08-2021',2, 5050500)
delete from PHIEUNHAPTHUOC
-----------------------------------VALUES CT_PHIEUNHAPTHUOC------------------------------------------------------
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN015', 'TH001', 20, 200000, 210000, 4200000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN001', 'TH030', 13, 129000,135450, 1760850)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN002', 'TH022', 46, 1569000, 1647450, 75782700)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN003', 'TH011', 23, 6483000, 6807150, 156564450)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN004', 'TH014', 12, 2170000, 2278500, 27342000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN005', 'TH021', 11, 1265000, 1328250, 14610750)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN007', 'TH029', 28, 2840000, 2982000, 83496000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN008', 'TH005', 42, 15300000, 16065000, 674730000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN009', 'TH007', 57, 34600000, 36330000, 2070810000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN010', 'TH018', 44, 24300000, 25515000, 1122660000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN011', 'TH012', 59, 40700000, 42735000, 2521365000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN012', 'TH024', 61, 64600000, 67830000, 4137630000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN013', 'TH017', 72, 86540000, 90867000, 6542424000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN014', 'TH007', 29, 2310000, 2425500, 2635143000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN014', 'TH002', 13, 20000, 21000, 273000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN013', 'TH005', 56, 86000, 90300, 5056800)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN015', 'TH009', 27, 30000, 31500, 850500)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN010', 'TH003', 22, 21000, 22050, 485100)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN004', 'TH028', 24, 19000, 19950, 478800)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN005', 'TH013', 12, 24300, 25515, 306180)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN007', 'TH023', 38, 60000, 63000, 2394000)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN014', 'TH025', 37, 69000, 72450, 2680650)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN001', 'TH010', 58, 64000, 67200, 3897600)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN002', 'TH015', 12, 17000, 17850, 214200)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN003', 'TH016', 11, 15000, 15750, 173250)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN004', 'TH027', 19, 58000, 60900, 1157100)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN011', 'TH028', 26, 28000, 29400, 764400)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN012', 'TH005', 31, 15000, 15750, 488250)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN013', 'TH001', 44, 40700, 42735, 1880340)
INSERT INTO CT_PHIEUNHAPTHUOC(MaPhieuNhap, MaThuoc, SoLuong, DonGiaNhap, DonGiaVAT, ThanhTienVAT)
VALUES ('PN014', 'TH026', 10,20000 , 21000, 210000)

-----------------------------------VALUES LOAIBENH------------------------------------------------------
INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung)
VALUES ('LB001',N'Bệnh Cơ Xương Khớp',N'Các khớp thường xuyên sưng tấy, viêm đỏ')
INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung)
VALUES ('LB002',N'Bệnh Thần Kinh',N'Thường xuyên xuất hiện ảo giác')
INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung)
VALUES ('LB003',N'Bệnh Tim Mạch',N'Tim đập nhanh thường xuyên')
INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung)
VALUES ('LB004',N'Bệnh Tiêu Hóa',N'Thường xuyên khó tiêu')
INSERT INTO LOAIBENH(MaLoaiBenh, TenLoaiBenh, TrieuChung)
VALUES ('LB005',N'Bệnh Hô Hấp',N'Thường xuyên khó thở, thở gấp')
-----------------------------------VALUES CT_BENH------------------------------------------------------
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK001', 'LB001')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK002', 'LB002')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK003', 'LB001')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK004', 'LB005')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK005', 'LB003')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK006', 'LB001')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK007', 'LB003')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK008', 'LB001')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK009', 'LB004')
INSERT INTO CT_BENH (MaPhieuKhamBenh, MaLoaiBenh)
VALUES ('PK010', 'LB003')
