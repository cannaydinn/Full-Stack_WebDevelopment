
using Pratik14;

// Araba sınıfından nesne oluşturma
Araba araba = new Araba("Porsche", "911 GT3 RS", "Gri", 2);
Araba araba2 = new Araba("Audi", "RS6", "Siyah", 6);


// nesnelerin BilgiYazdir() metodunun çağrılması
araba.BilgiYazdir();
Console.WriteLine("-----------------------------------");
araba2.BilgiYazdir();