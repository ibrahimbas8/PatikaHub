1- isminde en az 4 tane e veya E bulanan film sayısı
SELECT COUNT(*)
FROM film
WHERE title ILIKE('%E%E%E%E%');

2- Kategori isimlerini ve kategori başına düşen film sayısını yazınız.
SELECT category.name, COUNT(*) FROM category
INNER JOIN film_category ON category.category_id = film_category.category_id
INNER JOIN film ON film.film_id = film_category.film_id
GROUP BY category.name ;

3- En çok film bulunan rating kategorisi hangisidir?
SELECT COUNT(*),rating FROM film
GROUP BY rating
ORDER BY COUNT(*) DESC
LIMIT 1;

4- Film tablosunda 'K' karakteri ile başlayan en uzun ve replacement kost en az olan 3 filmi listeleyiniz.
SELECT title, length, replacement_cost FROM film
WHERE title LIKE('K%') 
ORDER BY length DESC, replacement_cost 
LIMIT 3;

5- En çok alışveriş yapan müşterinin adı nedir?
SELECT SUM(amount), customer.first_name, customer.last_name FROM payment
INNER JOIN customer ON customer.customer_id = payment.customer_id
GROUP BY payment.customer_id, customer.first_name, customer.last_name
ORDER BY SUM(amount) DESC
LIMIT 1;

6-
