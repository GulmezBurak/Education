-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER Güncelleme
   ON  Musteri
   AFTER UPDATE
AS 
declare @EKKNO int
declare @MusteriId int
declare @YKKNO int
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select @MusteriId = Id, @EKKNO = KKNO from deleted
	select @MusteriId = Id, @YKKNO = KKNO from inserted
	insert into LogTable(Kullanici, Tarih, Kod, MusteriId,EKKNO,YKKNO)
	values (USER_NAME(),getdate(),'Güncellenmiþ kart',@MusteriId, @EKKNO,@YKKNO)

    -- Insert statements for trigger here

END
GO
