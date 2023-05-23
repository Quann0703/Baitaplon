USE [QLHTTH]
GO
create database QLHTTH


CREATE TABLE [dbo].[baihoc](
	[Baihoc_ID] [int]  NOT NULL PRIMARY KEY,
	[lop_ID] [int] NULL,
	[tenbaihoc] [nvarchar](50) NOT NULL,
)
GO

ALTER TABLE [dbo].[baihoc] add constraint FK_baihoc_Lophoc FOREIGN KEY([lop_ID])
REFERENCES [dbo].[Lophoc] ([Lop_ID]) 



drop table Cauhoi
CREATE TABLE [dbo].[Cauhoi](
	id int identity(1,1) NOT NULL PRIMARY KEY ,
	[cauhoi_ID] [int]  ,
	[TestID] [int] NULL,
	[Baitoan] [nvarchar](100) NOT NULL,
	[dapan1] [nvarchar](100) NOT NULL,
	[dapan2] [nvarchar](100) NOT NULL,
	[dapan3] [nvarchar](100) NOT NULL,
	[dapan4] [nvarchar](100) NOT NULL,
	[dapan] [nvarchar](100) NOT NULL,
) 

ALTER TABLE [dbo].[Cauhoi]  add constraint FK_Cauhoi_TestID FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([TestID]) ON DELETE CASCADE
/****** Object:  Table [dbo].[Diem]    Script Date: 07/05/2023 2:08:26 pm ******/

drop table Diem
CREATE TABLE [dbo].[Diem](
	[Diem_ID] [int]  NOT NULL PRIMARY KEY,
	[HS_ID] [int] NULL,
	[TestID] [int] NULL,
	[TongDiem] [float] NOT NULL,
) 
ALTER TABLE [dbo].[Diem]  add constraint FK_Diem_HS FOREIGN KEY([HS_ID])
REFERENCES [dbo].[HS] ([HS_ID])


ALTER TABLE [dbo].[Diem] add constraint Fk_Diem_Test FOREIGN KEY([HS_ID])
REFERENCES [dbo].[HS] ([HS_ID])


ALTER TABLE [dbo].[Diem]  add constraint FK_Diem_Test1 FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([TestID]) 
GO
/****** Object:  Table [dbo].[GV]    Script Date: 07/05/2023 2:08:26 pm ******/

CREATE TABLE [dbo].[GV](
	[GV_ID] [int] NOT NULL PRIMARY KEY,
	[users__ID] [int] NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[NgaySinh] [nvarchar](30) NOT NULL,
	[GioiTinh] [nchar](3) NULL,
	[Diachi] [nvarchar](30) NOT NULL,
	[SDT] [nchar](10) NULL,
	[Trinhdo] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
) 
ALTER TABLE [dbo].[GV] add constraint FK_GV_Users FOREIGN KEY([users__ID])
REFERENCES [dbo].[Users] ([users__ID])



CREATE TABLE [dbo].[HS](
	[HS_ID] [int] NOT NULL PRIMARY KEY,
	[users__ID] [int] NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[NgaySinh] [nvarchar](30) NOT NULL,
	[GioiTinh] [nchar](3) NULL,
	[Diachi] [nvarchar](30) NOT NULL,
	[Lop_ID] [int] NULL,
	[SDT] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
) 
ALTER TABLE [dbo].[HS]  add constraint FK_HS_Users FOREIGN KEY([Lop_ID])
REFERENCES [dbo].[Lophoc] ([Lop_ID])
ON DELETE CASCADE

ALTER TABLE [dbo].[HS] add constraint FK_HS_Users1 FOREIGN KEY([users__ID])
REFERENCES [dbo].[Users] ([users__ID])
ON DELETE CASCADE


CREATE TABLE [dbo].[Lophoc](
	[Lop_ID] [int] NOT NULL PRIMARY KEY,
	[TenLop] [nvarchar](20) NOT NULL,
	[MaGVCN] [int] NULL,
	[Namhoc] [varchar](20) NOT NULL,
)

ALTER TABLE [dbo].[Lophoc]  add constraint FK_Lophoc_GV FOREIGN KEY([MaGVCN])
REFERENCES [dbo].[GV] ([GV_ID]) on delete cascade
GO
drop table Tailieu
CREATE TABLE [dbo].[Tailieu](
	[Tailieu_ID] [int]  NOT NULL PRIMARY KEY,
	[baihoc_ID] [int] NULL,
	[TenTailieu] [nvarchar](50) NOT NULL,
	[Files] [varchar](100) NOT NULL,
	[Mota] [nvarchar](50) NULL,
	[GV_ID] [int] NULL,
) 

