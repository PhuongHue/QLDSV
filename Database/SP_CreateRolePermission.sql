USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[CreateRolePermission]    Script Date: 19/10/2019 11:12:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateRolePermission]
AS
BEGIN
	DENY DELETE, INSERT, UPDATE ON DangKy TO PGV;
	DENY DELETE, UPDATE ON LopTinChi TO Khoa;
	DENY DELETE, UPDATE ON GiangVien TO Khoa;
	GRANT DELETE, INSERT, UPDATE ON DangKy TO SinhVien;
END