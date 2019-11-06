create proc SP_Fill_Diem
@MaLopTC nvarchar(10)
as
begin
	select sv.MaSV, Ho + Ten as HoTen, DiemCC, DiemGK, DiemCK  
		from (select MaSV, Ho, Ten from SinhVien) as sv 
		inner join (select * from DangKy where MaLopTC = @MaLopTC) as dk 
			on sv.MaSV = dk.MaSV
end