1- city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
SELECT City.city, Country.country FROM City	
LEFT JOIN Country  ON City.country_id = Country.country_id;
	
2- customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
SELECT Payment.payment_id, Customer.first_name, Customer.last_name FROM Customer	
RIGHT JOIN Payment ON Payment.customer_id = Customer.customer_id;

3- customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
SELECT Rental.rental_id, Customer.first_name, Customer.last_name FROM Customer	
FULL JOIN Rental ON Rental.customer_id = Customer.customer_id;
	
