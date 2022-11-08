--DML Data manipulation Language Select insert update delete

select Ad name,Soyad surname, Maas salary from Personel
select Ad + Soyad Unvan, Maas*1.15 from Personel

select Id , ad , soyad , Maas from Personel
where Id != 1
--eþit deðildir

select Id , ad , soyad, Maas from Personel
where ad = 'semanur'

select Id , ad , soyad, Maas from Personel
where ad like 'bur%'

select Id , ad , soyad, Maas from Personel
where ad like '%ra'

select Id , ad , soyad, Maas from Personel
where ad not like '%mi%' or ad like 'do%'

select Id , ad , soyad, Maas from Personel
where Maas not between 3000 and 4500 


select p.Id , ad , soyad, Maas, ISNULL (SehirAd, 'Deðer girilmemiþ')
from Personel p, Sehir s
where p.SehirId = s.Id

select p.Id, Ad , soyad , Maas,ISNULL (SehirAd, 'Deðer girilmemiþ')
from Personel p
inner join Sehir s on s.Id = p.SehirId

select p.Id, Ad , soyad , Maas,ISNULL (SehirAd, 'Deðer girilmemiþ') from Personel p
left outer join Sehir s on s.Id = p.SehirId

select ISNULL (p.Id, 0), ISNULL (Ad, 'Deðer girilmemiþ') , ISNULL (Soyad, 'Deðer girilmemiþ') , ISNULL (Maas, 0), ISNULL (SehirAd, 'Deðer girilmemiþ') from Personel p
full outer join Sehir s on s.Id = p.SehirId


select p.Id, Ad, Soyad, Maas,SehirAd,UlkeAd from Personel p
join Sehir s on s.Id = p.SehirId
join Ulke u on u.Id = p.UlkeId 