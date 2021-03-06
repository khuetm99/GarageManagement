﻿USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='GARAGEMANAGEMENT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'GARAGEMANAGEMENT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [GARAGEMANAGEMENT]
END
GO

CREATE DATABASE GARAGEMANAGEMENT
GO

USE GARAGEMANAGEMENT
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE HOSOKHACHHANG
(
ID INT IDENTITY  ,
CUSTOMERNAME NVARCHAR(100) NOT NULL,
ADDRESS NVARCHAR(100) NOT NULL,
PHONE INT NOT NULL,
CREATEDDATE DATETIME2(7) NOT NULL,
DEBT FlOAT DEFAULT 0 
CONSTRAINT [PK_HOSOKHACHANG]  PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 



CREATE TABLE XE
(
CARNUMBER INT NOT NULL,
IDKH INT NOT NULL,
CARBRAND NVARCHAR(50) NOT NULL,
STATUS NVARCHAR(100) DEFAULT N'CHƯA SỬA'
CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[CARNUMBER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE XE
ADD CONSTRAINT FK_XE_HOSOKHACHHANG FOREIGN KEY (IDKH) REFERENCES HOSOKHACHHANG(ID) ON DELETE CASCADE


CREATE TABLE VATLIEU
(
IDITEM INT IDENTITY , 
ITEM NVARCHAR(50) NULL,
DONGIA FLOAT ,
SLITEM INT DEFAULT 0 NULL,
IMPORTEDDATE DATETIME2(7) DEFAULT GETDATE(),
CONSTRAINT [PK_VATLIEU] PRIMARY KEY CLUSTERED 
(
	[IDITEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE PHIEUSUACHUA
(
IDPSC INT IDENTITY  ,
CARNUMBER INT NOT NULL ,
IDITEM INT NOT NULL , 
DETAIL NVARCHAR(2000) NOT NULL,	
CREATEDDATE DATETIME2(7) NOT NULL,
DONGIA FlOAT NULL DEFAULT 0,
TIENCONG FLOAT NOT NULL DEFAULT 0,
TOTALPRICE FLOAT DEFAULT 0 -- Dongia + tiencong
CONSTRAINT [PK_PHIEUSUACHUA] PRIMARY KEY CLUSTERED 
(
	[IDPSC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE PHIEUSUACHUA
ADD CONSTRAINT FK_XE_PHIEUSUACHUA FOREIGN KEY (CARNUMBER) REFERENCES XE(CARNUMBER) ON DELETE CASCADE
ALTER TABLE PHIEUSUACHUA
ADD CONSTRAINT FK_PHIEUSUACHUA_VATLIEU FOREIGN KEY (IDITEM) REFERENCES VATLIEU(IDITEM) ON DELETE CASCADE

CREATE TABLE PHIEUTHUTIEN
(
IDPTT INT IDENTITY , 
IDKHACHHANG INT NOT NULL,
CARNUMBER INT NOT NULL ,
CREATEDDATE DATETIME2(7) NOT NULL ,
SOTIENTHU FLOAT NOT NULL DEFAULT 0,
CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[IDPTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE PHIEUTHUTIEN
ADD CONSTRAINT FK_HOSOKHACHHANG_PHIEUTHUTIEN FOREIGN KEY (IDKHACHHANG) REFERENCES HOSOKHACHHANG(ID) ON DELETE CASCADE;
GO
ALTER TABLE PHIEUTHUTIEN
ADD CONSTRAINT FK_XE_PHIEUTHUTIEN FOREIGN KEY (CARNUMBER) REFERENCES XE(CARNUMBER) ;
GO



CREATE TABLE ACCOUNT
(
	
	USERNAME NVARCHAR(20) NOT NULL,
	DISPLAYNAME NVARCHAR(20),
	PASSWORD NVARCHAR(100) NOT NULL DEFAULT 0,
	ACCESSLEVEL INT not null default 0-- admin =1 , 0 = staff
)
ALTER TABLE ACCOUNT
ADD CONSTRAINT PK_ACCOUNT PRIMARY KEY(USERNAME)


delete ACCOUNT
insert into ACCOUNT values ('admin', 'LTTQ-group','1', 1)
insert into ACCOUNT values ( 'user','Nhân viên', '2', 0)

GO

CREATE PROC USP_GetAccountByUsername
@userName NVARCHAR(20)
AS 
BEGIN
SELECT * FROM ACCOUNT WHERE USERNAME = @userName 
END
 
GO
CREATE PROC USP_Login
@userName NVARCHAR(20), @password NVARCHAR(100)
AS 
BEGIN
SELECT * FROM ACCOUNT WHERE USERNAME = @userName AND PASSWORD = @password
END
GO
GO

create proc USP_UpdateAccount
@username nvarchar(100), @displayname nvarchar(100), @password nvarchar(100), @newpassword nvarchar(100)
as
begin
	declare @isrightpass int = 0

	select @isrightpass = count (*) from dbo.account where username= @username and password = @password

	if(@isrightpass = 1)
	begin
		if (@newpassword = NULL or @newpassword = '')
		begin
			update dbo.account set displayname = @displayname where username = @username
		end
		else
			update dbo.account set displayname = @displayname, password = @newpassword where username = @username
	end
end
go


CREATE PROC USP_GetDoanhThuByMonthYear --BÁO CÁO DOANH THU THÁNG
@createdDate DATETIME
AS 
BEGIN
SELECT IDPTT, IDKHACHHANG, CARNUMBER, SOTIENTHU, CREATEDDATE
FROM PHIEUTHUTIEN WHERE MONTH(CREATEDDATE) = MONTH(@createdDate)  AND YEAR(CREATEDDATE) = YEAR(@createdDate)
END
GO

CREATE PROC USP_GetBill --BÁO CÁO DOANH THU THÁNG
@idPTT INT
AS 
BEGIN
SELECT IDPTT, kh.CUSTOMERNAME , ptt.CARNUMBER , SOTIENTHU, ptt.CREATEDDATE FROM dbo.PHIEUTHUTIEN as ptt, dbo.HOSOKHACHHANG as kh WHERE  kh.ID = ptt.IDKHACHHANG  AND IDPTT = @idPTT
END
GO
GO
CREATE PROC USP_GetTonKhoByMonth --BÁO CÁO TỒN KHO THÁNG
@createdDate DATETIME
AS 
BEGIN
SELECT IDITEM, ITEM, DONGIA, SLITEM, IMPORTEDDATE
FROM VATLIEU WHERE MONTH(IMPORTEDDATE) = MONTH(@createdDate)  AND YEAR(IMPORTEDDATE) = YEAR(@createdDate)
END
GO

CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
GO


insert dbo.hosokhachhang ( customername , address , phone , createddate , debt )values (  N'C' , N'69/96' , 123456 , '11/12/2019 12:00:00' , 1000)

insert dbo.vatlieu (  item , slitem ,importeddate, dongia  ) values ( N'Chân chống' , 2 , '12/12/1585' , 25000 )

