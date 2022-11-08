select p.Ad,p.Soyad, p.Adres,
IlceAd + '/' + SehirAd [Il/Ilce],
EgitimAd Egitim, UnvanAd Unvan,
yp.Ad + ' ' + yp.Soyad Yonetici
 
from Personel p
inner join Ilce i on i.Id = p.IlceId
inner join Sehir s on s.Id = i.SehirId
inner join Egitim e on e.Id = p.EgitimId
inner join Unvan u on u.Id = p.UnvanId
left join Personel yp on yp.Id = p.YoneticiId