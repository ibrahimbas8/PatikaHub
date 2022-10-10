1- city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT City.city, Country.country FROM City
INNER JOIN Country ON City.country_id=Country.country_id;

2- customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT Payment.payment_id, first_name,last_name FROM Customer
INNER JOIN Payment ON Customer.customer_id=Payment.customer_id;

3- customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT rental.rental_id, first_name,last_name FROM Customer
INNER JOIN rental  ON Customer.customer_id = rental.customer_id;
	
