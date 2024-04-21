// See https://aka.ms/new-console-template for more information
using AttributeTech;

Console.WriteLine("Hello, World!");

Ogrenci ogrenci = new Ogrenci();
ogrenci.bolum = "Yazılım";
ogrenci.adi = "Melike";

//Araba araba = new Araba();
//araba.marka = "bmw";
//araba.model = "X5";

if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Bilgiler doldurulmamış.");
}
else
{
    Console.WriteLine("Bilgiler doldurulmuş.");
}