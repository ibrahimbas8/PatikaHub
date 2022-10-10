const carpim = (sayi1, sayi2) => sayi1 * sayi2;

console.log(carpim(3, 5));

/*
    // Daha uzun hali ise;
    const carpim = function(sayi1,sayi2){
      return sayi1 * sayi2;
    }
*/

const karesiniAl = (sayi) => sayi * sayi;
console.log(karesiniAl(3))
//Hiç parametre olmadığı zaman ise
const helloWorld = () => console.log('Hello World');
helloWorld()

let experience = prompt('Kac yillik gelistirici tecrubeniz var', 4);

const developer =
  experience < 5
    ? () => alert('Bir cok konuyu biliyorum')
    : () => alert('Hicbir sey bilmiyorum:)');

developer();