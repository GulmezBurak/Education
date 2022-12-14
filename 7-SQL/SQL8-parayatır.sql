USE [BankaDB2]
GO
/****** Object:  StoredProcedure [dbo].[ParaYatir]    Script Date: 20.09.2022 19:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ParaYatir]
	-- Add the parameters for the stored procedure here
	@MusteriId int, @Tutar decimal(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Musteri set Bakiye = Bakiye+ @Tutar 
	insert into Hareket (MusteriId,Tutar,Tarih)
	values (@MusteriId,@Tutar,getdate())
END
