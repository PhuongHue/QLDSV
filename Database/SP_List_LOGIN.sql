USE [QLDSV]
GO
CREATE PROC SP_List_LOGIN
AS
BEGIN 
	SELECT GiangVien.MaGV, GiangVien.Ho, GiangVien.Ten, GiangVien.MaKhoa FROM 
	(SELECT logins.name AS LOGINNAME, users.name AS USERNAME
		FROM sys.database_principals AS users 
		INNER JOIN sys.server_principals AS logins 
			ON logins.sid = users.sid WHERE users.name != 'dbo' and users.name != 'HTKN' 
	) 
	AS LG 
	full outer join
	GiangVien 
	ON LG.USERNAME = GiangVien.MaGV WHERE LOGINNAME IS NULL;
END