let username = "ibrahim"
const DOMAIN = "kodluyoruz.org"

let email = username + "@" + DOMAIN

//kötü bir tercih
//console.log("Merhaba ", username ," sitemize hoşgeldin mail adresin: ", email)

//bu şekilde daha estetik ve esnek bir yapı oluşturuyoruz.
let info = `Merhaba ${username} sitemize hosgeldin.. mail adresin: ${email}
mail adresi uzunluğu: ${email.length}
borcunuz: ${(2+3)*10} TL
gunun saat bilgisi: ${new Date().getHours()}
kısa isminiz ${username[0]}.
`
console.log(info)

