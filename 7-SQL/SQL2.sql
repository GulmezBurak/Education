select ad,soyad,maas, 
u1.UlkeAd Ikamet, u2.UlkeAd Uyruk from Personel p
inner join Ulke u1 on u1.Id = p.IkametId
inner join Ulke u2 on u2.Id = p.VatandasId
inner join Egitim e on e.Id = p.EgitimId

