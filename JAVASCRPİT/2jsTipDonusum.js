// tip dönüşüm
let stringNumber = "11"
console.log(stringNumber)
let newNumber = Number(stringNumber)
console.log(newNumber)
console.log("Number Constructor icine bilgi gonderildi:", Number("111"))

//tip dönüşüm
let newString = "21"
console.log("----",Number(newString))

//tip kontrol
console.log("Number :" ,typeof(newNumber))
console.log("String :" ,typeof(stringNumber))

// string(metinsel) bilgileri int ve float'a donusturmek
let number1 = "11"
number1 = parseInt(number1)
console.log("number1: ", number1, typeof(number1) )

let number2 = "11px" //ilk kısmı alıyor
number2 = parseInt(number2)
console.log("number2: ", number2, typeof(number2) )

let number3 = "11.1"
number3 = Number(number3)
console.log("number3: ", number3, typeof(number3) )

let number4 = "11.4px" //virgüllü kısmı alıp px i atıyor
number4 = parseFloat(number4)
console.log("number4: ", number4, typeof(number4) )

// number veri tipinden string'e donusturmek:
let number5 = 55
number5 = number5.toString()
console.log(number5, typeof(number5))

//Bir başka şekilde isInteger( ), isFinite( ) veya isNaN( ) kullanarak da kontrol sağlayabiliriz.

//isInteger( ) yöntemi, sayıların tam sayı olup olmadığını belirler.
Number.isInteger(123) //true
Number.isInteger(0.5) //false

//isFinite () yöntemi, bir değerin sonlu bir sayı olup olmadığını belirler.
Number.isFinite(0) //true
Number.isFinite(0 / 0) //false

// Number.isNaN () yöntemi, bir değerin NaN (Not-A-Number) olup olmadığını belirler.
Number.isNaN(123) //false
Number.isNaN(NaN) //true
