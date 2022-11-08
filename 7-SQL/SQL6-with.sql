with
satislar(UrunKod, UrunAd, Satis) as
(select ProductId, p.ProductName ,sum(price)from Hareket h
inner join Products p on p.Id = h.ProductId
where Code = 'S'
group by ProductId,p.ProductName),

iadeler(UrunKod, UrunAd, Iade) as
(select ProductId, p.ProductName ,sum(price)from Hareket h
inner join Products p on p.Id = h.ProductId
where Code = 'R'
group by ProductId,p.ProductName),

iskonto(UrunKod, UrunAd, Iskonto) as
(select ProductId, p.ProductName ,sum(price) from Hareket h
inner join Products p on p.Id = h.ProductId
where Code = 'I'
group by ProductId,p.ProductName),

ceza(UrunKod, UrunAd, Ceza) as
(select ProductId, p.ProductName ,sum(price) from Hareket h
inner join Products p on p.Id = h.ProductId
where Code = 'C'
group by ProductId,p.ProductName)

select s.UrunAd, Satis, Iade,
Iskonto, Ceza, (Satis-Iskonto-Iade-Ceza) NetSatis from satislar s
inner join iadeler r on s.UrunKod = r.UrunKod
inner join iskonto i on i.UrunKod = s.UrunKod
inner join ceza c on c.UrunKod = s.UrunKod

--select ProductId, sum(satis),0 , Sum(iade), sum(isk)
--from Products
--left outer join
--	(select ProductId ,
--		case Code when 'S' then price*1 end satis,
--		case Code when 'R' then price*1 end iade,
--		case Code when 'I' then price*1 end isk from
--Hareket)h on h.ProductId=ProductId
--		group by h.ProductId