USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_Chuyen_SinhVien]    Script Date: 4/12/2019 6:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Chuyen_SinhVien]
@MaSV nvarchar(10),
@MaLop nvarchar(10)
as
begin
	if exists (select * from DangKy where MaSV = @MaSV)
		RAISERROR (N'Không thể chuyển sinh viên MaSV: %s vì đã đăng ký thi.' , 16, 1, @MaSV);
	else
		update SinhVien set MaLop = @MaLop where MaSV = @MaSV
end