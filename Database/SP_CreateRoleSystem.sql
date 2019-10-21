USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[CreateRoleSystem]    Script Date: 19/10/2019 11:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateRoleSystem]
AS
BEGIN
	EXEC sp_addrole 'PGV'; 
	EXEC sp_addrole 'Khoa';
	EXEC sp_addrole 'SinhVien';
	EXEC sp_addrolemember db_owner, 'PGV';
	EXEC sp_addrolemember db_owner, 'Khoa';
	EXEC sp_addrolemember db_datareader, 'SinhVien';
END