
select f.FaturaNo,Tarih,Unvan,Adres,IlceAd+'/'+SehirAd [Il/Ilce],KategoriAd, UrunAd,BirimAd,u.BirimFiyat,Miktar,Tutar  from FatMaster f
inner join Musteri m on m.MusteriId=f.MusteriId
inner join Ilce i on i.IlceId=m.IlceId
inner join Sehir s on s.SehirId=i.SehirId
inner join FatDetay fd on fd.FaturaNo=f.FaturaNo
inner join Urun u on u.UrunId = fd.UrunId
inner join Kategori k on k.KategoriId=u.KategoriId
inner join Birim b on b.BirimId=u.BirimId