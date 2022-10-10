let arr = [1,2,3]; //normal dizi

let arr2 = [1,2,"bir string ifade",false,{title:"kodluyoruz"}]; //farklı ifadelerden oluşan dizi

let arr3 = [1,2,3,["dört","beş","altı"],7,8]; //içinde dizi olan dizi

console.log(arr2[2]) //dizi elamanına erişmek
console.log(arr3[3][2]) // dizi içinde dizi elemanına erişmek

console.log("-------------")
//for ile dizide gezmek
for (let i = 0; i < arr2.length; i++) {
  console.log(arr2[i]);
}
console.log("-------------")
//foreach ile dizide gezmek
arr2.forEach((item, index) => { //indexi silebilirsin
  console.log(item, index);
});

//Diziye eleman eklemek sona
var sports = ['basketball', 'football', 'tennis' ];
sports.push('baseball');
console.log(sports); // basketball, football, tennis, baseball

//Diziye eleman eklemek başa
var sports2 = ['basketball', 'football', 'tennis' ];
sports2.unshift('baseball');
console.log(sports2); // baseball, basketball, football, tennis

//Diziye hem eleman ekler hemde siler
//ilk parametre işlemin yapılacağı indexi, ikinci kaç eleman silineceği, üçüncü eklenecek elemanı alır.
var sports3 = ['basketball', 'football', 'tennis' ];
sports3.splice(1,0,'baseball');
console.log(sports3); // basketball, baseball, football, tennis

//Diziden eleman silmek sondan---
var sports4 = ['basketball', 'football', 'tennis' ];
sports4.pop();
console.log(sports4); // basketball, football

//Diziden eleman silmek baştan---
var sports5 = ['basketball', 'football', 'tennis' ];
sports5.shift();
console.log(sports5);  // football, tennis

//Eleman güncellemek---
var sports6 = ['basketball', 'football', 'tennis' ];
sports6[2] = 'judo';
console.log(sports6); // judo

//Aranan eleman dizi içerisinde var mı yok mu kontrol eder---
const alisverisListem = ["elma", "ekmek", "süt"];

const elmaVar = alisverisListem.includes("elma");
console.log(elmaVar);
// Dizi içerisinde elma olduğu için true yazdırmasını bekleriz.

const armutVar = alisverisListem.includes("armut");
console.log(armutVar);
// Dizi içerisinde armut olmadığı için ekrana false yazdırmasını bekleriz.

//Slice (dilimleme) metodu bir dizinin bir kısmının kopyasıyla yeni bir dizi oluşturmamıza olanak sağlıyor.---
//Parantez içerisine ise kopyalamak istediğimiz elemanların aralığını başlangıç ve bitiş indeksleri olacak şekilde iki parametre olarak giriyoruz. Bitiş indeksindeki değerin aralığa dahil olmadığını unutmayalım.
//Bu metot uygulandığı dizinin orijinal halini değiştirmiyor bu yüzden yeni oluşacak diziyi farklı bir değişkende saklıyoruz.
const alisverisListem2 = ["elma", "ekmek", "süt"];

const yeniAlisverisListem = alisverisListem2.slice(0,2);
// "elma"dan başlayıp "süt"e kadar olan elemanları kopyala."süt" dahil değil.

console.log(yeniAlisverisListem);
// ["elma", "ekmek"] görmeyi bekleriz.

//Elemanların arasına değer yazdırmak için kullanırız---
const alisverisListem3 = ["elma", "ekmek", "süt"];

const stringAlisverisListem =  alisverisListem3.join();
console.log(stringAlisverisListem);
// Çıktıda "elma,ekmek,süt" bekleriz.

const stringAlisverisListem2 = alisverisListem3.join(" --- ");
console.log(stringAlisverisListem2);
// Çıktıda "elma kiraz ekmek kiraz süt" bekleriz.

//Bu metot farklı dizileri birleştirip tek bir diziye çevirmemizi sağlıyor.---
const yiyecekler = ["pasta", "baklava", "puding"];
const icecekler = ["su", "kahve"];

const menu = yiyecekler.concat(icecekler);
console.log(menu);
// Çıktıda ["pasta", "baklava", "puding", "su", "kahve"] bekleriz.



