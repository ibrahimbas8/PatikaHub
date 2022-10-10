//foreach ---
const malzemeler = ["yumurta", "un", "süt"];

malzemeler.forEach(function(malzeme, malzemeIndeksi) { //indeksi silebilirsin for gibi elemanları getirir
    console.log(malzeme, malzemeIndeksi);
});

//Map metotu kendine verilen fonksiyonu yapar ancak sonucu yeni bir diziye atar. ---
const sayilar = [1,2,3];

let sayilarin5kati = sayilar.map(function(sayi) {
    return sayi*5;
});
console.log(sayilarin5kati);
// Çıktı olarak [5,10,15] görmeyi bekleriz.

console.log(sayilar);
// Çıktı olarak [1,2,3] görmeyi bekleriz. Orijinal dizimiz aynı kalır.

//Some---
const sayilar2 = [4,5,6];

// sonucu görebilmek çıktıyı sonuc adlı değişkende tutalım:
const sonuc1 = sayilar2.some(function(sayi) {
    return sayi > 5 ;
});

console.log(sonuc1);
// Dizi içerisinde 5'ten büyük bir eleman bulunduğu için çıktıda "true" görmeyi bekleriz.

const sonuc2 = sayilar2.some(function(sayi) {
    return sayi <3;
});

console.log(sonuc2);
// Dizi içerisinde 3'ten küçük herhangi bir sayı olmadığı için çıktıda "false" görmeyi bekleriz.

/*.every()---
every metodu belirtilen bir koşulun dizideki tüm elemanlara uyup uymadığını kontrol ederiz.
some metodunda olduğu gibi, Boolean yani true veya false olarak döner.
True dönebilmesi için dizideki tüm elemanların fonksiyondaki koşula uyması gerekir.*/

/*.filter()---
filter metodu bir dizi içerisindeki belirli bir koşulu sağlayan elemanlar ile yeni bir dizi oluşturmamıza dolayısıyla dizi elemanlarını filtrelememize yarıyor.
Yeni oluşacak diziyi bir değişkende saklıyoruz.
Orijinal dizi bozulmuyor.*/

/*.find()---
Bu metot belirtilen koşula uyum sağlayan dizi elemanını bulmamızı sağlar.
Diğer metotların aksine find metodu elemanın kendisini döner.
Koşulu sağlayan birden fazla eleman varsa, bulduğu ilk elemanı döner.
Koşulu sağlayan bir eleman bulamazsa undefined döner.*/

/*.sort()---
Bu metot, dizi içerisindeki elemanları sıralamaya yarar.
Orijinal dizi sıralanmış şekilde döner. (Yani dizi mutate eder.)
Eğer parametre olarak bir fonksiyon verilmezse dizi elemanları string'e çevrilir ve UTF-16 değerlerine göre sıralanır.
Artan veya azalan olarak sıralamak için farklı bir yol izlenmelidir.*/

// Çıktı olarak [10, 2, 3, 4, 5] alırız. 
//(Sayıların string halleri UTF-16 değerlerine göre sıralandıkları için)
const sayilar3 = [3,5,2,10,4];
sayilar3.sort();
console.log(sayilar3);

// Çıktı olarak [10, 5, 4, 3, 2] alırız.
const sayilar4 = [3,5,2,10,4];
sayilar4.sort(function(a,b) {
    return b-a;
});
console.log(sayilar4);

/*.reduce()---
Bu metot dizimizi yalnızca bir değere indirger.
Parantez içerisine parametre olarak bir fonksiyon ve accumulator'ün (toplayıcının) başlangıç değeri girilir.
Bu metot orijinal diziyi değiştirmez. (Mutate etmez.)
Tam olarak ne yaptığını anlamak için örnekleri inceleyelim.*/

