Create trigger TR_Them_DangKy on DangKy for Insert
as
begin
	set nocount on;
	declare @SLDangKy int, @SoSvMax int;
	select @SLDangKy = LopTinChi.SLDaDangKy, @SoSvMax = LopTinChi.SoSvMax from LopTinChi, inserted where LopTinChi.MaLopTC = inserted.MaLopTC;
	if(@SLDangKy + 1 > @SoSvMax) RAISERROR('Quá số lượng đăng ký.', 10, 1);
end