ALTER TABLE [dbo].[Tailieu]  add constraint FK_Tailieu_Baihoc FOREIGN KEY([baihoc_ID])
REFERENCES [dbo].[baihoc] ([Baihoc_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tailieu]  add constraint FK_Tailieu_GV FOREIGN KEY([GV_ID])
REFERENCES [dbo].[GV] ([GV_ID])
ON DELETE CASCADE


drop table Test
CREATE TABLE [dbo].[Test](
	[TestID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Baihoc_ID] [int] NULL,
	[TenBaiTest] [nvarchar](100) NOT NULL,
	[NgayTest] [date] NOT NULL,
	[GV_ID] [int] NULL,

) 

ALTER TABLE [dbo].[Test]  add constraint FK_Test_baihoc FOREIGN KEY([Baihoc_ID])
REFERENCES [dbo].[baihoc] ([Baihoc_ID])
ON DELETE CASCADE

ALTER TABLE [dbo].[Test] add constraint FK_Test_GV FOREIGN KEY([GV_ID])
REFERENCES [dbo].[GV] ([GV_ID])
ON DELETE CASCADE
GO
CREATE TABLE [dbo].[Users](
	[users__ID] [int]  NOT NULL PRIMARY KEY,
	[usersName] [varchar](30) NOT NULL,
	[password] [nchar](30) NOT NULL,
	[roles] [nvarchar](20) NULL,
) 


GO
ALTER TABLE [dbo].[GV]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[GV]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[HS]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([roles]=N'Giáo viên' OR [roles]=N'Học sinh'))
GO



select * from Users





/****** Object:  StoredProcedure [dbo].[SP_hienthiGV]    Script Date: 07/05/2023 2:08:39 pm ******/
go
create proc [dbo].[SP_hienthiGV]
as
begin
	select * from GV
end
GO
/****** Object:  StoredProcedure [dbo].[SP_themGV]    Script Date: 07/05/2023 2:08:39 pm ******/

GO
create proc [dbo].[SP_themGV]
	@GV_ID int,
	@users_ID int,
	@HoTen nvarchar(30),
	@NgaySinh nvarchar(30),
	@GioiTinh nchar(3),
	@Diachi nvarchar(30),
	@SDT nchar(10),
	@Trinhdo nchar(10),
	@Email nvarchar(50)
as
begin
	insert into GV values(@GV_ID,@users_ID,@HoTen,@NgaySinh,@GioiTinh,@Diachi,@SDT,@Trinhdo,@Email)
end
GO

create proc SP_getUsersIDGV
as
begin
	select users__ID from Users where roles like N'Giáo Viên'
end

select * from Users
SP_hienthiGV
select * from GV
SP_themGV @GV_ID=100,@users_ID=22,@HoTen=N'Trần Quân',@NgaySinh=N'07/11/2003',@GioiTinh=N'Nam',@Diachi=N'Hưng yên',@SDT=N'098765472',@Trinhdo=N'Kỹ sư',@Email=N'tranquan@gmail.com'

--hàm sửa
go
create proc SP_EditGV
	@GV_ID int,
	@HoTen nvarchar(30),
	@NgaySinh nvarchar(30),
	@Diachi nvarchar(30),
	@SDT nchar(10),
	@Trinhdo nchar(10),
	@Email nvarchar(50)
as
begin 
	update GV
	set HoTen = @HoTen , NgaySinh = @NgaySinh , Diachi = @Diachi , SDT = @SDT , Trinhdo = @Trinhdo , Email = @Email
	where GV_ID = @GV_ID
end

select * from GV
select * from Users

go
create proc SP_deleteGV
	@magv int 
as
begin
	delete from GV
	where GV_ID = @magv
end
go


SP_deleteGV 100

select * from GV where HoTen =  N'Trần Đình Nam'

go
create proc SP_seach
	@key nvarchar(100) = null
as
begin
	select * from GV 
	where (@key is null
	or CONVERT(varchar(10),GV_ID) like '%' + @key + '%'
	or CONVERT(varchar(10),users__ID) like '%' + @key + '%'
	or HoTen like '%' + @key + '%'
	or NgaySinh like '%' + @key + '%'
	or GioiTinh like '%' + @key + '%'
	or Diachi like '%' + @key + '%'
	or SDT like '%' + @key + '%'
	or Trinhdo like '%' + @key + '%'
	or Email like '%' + @key + '%'
	)
end

SP_seach N'Trần Đình Nam'

