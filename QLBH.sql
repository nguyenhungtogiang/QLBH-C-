USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 3/28/2020 11:21:54 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLBH.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLBH_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[Audit_CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_CTHD](
	[MaHD] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NULL,
	[SL] [int] NULL,
	[ThaoTac] [nvarchar](50) NULL,
	[NgayGio] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Audit_HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_HangHoa](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[DonGia] [float] NULL,
	[SLcon] [int] NULL,
	[MaLoaiHang] [nchar](10) NULL,
	[ThaoTac] [nchar](50) NULL,
	[NgayGio] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Audit_HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_HoaDon](
	[MaHD] [nchar](10) NULL,
	[NgayHD] [date] NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[ThaoTac] [nvarchar](50) NULL,
	[NgayGo] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Audit_KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_KhachHang](
	[MaKH] [nchar](10) NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nchar](10) NULL,
	[STK] [nchar](20) NULL,
	[MST] [nchar](20) NULL,
	[ThaoTac] [nvarchar](50) NULL,
	[NgayGio] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Audit_LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_LoaiHang](
	[MaLoaiHang] [nchar](10) NOT NULL,
	[TenLoaiHang] [nchar](50) NULL,
	[GhiChu] [nchar](100) NULL,
	[ThaoTac] [nchar](50) NULL,
	[NgayGio] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Audit_NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audit_NhanVien](
	[MaNV] [nchar](10) NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[SDT] [nchar](10) NULL,
	[ThaoTac] [nvarchar](50) NULL,
	[NgayGio] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[DonGia] [float] NULL,
	[SLcon] [int] NULL,
	[MaLoaiHang] [nchar](10) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[NgayHD] [date] NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nchar](10) NULL,
	[STK] [nchar](20) NULL,
	[MST] [nchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLoaiHang] [nchar](10) NOT NULL,
	[TenLoaiHang] [nvarchar](50) NULL,
	[GhiChu] [nchar](200) NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](200) NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HangHoa]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon1] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon1]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHang] FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[CTHD_HDBH]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTHD_HDBH] @MaHD nchar(10)
as
begin
	Select hd.MaHD, hh.MaHang, TenHang, SL, DonGia, ngayHD from HoaDon hd, HangHoa hh, CTHD where hd.MaHD = CTHD.MaHD and hh.MaHang = CTHD.MaHang and CTHD.MaHD = @maHD
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Delete_CTHD] @MaHD nchar(10), @MaHang nchar(10)
as
begin
	Delete from CTHD where MaHD = @MaHD and MaHang = @MaHang
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Delete_HangHoa] @MaHang nchar(10)
as
begin
	Delete from HangHoa where MaHang = @MaHang
end

