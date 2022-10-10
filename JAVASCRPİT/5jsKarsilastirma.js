let price = "1"
let user = "hakan"

// == Eşitse
console.log("== :", price == 1 )
console.log("== :", price == 100 )

// === Hem değeri hem de türü eşitse
console.log("=== :", price === 1 )
console.log("=== :", price === 100 )

// != Eşit değilse
console.log(user != "guest" )

// < Küçükse
console.log("price < 100", price < 100)

// <= Küçük veya eşitse
console.log("price <= 100", price <= 100)

// > Büyükse
console.log("price > 200", price > 200)

// >= Büyük veya eşitse
console.log("price >= 100", price >= 100)


// && ve
price = 0
console.log( price > 0 && user != "guest" )

// || veya
console.log( price > 0 || user != "guest" )

// ! degil (tersi)
user = "guest"
price = 1
console.log( price > 0 && !user == "guest" )

let username = prompt("Kullanici Adinizi Giriniz:");
// eger kullanici bilgisi varsa ekrana ismini yazdir
// eger (username.length > 0) {console.log(username)} degilse {console.log("bilgi yok")}
// if (username.length > 0) {console.log(username)} else {console.log("bilgi yok")}

if (username) {  // if kismi her zaman true ise calisir
    console.log(`Kullanici Bilginiz ${username}`);
} else {
    console.log("bilgi yok");
}

let userName = prompt("Kullanici Adiniz:")
let age = prompt("Yasiniz:")
let info = document.querySelector("#info")

if (userName && age >= 18) {
    info.innerHTML = "ehliyet alabilirsiniz"
} else if (!userName) {
    info.innerHTML = "Kullanici Adiniz Yok"
} else if ( !(age >= 18) ) {
    info.innerHTML = "Yas Bilginiz Yok veya 18 Yasindan Kucuksunuz"
}