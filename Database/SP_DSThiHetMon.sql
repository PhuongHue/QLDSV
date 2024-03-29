USE [QLDSV]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSach_ThiHetMon]    Script Date: 4/12/2019 6:47:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_DanhSach_ThiHetMon]
@MaLopTC nvarchar(10)
as
begin
	select DK.MaSV, HoTen from 
		(select MaSV from DangKy where MaLopTC = @MaLopTC) as DK 
			inner join
				(select MaSV, Ho + ' ' + Ten as HoTen from SinhVien) as SV 
			on DK.MaSV = SV.MaSV
end