GO
/****** Object:  StoredProcedure [dbo].[Delete_HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_HoaDon] @MaHD nchar(10)
as
begin
	Delete from HoaDon where MaHD = @MaHD
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_HoaDonMaxID]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Delete_HoaDonMaxID] 
as
begin
	Declare @MaxID int
	Select @MaxID = max(cast(substring(MaHD, 3,8) as int)) from HoaDon
	Delete from HoaDon where MaHD = concat('HD',@MaxID)
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[Delete_KhachHang] @MaKH nchar(10)
as
begin
	Delete from KhachHang where MaKH = @MaKH
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_LoaiHang] @MaLoaiHang nchar(10)
as
begin
	Delete from LoaiHang where MaLoaiHang = @MaLoaiHang
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_NhanVien] @MaNV nchar(10)
as
begin
	Delete from NhanVien where MaNV = @MaNV
end


GO
/****** Object:  StoredProcedure [dbo].[Delete_TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_TaiKhoan] @UserName nvarchar(50)
as
begin
	Delete from TaiKhoan where UserName = @UserName
End 

GO
/****** Object:  StoredProcedure [dbo].[Insert_CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_CTHD] @MaHD nchar(10),@MaHang nchar(10), @SL int
as
begin
	insert into CTHD values(@MaHD, @MaHang,@SL)
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CTHDByMaxID]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_CTHDByMaxID] @MaHang nchar(10), @SL int
as
begin
	Declare @id int
	Select @id = max(cast(substring(MaHD,3,8) as int)) from HoaDon
	insert into CTHD values(concat('HD',@id), @MaHang,@SL)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_HangHoa] @TenHang nvarchar(50), @DVT nvarchar(20), @DonGia float, @SLcon int, @MaLoaiHang nchar(10)
as 
begin
	Declare @id int
	Select @id = max(cast(substring(MaHang, 3,8) as int))+1 from HangHoa 
	Insert into HangHoa values(concat('HH',convert(varchar, @id)),@TenHang,@DVT,@DonGia,@SLcon,@MaLoaiHang)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_HoaDon] @MaKH nchar(10), @MaNV nchar(10)
as
begin
	declare @id int 
	Select @id = max(cast(substring(MaHD, 3,8) as int))+1 from HoaDon 
	insert into HoaDon values(concat('HD',@id), getdate(), @MaKH, @MaNV)
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_HoaDonByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_HoaDonByMa] @MaHD nchar(10), @MaKH nchar(10), @MaNV nchar(10)
as
begin
	
	insert into HoaDon values(@MaHD, getdate(), @MaKH, @MaNV)
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_KhachHang] @TenKH nvarchar(50), @DiaChi nvarchar(100), @SDT nchar(10), @STK nchar(20), @MST nchar(20)
as
begin
	declare @id int
	Select @id = max(cast(substring(MaKH, 3,8) as int))+1 from KhachHang
	insert into KhachHang values(concat('KH',@id),@TenKH,@DiaChi,@SDT,@STK,@MST)
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_LoaiHang] @TenLoaiHang nchar(10), @GhiChu nchar(20)
as
begin
	declare @id int
	Select @id = max(cast(substring(MaLoaiHang, 3,8) as int))+1 from LoaiHang
	insert into LoaiHang values(concat('LH',@id),@TenLoaiHang, @GhiChu)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_NhanVien] @TenNV nvarchar(50), @NgaySinh datetime, @GioiTinh bit, @SDT nchar(10)
as
begin
	declare @id int 
	Select @id = max(cast(substring(MaNV, 3, 8) as int))+1 from NhanVien
	insert into NhanVien values(concat('NV',@id), @TenNV,@NgaySinh,@GioiTinh,@SDT)
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_TaiKhoan] @UserName nvarchar(50), @PassWord nvarchar(200), @MaNV nchar(10)
as
begin
	Insert into TaiKhoan values (@UserName,@PassWord,@MaNV)
End 

GO
/****** Object:  StoredProcedure [dbo].[Login_TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Login_TaiKhoan] @UserName nvarchar(50), @passWord nvarchar(200)
as
begin
	Select * from Taikhoan where UserName = @UserName and PassWord = @passWord
end

GO
/****** Object:  StoredProcedure [dbo].[Search_HangHoaByName]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Search_HangHoaByName] @TenHang nvarchar(50)
as
begin
	Select * from HangHoa where TenHang like concat('%',@TenHang,'%')
end

GO
/****** Object:  StoredProcedure [dbo].[Search_KhachHangByName]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Search_KhachHangByName] @TenKH nvarchar(50)
as 
begin
	Select * from KhachHang where TenKH like concat('%',@TenKH,'%')
end

GO
/****** Object:  StoredProcedure [dbo].[Search_LoaiHangByName]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_LoaiHangByName] @TenLoaiHang nvarchar(50)
as
begin
	Select * from LoaiHang where TenLoaiHang like CONCAT('%',@TenLoaiHang,'%')
end

GO
/****** Object:  StoredProcedure [dbo].[Search_NhanVienByName]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_NhanVienByName] @TenNV nvarchar(50)
as 
begin
	Select * from NhanVien where TenNV like concat('%',@TenNV,'%')
end


GO
/****** Object:  StoredProcedure [dbo].[Search_TaiKhoanByName]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_TaiKhoanByName] @UserName nvarchar(50)
as
Begin 
	Select UserName, MaNV from TaiKhoan where UserName like concat('%',@UserName,'%')
End 

GO
/****** Object:  StoredProcedure [dbo].[Select_CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_CTHD] 
as
begin
	select * from CTHD
end


GO
/****** Object:  StoredProcedure [dbo].[Select_CTHDByMaHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_CTHDByMaHD] @MaHD nchar(10)
as
begin
	Select hh.MaHang, TenHang, SL, DVT, DonGia, lh.TenLoaiHang from LoaiHang lh, HangHoa hh, CTHD where lh.MaLoaiHang = hh.MaLoaiHang and hh.MaHang = CTHD.MaHang and CTHD.MaHD = @maHD
	
end

GO
/****** Object:  StoredProcedure [dbo].[Select_HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_HangHoa] 
as
begin
	Select MaHang, TenHang, DVT, DonGia, SLcon, TenLoaiHang from HangHoa, LoaiHang where HangHoa.MaLoaiHang = LoaiHang.MaLoaiHang
end


GO
/****** Object:  StoredProcedure [dbo].[Select_HangHoaByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_HangHoaByMa] @MaHang nchar(10)
as
begin
	select * from HangHoa where MaHang = @MaHang
end


GO
/****** Object:  StoredProcedure [dbo].[Select_HangHoaByMaLH]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_HangHoaByMaLH] @MaLH nchar(10)
as
begin
	Select * from HangHoa where MaLoaiHang = @MaLH
end

GO
/****** Object:  StoredProcedure [dbo].[Select_HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_HoaDon] 
as
begin
	select  MaHD, NgayHD, TenKH, TenNV from HoaDon hd, KhachHang kh, NhanVien nv where hd.MaKH = kh.MaKH and hd.MaNV = nv.MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[Select_HoaDonByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_HoaDonByMa] @MaHD nchar(10)
as
begin
	select * from HoaDon where MaHD = @MaHD
end


GO
/****** Object:  StoredProcedure [dbo].[Select_HoaDonNewID]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_HoaDonNewID] 
as
begin
	Select  concat('HD', max(cast(substring(MaHD,3,8) as int))+1) from HoaDon	
end

GO
/****** Object:  StoredProcedure [dbo].[Select_inhoadon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Select_inhoadon]
@MaHD nchar(10)
AS
BEGIN
	select CTHD.MaHD,TenKH,TenNV, NgayHD, HH.MaHang,HH.MaLoaiHang,TenLoaiHang, SL, KH.MaKH,NV.MaNV, KH.DiaChi,KH.SDT,TenHang,DonGia
	from KhachHang as KH inner join HoaDon as HD on HD.MaKH = KH.MaKH
	inner join NhanVien as NV on HD.MaNV = NV.MaNV
	inner join CTHD on CTHD.MaHD = HD.MaHD 
	inner join HangHoa as HH on CTHD.MaHang = HH.MaHang
	inner join LoaiHang as LH on LH.MaLoaiHang = HH.MaLoaiHang
	where HD.MaHD = @MaHD 
END

GO
/****** Object:  StoredProcedure [dbo].[Select_KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_KhachHang]
as
begin
	Select * from KhachHang
end

GO
/****** Object:  StoredProcedure [dbo].[Select_KhachHangByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_KhachHangByMa] @MaKH nchar(10)
as
begin
	select * from KhachHang where MaKH = @MaKH
end


GO
/****** Object:  StoredProcedure [dbo].[Select_LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Select_LoaiHang] 
as
begin
	select * from LoaiHang
end


GO
/****** Object:  StoredProcedure [dbo].[Select_LoaiHangByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_LoaiHangByMa] @MaLoaiHang nchar(10)
as
begin
	select * from LoaiHang where MaLoaiHang = @MaLoaiHang
end


GO
/****** Object:  StoredProcedure [dbo].[Select_NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_NhanVien]
as
begin
	select * from NhanVien
end


GO
/****** Object:  StoredProcedure [dbo].[Select_NhanVienByMa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_NhanVienByMa] @MaNV nchar(10)
as
begin
	select * from NhanVien where MaNV = @MaNV
end


GO
/****** Object:  StoredProcedure [dbo].[Select_TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_TaiKhoan] 
as
Begin 
	Select UserName, MaNV from TaiKhoan
End 

GO
/****** Object:  StoredProcedure [dbo].[Select_TaiKhoanByTenTK]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_TaiKhoanByTenTK] @UserName nvarchar(50)
as
begin
	Select * from TaiKhoan where UserName = @UserName
End 

GO
/****** Object:  StoredProcedure [dbo].[Update_CTHD]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_CTHD] @MaHD nchar(10), @MaHang nchar(10), @SL int
as
begin
	update CTHD set SL = @SL where MaHD = @MaHD and  MaHang = @MaHang
end


GO
/****** Object:  StoredProcedure [dbo].[Update_HangHoa]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_HangHoa] @MaHang nchar(10), @TenHang nvarchar(50), @DVT nvarchar(20), @DonGia float, @SLcon int, @MaLoaiHang nchar(10)
as
begin
	Update HangHoa set TenHang = @TenHang, DVT = @DVT, DonGia = @DonGia, SLcon = @SLcon, MaLoaiHang = @MaLoaiHang where MaHang = @MaHang
end


GO
/****** Object:  StoredProcedure [dbo].[Update_HoaDon]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_HoaDon] @MaHD nchar(10), @MaKH nchar(10), @MaNV nchar(10)
as
begin
	update HoaDon set NgayHD = getdate(), MaKH = @MaKH, MaNV = @MaNV where MaHD = @MaHD
end

GO
/****** Object:  StoredProcedure [dbo].[Update_KhachHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_KhachHang] @MaKH nchar(10), @TenKH nvarchar(50), @DiaChi nvarchar(100), @SDT nchar(10), @STK nchar(20), @MST nchar(20)
as
begin
	Update KhachHang set TenKH = @TenKH, DiaChi = @DiaChi, SDT = @SDT, STK = @STK, MST = @MST where MaKH = @MaKH
end


GO
/****** Object:  StoredProcedure [dbo].[Update_LoaiHang]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_LoaiHang] @MaLoaiHang nchar(10), @TenLoaiHang nchar(10), @GhiChu nchar(20)
as
begin
	update LoaiHang set TenLoaiHang = @TenLoaiHang, GhiChu = @GhiChu where MaLoaiHang = @MaLoaiHang
end


GO
/****** Object:  StoredProcedure [dbo].[Update_NhanVien]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_NhanVien] @MaNV nchar(10), @TenNV nvarchar(50), @NgaySinh datetime, @GioiTinh bit, @SDT nchar(10)
as
begin
	update NhanVien set TenNV = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT where MaNV = @MaNV
end


GO
/****** Object:  StoredProcedure [dbo].[Update_TaiKhoan]    Script Date: 3/28/2020 11:21:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_TaiKhoan] @UserName nvarchar(50), @PassWord nvarchar(200), @MaNV nchar(10)
as
begin
	Update TaiKhoan set PassWord = @PassWord, MaNV = @MaNV where UserName = @UserName
End 

GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