select * from HS

go
------------------------------------
create proc SP_getUsersIDHS
as
begin
	select users__ID from Users where roles like N'Học sinh'
end

go

--------------------------
create proc SP_hienthiHS
as
begin
	select * from HS
end
------------------------------------
go
select * from Users
go
create proc SP_themHS
	@HS_ID int,
	@users_ID int,
	@Lop_ID int,
	@HoTen nvarchar(30),
	@NgaySinh nvarchar(30),
	@GioiTinh nchar(3),
	@Diachi nvarchar(30),
	@SDT nchar(10),
	@Email nvarchar(50)
as
begin
	insert into HS values(@HS_ID,@users_ID,@HoTen,@NgaySinh,@GioiTinh,@Diachi,@Lop_ID,@SDT,@Email)
end
GO
SP_themHS @HS_ID = 10121901 , @users_ID = 33 , @HoTen = N'Đặng Quang chiến' , @NgaySinh = N'25-11-2003' , @GioiTinh = N'Nam' , @Diachi = N'Hưng yên' ,@Lop_ID = 125213,  @SDT = '0982664273' , @Email = N'chien@gmail.com'

-----------------------------------------------------
go
create proc SP_getLopID
as
begin
	select Lop_ID from Lophoc 
end
go

select * from Lophoc

go
---------------------------
create proc SP_EditHS
	@HS_ID int,
	@HoTen nvarchar(30),
	@NgaySinh nvarchar(30),
	@Diachi nvarchar(30),
	@Lop_ID int,
	@SDT nchar(10),
	@Email nvarchar(50)
as
begin 
	update HS
	set HoTen = @HoTen , NgaySinh = @NgaySinh , Diachi = @Diachi , Lop_ID = @Lop_ID , SDT = @SDT , Email = @Email
	where HS_ID = @HS_ID
end
go
SP_EditHS @HS_ID = 10121900 , @HoTen = N'Trần Văn quân' , @NgaySinh = N'25-11-2003' , @Diachi = N'Hà nội' , @Lop_ID = N'125214' , @SDT = N'0918232184' , @Email = N'chienvien@gmail.com'
select * from HS
----------------------------
create proc SP_deleteHS
	@mahs int 
as
begin
	delete from HS
	where HS_ID = @mahs
end
go

--------------------------

create proc SP_seachHS
	@key nvarchar(100) = null
as
begin
	select * from HS
	where (@key is null
	or CONVERT(varchar(10),HS_ID) like '%' + @key + '%'
	or CONVERT(varchar(10),users__ID) like '%' + @key + '%'
	or HoTen like '%' + @key + '%'
	or NgaySinh like '%' + @key + '%'
	or GioiTinh like '%' + @key + '%'
	or Diachi like '%' + @key + '%'
	or CONVERT(varchar(10),Lop_ID) like '%' + @key + '%'
	or SDT like '%' + @key + '%'
	or Email like '%' + @key + '%'
	)
end

go
--------------

create proc SP_hienthiLop
as
begin
	select * from Lophoc
end
------------------------------------
go
-------------------------------
create proc SP_getGVID
as
begin
	select GV_ID from GV
end
go
-------------------------------
create proc SP_themLop
	@LopID int,
	@tenlop nvarchar(20),
	@magvcn int,
	@namhoc varchar(20)
as
begin
	insert into Lophoc  values(@LopID , @tenlop , @magvcn , @namhoc)
end
GO
--------------------------
create proc SP_EditLop
	@LopID int,
	@tenlop nvarchar(20),
	@magvcn int,
	@namhoc varchar(20)
as
begin 
	update Lophoc
	set Lop_ID = @LopID , TenLop = @tenlop , MaGVCN = @magvcn , Namhoc = @namhoc 
	where Lop_ID = @LopID
end
go
------------------------
create proc SP_deleteLop
	@malop int 
as
begin
	delete from Lophoc
	where Lop_ID = @malop
end
go
SP_deleteLop 125214
--------------------
create proc SP_seachLop
	@key nvarchar(100) = null
as
begin
	select * from Lophoc
	where (@key is null
	or CONVERT(varchar(10),Lop_ID) like '%' + @key + '%'
	or TenLop like '%' + @key + '%'
	or CONVERT(varchar(10),MaGVCN) like '%' + @key + '%'
	or Namhoc like '%' + @key + '%'
	)
end
go

alter proc SP_hienthicauhoi
	@key nvarchar(100) = null
as
begin
	select * from Cauhoi where (@key is null 
						or CONVERT(varchar(10),TestID) Like '%' + @key + '%' )
