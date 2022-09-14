/*
 * »	Užduotys:
1. Suskaičiuoti Žemės rutulio plota (spindulys: 6371 km).  Rezultatą rašyti į kintamąjį.
2. Suskaičiuoti Žemės rutulio tūrį(spindulys: 6371 km). Rezultatą  rašyti įkintamąjį.
3. Suskaičiuoti stačiojo trikampio įžambinės(prieš statųjį kampą esantį stačiojo  trikampio kraštinė) ilgį,jei kitų kraštinių ilgiai yra 10 ir 15. Rezultatą rašyti į  kintamąjį.
4. Suskaičiuoti užduotyse 1-3 gautų kintamųjų sumą ir vidurkį. Įekraną
išvesti rezultatą, kaip pateikta pavyzdyje.
sdsdf

*/


Console.WriteLine("Suskaičiuoti Žemės rutulio plotą");
int spindulys = 6371;
double pi = Math.PI;
double plotas = 4 * pi * (spindulys * spindulys);
Console.WriteLine("Žemės rutulio plotas yra: " + plotas + " km2");






















/* 3 dalis */

double statinisA = 10;
double statinisB = 15;

Console.WriteLine("Staciojo trikampio statiniai: A=10, B =15");

double statinisC = Math.Sqrt(statinisA * statinisA + statinisB * statinisB);
Console.WriteLine("StatinisC: " + statinisC);

/* 4 dalis */

Console.WriteLine("**********************************");
Console.WriteLine("* Kintamasis1 : " + plotas);
Console.WriteLine("* Kintamasis2 : ");
Console.WriteLine("* Kintamasis3 : " + statinisC);
Console.WriteLine("* Suma : " + (plotas + statinisC));
Console.WriteLine("* Vidurkis : " + (plotas + statinisC)/2);
Console.WriteLine("**********************************");







