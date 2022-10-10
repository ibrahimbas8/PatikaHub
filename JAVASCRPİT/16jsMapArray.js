//array.map( function(value, index, array), this)
/*
array : Üzerinde işlem yapılacak olan diziyi belirtir. Bu dizinin her bir elemanı map metotunun içinde belirleyeceğimiz işleme tabi tutulacaktır.
value : Üzerinde işlem yapılan dizi değerini belirtir.
array : Üzerinde işlem yapılan diziye erişimi sağlar
this : Kullanımı zorunlu değildir(opsiyoneldir). this değişkenine iletilecek olan değeri belirtir.*/

const sayilar = [2, 3, 4, 5, 10]
const yeniArray = sayilar.map(deger => deger * 2)

console.log(sayilar);
//[2, 3, 4, 5, 10]
console.log(yeniArray);
//[4, 6, 8, 10, 20]

//-----------------------------

const maaslar = [ 1100, 13000, 2500, 4500, 1500, 25000, 2000 ];
const yeniMaaslar = maaslar.map((e)=>{
    if(e > 3000)
        return e * 1.15;
    else
        return e * 1.25;
});

console.log( yeniMaaslar );