end
go

create proc SP_gethienthicauhoi
as
begin
	select * from Cauhoi
end
go

create proc SP_getTestID
as
begin
	select TestID from Test
end
go

create proc SP_themCauhoi
	@cauhoi_id int,
	@TestID int,
	@Baitoan nvarchar(100),
	@dapan1 nvarchar(100),
	@dapan2 nvarchar(100),
	@dapan3 nvarchar(100),
	@dapan4 nvarchar(100),
	@dapan nvarchar(100)
as
begin
	insert into Cauhoi  values(@cauhoi_id , @TestID , @Baitoan , @dapan1 , @dapan2 , @dapan3 , @dapan4 , @dapan)
end
GO
---------------------------
alter proc SP_EditCauhoi
	@Baitoan nvarchar(100),
	@dapan1 nvarchar(100),
	@dapan2 nvarchar(100),
	@dapan3 nvarchar(100),
	@dapan4 nvarchar(100),
	@dapan nvarchar(100)
as
begin 
	update Cauhoi
	set Baitoan = @Baitoan , dapan1 = @dapan1 ,  dapan2 = @dapan2 , dapan3 = @dapan3 , dapan4 = @dapan4 , dapan = @dapan
	where Baitoan = @Baitoan
end
go

create proc SP_deleteCauhoi
	@baitoan nvarchar(100)
as
begin
	delete from Cauhoi
	where Baitoan = @baitoan
end
go

select * from Cauhoi

go
create proc SP_getbaitest
as
begin
	select * from Test
end

select  ch.cauhoi_ID from Cauhoi ch inner join Test ts on ch.TestID = ts.TestID where ts.TestID = 2

go

alter proc SP_gettestID 
	@testID int
as
begin
	select * from Test 
	where TestID = @testID
end

SP_getcauhoi 2

select * from Cauhoi where TestID = 2

select * from Test where TestID = 2

go
create  proc SP_getcauhoitestID 
	@testID int
as
begin
	select * from Cauhoi 
	where TestID = @testID
end
go
create  proc SP_laycauhoi 
	@testID int,
	@cauhoiid int
as
begin
	select * from Cauhoi 
	where TestID = @testID and cauhoi_ID = @cauhoiid
end
select * from Cauhoi ch inner join Test t on t.TestID = ch.TestID where t.TestID = 1 and cauhoi_ID = 1

SP_laycauhoi 2 , 1
select * from Cauhoi
update Cauhoi set dapanchon = 4 

go
create proc updatechc
	@dapanchon nvarchar(100),
	@cauhoiid int ,
	@testid int 
as
begin
	update Cauhoi set dapanchon = @dapanchon where cauhoi_ID = @cauhoiid and TestID = @testid
end

updatechc null , 1 ,1

select * from Users us , HS hs  where not us.users__ID = hs.users__ID and roles = N'Học Sinh'
select * from Users where roles = N'Giáo Viên'


go
--------------------------------------------------
create proc SP_hienthiBaihoc
as
begin
	select * from baihoc
end

go

create proc SP_hienthiMalop
as
begin
	select Lop_ID from Lophoc 
end

go
create proc SP_AddBaihoc
	@BaihocID int,
	@LopID int,
	@Tenbaihoc nvarchar(50)
as
begin
	insert into baihoc  values(@BaihocID , @LopID , @Tenbaihoc)
end

go
create proc SP_EditBaihoc
	@BaihocID int,
	@LopID int,
	@Tenbaihoc nvarchar(50)
as
begin 
	update baihoc
	set Baihoc_ID = @BaihocID , lop_ID = @LopID , tenbaihoc = @Tenbaihoc 
	where Baihoc_ID = @BaihocID
end
go

create proc SP_deletebaihoc
	@mabaihoc int 
as
begin
	delete from baihoc
	where Baihoc_ID = @mabaihoc
end
go

select * from Tailieu

select * from baihoc where lop_ID = 125215
go
create proc SP_selectbaihocml
	@malop int 
as
begin
	select * from baihoc where lop_ID = @malop
end
go
SP_selectbaihocml 125213


select * from Tailieu where baihoc_ID = 4
select * from Lophoc
select * from baihoc
go
create proc SP_laytailieu
	@baihocid int 
as
begin
	select * from Tailieu where baihoc_ID = @baihocid
end
go

SP_laytailieu 5

select hs.HS_ID, hs.HoTen  from Users us inner join HS hs on us.users__ID = hs.users__ID where hs.users__ID = 2

select * from HS