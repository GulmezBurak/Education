insert into Personel (Ad, Soyad, Maas, SehirId, UlkeId)
Values ('Peter', 'Parker', 5000, 21, 'D' )
--Insert, Listeye yeni data ekliyor. S�ras� �nemli..

select * from Personel

Update Personel set ad='Selin', soyad='Ci�erci',Maas=15000 where Id = 8 --Id si 8 olan�n ad� soyad� maa�� de�i�ti
Update Personel set Maas=Maas*1.30 where UlkeId = 'TR' --T�rk vatanda�� olanlar�n maa��na zam yap�ld�

Delete from Personel where Id = 5