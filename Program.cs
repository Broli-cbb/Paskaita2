using System;
//Pirma uzduotis-----------
/*
Console.WriteLine("Prasome ivesti vandens temperatura");
int temp = int.Parse(Console.ReadLine());

if (temp < 10)

{
Console.WriteLine("Tai yra saltas vanduo");

}
else if (temp >25)
{
Console.WriteLine("Tai yra karstas vanduo");
}
else
{
    Console.WriteLine("Tai yra vidutines temp vanduo");
}
*/

//Antra uzduotis ==========

/*
 
Console.WriteLine("Iveskite tegiama ar neigiama skaiciu");
int skaicius = int.Parse(Console.ReadLine());

if (skaicius % 2 == 0)
{
    Console.WriteLine("Lyginis");
}
else
{
    Console.Write("Nelyginis");
}

*/

//Trecia uzduotis =============

/*

Console.WriteLine("Iveskite savo amziu ");
int amzius = int.Parse(Console.ReadLine());

if (amzius < 10)

{
    Console.WriteLine("Vaikas");

}
else if (amzius > 18)
{
    Console.WriteLine("Suauges");
}
else
{
    Console.WriteLine("Paauglys");
}

*/

//Ketvirta uzduotis ==============

/*

Console.WriteLine("Iveskite pirma skaiciu palyginimui");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite antra skaiciu palyginimui");

int y = int.Parse(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("Pirmas skaicius yra didesnis");
}

else if (x < y)
{
    Console.WriteLine("Antras skaicius yra didesnis");
}
else
{
    Console.WriteLine("skaiciai yra lygus");
}

*/

//Ketvirtos uzduoties variacija ==============

/*

Console.WriteLine("Iveskite pirma skaiciu palyginimui");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite antra skaiciu palyginimui");

int y = int.Parse(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"{x} yra didesnis");
}

else if (x < y)
{
    Console.WriteLine($"{y} yra didesnis");
}
else
{
    Console.WriteLine("skaiciai yra lygus");
}

*/

//Penkta uzduotis ==========

//Programa turi paprasyti naudotojo ivesti slaptazodis.
//Turi sutapti su anksciau nustatytu slaptazodziu

/*

Console.WriteLine("Prasome ivesti slaptazodi");
string slaptazodis = (Console.ReadLine());

string a = "paslaptis123";

if (slaptazodis == a)
    
{
    Console.WriteLine("Teisingas slaptadozis");
}
else
{
    Console.WriteLine("Slaptadozis neteisingas");
}

*/

//Sesta uzduotis
//Pazymio ivertinimas pagal ivesta pazymi

/*

Console.WriteLine("Prasome ivesti savo gauta pazymi");
int pazymys = int.Parse(Console.ReadLine());

if (pazymys < 5)
{
    Console.WriteLine("Nepatenkinamas");
}

else if (pazymys < 7)
{
    Console.WriteLine("Patenkinamas");
}

else if (pazymys < 9)
{
    Console.WriteLine("Gerai");
}

else
{
    Console.WriteLine("Puikiai");
}

*/

//Septinta uzduotis // kiek kita programa gavosi
//Bilieto kaina pagal amziu ir statusa

/*


Console.WriteLine("Ar esate studentas? 'Taip' 'Ne' ");
string atsakymas = (Console.ReadLine());

string a = "taip";
string ab = "Taip";

string b = "ne";
string ba = "Ne";

if (atsakymas == a)
{
    Console.WriteLine("Turite 50% nulaida");
}

else if (atsakymas == ab)
{
    Console.WriteLine("Turite 50% nulaida");
}
else
{
    Console.WriteLine("Pilna kaina");
}

*/

//Septinta uzduotis

/*

Console.Write("Ar esate studentas?");

string atsakymas = (Console.ReadLine());
string a = "taip";
string ab = "Taip";

if (atsakymas == a)
    
{
    Console.WriteLine("Turite 50% nulaida");
}

else if (atsakymas == ab)
{
    Console.WriteLine("Turite 50% nulaida");
}
else
{
    Console.WriteLine("Koks jusu amzius?");
}

int amzius = int.Parse(Console.ReadLine());

if (amzius <= 6)
{
    Console.WriteLine("Vaikams iki 6 metu kelione nemokamai");
    Console.WriteLine("Grazios keliones");
}

else if (amzius >= 65)
{
    Console.WriteLine("Senjorai turi 30% nuolaida");
    Console.WriteLine("Grazios keliones");
}

else

{
    Console.WriteLine("Pilna kaina");
    Console.WriteLine("Grazios keliones");
}

*/

/* Keistai issprendzia jei sesiametis studentas, gal return funckija?
{
    Console.Write("Ar esate studentas?");
}

string atsakymas = (Console.ReadLine());
string a = "taip";
string ab = "Taip";

if (atsakymas == a)
    
{
    Console.WriteLine("Turite 50% nulaida");
}

else if (atsakymas == ab)
{
    Console.WriteLine("Turite 50% nulaida");
}
else
{
    Console.WriteLine("Pilna kaina");
}
*/

//wup wup needs loops fullproff 

//Astunta uzduotis
//Skaiciaus kategorija (!!!)

/*
 
Console.WriteLine("Skaiciaus kategorija: Iveskite sveika skaiciu");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0 && a > 0)
{
    Console.WriteLine("Teigiamas lyginis skaicius");
}

else if (a % 2 > 0 && a > 0)
{
    Console.WriteLine("Teigiamas nelyginis skaicius");
}

else if (a < 0 && a % 2 == 0)   //(a % 2 == 0 && a < 0)
{
    Console.WriteLine("Neigiamas lyginis skaicius");
}

else if (a < 0 && a % 2 <= -1)   //a % 2 >= 0 && a < 0 //-0 god damn that -0
{
    Console.WriteLine("Neigiamas nelyginis skaicius");
}

else

{
    Console.WriteLine("Skaicius yra nulis");
}

*/

//Devinta uzduotis
//Darbo valandu atlyginimo skaiciavimas

/*
Console.WriteLine("Prasome ivesti dirbtu valandu skaiciu:");
double darbovalandos = double.Parse(Console.ReadLine());

double valandinis = 20;
double virsvalandziai = 1.5;

if (darbovalandos <= 40)
{
    double y = darbovalandos * valandinis;
    Console.WriteLine(y);
}

else if (darbovalandos > 40)

{
    double z = 40 * valandinis + (darbovalandos - 40) * valandinis * virsvalandziai;
    Console.Write(z);
}

Console.WriteLine("Geras darbas");

*/


    
    










