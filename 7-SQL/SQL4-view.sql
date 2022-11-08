create view PersonelListe as
--bütün tablolarý tek bir tablo gibi okuyor

select p.Id , Ad , Soyad , Maas,
SehirAd , UlkeAd
from Personel p
inner join Sehir s on s.Id = p.SehirId
inner join Ulke u on u.Id = p.UlkeId


select * from PersonelListe
