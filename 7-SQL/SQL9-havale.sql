-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
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
CREATE PROCEDURE Havale
	-- Add the parameters for the stored procedure here
	@GMusteriId int, @AMusteriId int, @Tutar decimal(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Musteri set Bakiye = Bakiye-@Tutar
	where Id = @GMusteriId
	update Musteri set Bakiye = Bakiye+@Tutar
	where Id = @AMusteriId
	insert into Hareket (MusteriId,Tutar,Tarih)
	values (@AMusteriId, @Tutar, getdate())
	insert into Hareket (MusteriId,Tutar,Tarih)
	values (@GMusteriId, @Tutar*-1, getdate())
END
GO
