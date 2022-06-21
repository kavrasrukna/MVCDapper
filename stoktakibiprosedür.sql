--þartlý ekleme id girmediðinde 0 anlar ve ekleme yapar. ama id girerse güncelleme yapacak
create proc kategoriekle
@kategoriid int,
@kategoriad varchar(50)
as
if @kategoriid=0
insert into tblkategoriler(kategoriad) values (@kategoriad)
else
update tblkategoriler
set
kategoriad=@kategoriad
where kategoriid=@kategoriid

--listeleme iþlemi yapar
create proc kategorilistele
as begin 
select*from  tblkategoriler
end

--sýralama iþlemi yapar
create proc kategorisirala
@kategoriid int
as  
select*from  tblkategoriler where kategoriid=@kategoriid

--silme iþlemi yapar
create proc kategorisilno
@kategoriid int
as  
delete from  tblkategoriler where kategoriid=@kategoriid



--þartlý ekleme id girmediðinde 0 anlar ve ekleme yapar. ama id girerse güncelleme yapacak
create proc musteriekle
@musteriid int,
@musteriad varchar(50),
@musterisoyad varchar(50)
as
if @musteriid=0
insert into tblmusteriler(musteriad,musterisoyad) values (@musteriad,@musterisoyad)
else
update tblmusteriler
set
musteriad=@musteriad,
musterisoyad=@musterisoyad
where musteriid=@musteriid

--listeleme iþlemi yapar
create proc musterilistele
as begin 
select*from  tblmusteriler
end

--sýralama iþlemi yapar
create proc musterisirala
@musteriid int
as  
select*from  tblmusteriler where musteriid=@musteriid

--silme iþlemi yapar
create proc musterisilno
@musteriid int
as  
delete from  tblmusteriler where musteriid=@musteriid



--þartlý ekleme id girmediðinde 0 anlar ve ekleme yapar. ama id girerse güncelleme yapacak
create proc satisekle
@satisid int,
@urunid int,
@musteriid int,
@adet int,
@fiyat decimal(18,0)
as
if @satisid=0
insert into tblsatislar(urunid,musteriid,adet,fiyat) values (@urunid,@musteriid,@adet,@fiyat)
else
update tblsatislar
set
urunid=@urunid,
musteriid=@musteriid,
adet=@adet,
fiyat=@fiyat
where satisid=@satisid

--listeleme iþlemi yapar
create proc satislistele
as begin 
select*from  tblsatislar
end

--sýralama iþlemi yapar
create proc satissirala
@satisid int
as  
select*from  tblsatislar where satisid=@satisid

--silme iþlemi yapar
create proc satissilno
@satisid int
as  
delete from  tblsatislar where satisid=@satisid


--þartlý ekleme id girmediðinde 0 anlar ve ekleme yapar. ama id girerse güncelleme yapacak
create proc urunekle
@urunid int,
@urunad varchar(50),
@marka varchar(50),
@kategoriid int,
@fiyat decimal(18,0),
@stok int
as
if @urunid=0
insert into tblurunler(urunad,marka,kategoriid,fiyat,stok) values (@urunad,@marka,@kategoriid,@fiyat,@stok)
else
update tblurunler
set
urunad=@urunad,
marka=@marka,
kategoriid=@kategoriid,
fiyat=@fiyat,
stok=@stok
where urunid=@urunid

--listeleme iþlemi yapar
create proc urunlistele
as begin 
select*from  tblurunler
end

--sýralama iþlemi yapar
create proc urunsirala
@urunid int
as  
select*from  tblurunler where urunid=@urunid

--silme iþlemi yapar
create proc urunsilno
@urunid int
as  
delete from  tblurunler where urunid=@urunid