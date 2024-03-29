USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_List_SV_DangKy_LopTC]    Script Date: 4/12/2019 6:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_List_SV_DangKy_LopTC]
@Nam int, @HocKy int
as
begin
declare @selected bit = 0;
SELECT LopTinChi.MaLopTC, LopTinChi.MaGV, GiangVien.Ho, GiangVien.Ten, 
			LopTinChi.MaMH, MonHoc.TenMH, LopTinChi.HocKy, LopTinChi.Nam,
			LopTinChi.SoSvMax, LopTinChi.SoSvMin, LopTinChi.Nhom, LopTinChi.SLDaDangKy,
			selected = @selected
	FROM LopTinChi INNER JOIN
			GiangVien ON LopTinChi.MaGV = GiangVien.MaGV INNER JOIN
            MonHoc ON LopTinChi.MaMH = MonHoc.MaMH
	WHERE LopTinChi.Nam = @Nam and LopTinChi.HocKy = @HocKy
end