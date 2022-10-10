function alanHesap(r){
    return 3.14*r*r;
}
let daire = alanHesap(3);
console.log(daire)

function alanHesap2(r1, r2){
    return (3.14*r1*r1) * (3.14*r2*r2);
}
let daire2 = alanHesap2(3,2);
console.log(daire2)

const helloFuncV1 = (firstName) => { console.log(`Merhaba ${firstName}`) } 
helloFuncV1("helloFuncV1")

const helloFuncV2 = firstName => console.log(`Merhaba ${firstName}`) // bir parametre, bir donus islemi
helloFuncV2("helloFuncV2")

function Question(hobby) {
    switch (hobby) {
      case "car":
        return function (name) {
          console.log(name + " do you have a car ?");
        };
        break;
  
      case "book":
        return function (name) {
          console.log(name + " what is your favorite author?");
        };
        break;
  
      case "software":
        return function (name, type) {
          console.log(name + " are you interested in " + type + "?");
        };
        break;
  
      default:
        return function (name) {
          console.log(name + "  how are you ?");
        };
        break;
    }
  }
  
  var softwareQuestion = Question("software");
  softwareQuestion("Cemre","nodejs");