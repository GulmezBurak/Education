insert into Personel (Ad, Soyad, Maas, SehirId, UlkeId)
Values ('Peter', 'Parker', 5000, 21, 'D' )
--Insert, Listeye yeni data ekliyor. Sýrasý önemli..

select * from Personel

Update Personel set ad='Selin', soyad='Ciðerci',Maas=15000 where Id = 8 --Id si 8 olanýn adý soyadý maaþý deðiþti
Update Personel set Maas=Maas*1.30 where UlkeId = 'TR' --Türk vatandaþý olanlarýn maaþýna zam yapýldý

Delete from Personel where Id = 5