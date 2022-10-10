let countriesTalkFrench = new Object();     
countriesTalkFrench.continent = "africa";     
countriesTalkFrench.language = "french"; 

let standartObject = Object.create(Object.prototype)
standartObject.languages = "Türkçe";
standartObject.nationas = "Türk";
standartObject["iki kelime"] = true;
console.log(standartObject.languages);

delete standartObject["iki kelime"];
delete standartObject.languages;