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




//3 uzduotis
Console.WriteLine("Apskaiciuojamas zemes turis");
int r = 6371;
double pI = Math.PI;
double turis = (4 / 3) * pI * (r * r * r);
Console.WriteLine($"Zemes rutulio turis yra: {turis}km3");

















// 3 dalis */


double statinisA = 10;
double statinisB = 15;

Console.WriteLine("Staciojo trikampio statiniai: A=10, B =15");

double statinisC = Math.Sqrt(statinisA * statinisA + statinisB * statinisB);
Console.WriteLine("StatinisC: " + statinisC);

/* 4 dalis */

Console.WriteLine("**********************************");
Console.WriteLine("* Kintamasis1 : ");
Console.WriteLine("* Kintamasis2 : ");
Console.WriteLine("* Kintamasis3 : ");
Console.WriteLine("* Suma : ");
Console.WriteLine("* Vidurkis : ");
Console.WriteLine("**********************************");







