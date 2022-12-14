USE [BankaDB2]
GO
/****** Object:  StoredProcedure [dbo].[ParaCekTransaction]    Script Date: 22.09.2022 17:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ParaCekTransaction]
	-- Add the parameters for the stored procedure here
	@MusteriId int, @Tutar decimal(18,0)
AS
BEGIN
declare @ybakiye decimal (18,0)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
Begin Try
begin tran
    -- Insert statements for procedure here
	select @ybakiye = Bakiye-@Tutar from Musteri
	where Id= @MusteriId
	if @ybakiye>= 0
	begin
	update Musteri set Bakiye = Bakiye- @Tutar
	where Id = @MusteriId
	insert into Hareket (MusteriId,Tutar,Tarih)
	values (@MusteriId,@Tutar*-1,getdate())
	commit transaction
	print('İşlem Başarılı')
	end
	else
	begin
	print ('Bakiye yetersiz')
	end
end try
begin catch
rollback
print('Bir Hata Oluştu')
end catch
END
