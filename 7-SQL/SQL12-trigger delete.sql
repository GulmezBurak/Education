USE [BankaDB2]
GO
/****** Object:  Trigger [dbo].[İptal]    Script Date: 22.09.2022 20:00:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER [dbo].[İptal]
   ON  [dbo].[Musteri]
   AFTER DELETE
AS 
declare @EKKNO int
declare @MusteriId int
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select @MusteriId = Id, @EKKNO = KKNO from deleted
	insert into LogTable(Kullanici, Tarih, Kod, MusteriId,EKKNO)
	values (USER_NAME(),getdate(),'İptal kart',@MusteriId, @EKKNO)
    -- Insert statements for trigger here

END
