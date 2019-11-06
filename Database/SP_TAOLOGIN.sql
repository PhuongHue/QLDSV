USE [QLDSV]
GO
CREATE PROC SP_TAOLOGIN
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(10),
  @ROLE VARCHAR(10),
  @TYPE VARCHAR(10) = NULL
AS
BEGIN
  DECLARE @RET INT

  DECLARE @RunStoredProcSQL NVARCHAR(1000);
  SET @RunStoredProcSQL = N'LINK_QLDSV.QLDSV.dbo.SP_TAOLOGIN @LGNAME = '''+@LGNAME
							+N''', @PASS = '''+@PASS
							+N''', @USERNAME = '''+@USERNAME
							+N''', @ROLE = '''+@ROLE
							+N''', @TYPE = ''REMOTE''';
  if(@TYPE IS NULL and @ROLE = 'PGV') EXEC @RET = sp_executesql @RunStoredProcSQL;
  IF (@RET != 0) RETURN @RET

  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'PGV'
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
RETURN 0  -- THANH CONG
END