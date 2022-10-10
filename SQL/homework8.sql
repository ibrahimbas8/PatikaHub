1- test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee(
	id INT,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
)

2- Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
--eklendi

3- Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.

UPDATE employee
SET name = 'İbrahim',
	birthday = '1998-08-18',
	email = 'bas.ibrahim7@gmail.com'
WHERE id = 1; 

UPDATE employee
SET name = 'Derin',
	birthday = '1978-03-12',
	email = 'derin@gmail.com'
WHERE name='Derrek'; 

UPDATE employee
SET name = 'Veli',
	birthday = '1978-03-12',
	email = 'veli@gmail.com'
WHERE birthday='1979-07-08'; 

UPDATE employee
SET name = 'Can',
	birthday = '1992-03-12',
	email = 'Can@gmail.com'
WHERE email='rheikkinen1b@miitbeian.gov.cn'; 

UPDATE employee
SET birthday = '1992-03-12'
WHERE birthday IS NULL; 

4- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

DELETE FROM employee
WHERE id=12;

DELETE FROM employee
WHERE name = 'Gunner';

DELETE FROM employee
WHERE birthday = '1979-07-03';

DELETE FROM employee
WHERE email = 'ienochsson8@51.la';

DELETE FROM employee
WHERE email IS NULL;
