// ** Ilk Fonksiyonumuzu Tanimlamak:

function helloWorld() {
    console.log("Hello World")
}

function hello() {
    console.log("Merhaba")
    helloWorld()
}

hello() // calistir

// hata alabiliriz...
// function userCheck () {
//     if (userName && age >= 18) {
//         info.innerHTML = "ehliyet alabilirsiniz"
//     } else if (!userName) {
//         info.innerHTML = "Kullanici Adiniz Yok"
//     } else if ( !(age >= 18) ) {
//         info.innerHTML = "Yas Bilginiz Yok veya 18 Yasindan Kucuksunuz"
//     }
// }

function addition(sayi1,sayi2){  //function name and parameters
    console.log(sayi1+sayi2);     //body
}
addition(3,2)

var add = function (sayi1,sayi2){  //Anonim bir fonksiyon oluşturduktan sonra bu 
    //fonsksiyonu bir değişkene atadık
console.log(sayi1+sayi2);
}
add(3,3)

function addition2(sayi1,sayi2){
    return (sayi1+sayi2);
}
var add2 = addition2(3,4);   //add değişkenine 3+4 değerini fonksiyon kullanarak atadık.
console.log(add2)

//paremetre alan fonksiyonlara az veya fazla parametre girersek 
function mesajVer(ad, soyad) {
    alert(`Merhaba ${ad} ${soyad}`);
  }
  
  mesajVer("Arturo", "Kelesoglu", "Mr."); //3.elemanı yok sayar
  mesajVer("Arturo"); // boş kısmı undefined yazar
  mesajVer(); //boş kısımlara undefined yazar

  