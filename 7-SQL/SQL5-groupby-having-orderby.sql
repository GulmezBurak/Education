select UnvanAd ,SehirAd,count(UnvanAd) Sayi, sum(Maas) TplmMaas, AVG(Maas) OrtMaas 
from Personel p
join Egitim e on e.Id = p.EgitimId
join Unvan u on u.Id = p.UnvanId
join Ilce i on i.Id = p.IlceId
join Sehir s on s.Id = i.SehirId

Group by UnvanAd,SehirAd
--Having SehirAd = 'Ýstanbul'
Having sum(Maas) > 0
order by UnvanAd

