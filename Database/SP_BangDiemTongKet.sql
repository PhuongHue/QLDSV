USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiem_TongKet]    Script Date: 4/12/2019 6:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_BangDiem_TongKet]
@MaLopTC nvarchar(10)
as
begin
	select TK.MaSV, Ho + ' ' + Ten as HoTen, MonHoc.TenMH, TK.DiemTK from
		(select DK.MaSV, LopTinChi.MaMH, DK.DiemCC*0.1 + DK.DiemGK*0.3 + DK.DiemCK*0.6 as DiemTK from 
			(select * from DangKy where MaLopTC = @MaLopTC) as DK
			inner join LopTinChi
			on DK.MaLopTC = LopTinChi.MaLopTC
		) as TK
		inner join SinhVien
		on TK.MaSV = SinhVien.MaSV
		inner join MonHoc
		on TK.MaMH = MonHoc.MaMH
		
end