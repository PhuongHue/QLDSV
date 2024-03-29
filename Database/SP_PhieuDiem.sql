USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_PhieuDiem]    Script Date: 4/12/2019 6:45:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_PhieuDiem]
@MaSV nvarchar(10)
as 
begin

	select DK.MaLopTC, LopTinChi.MaMH, MonHoc.TenMH, LopTinChi.HocKy, DK.DiemCC, DK.DiemGK, DK.DiemCK  from
		(select * from DangKy where MaSV = @MaSV) as DK
			inner join LopTinChi
			on DK.MaLopTC = LopTinChi.MaLopTC
			inner join MonHoc
			on LopTinChi.MaMH = MonHoc.MaMH
	order by HocKy
end