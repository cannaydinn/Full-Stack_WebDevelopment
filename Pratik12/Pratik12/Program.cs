

using Pratik12;

// Parametresiz Bebek nesnesi 
Bebek bebek1 = new Bebek();

bebek1.DogumTarihi = DateTime.Now;
bebek1.Ad = "Can";
bebek1.Soyad = "Aydın";

Console.WriteLine($"Bebek 1 - Ad: {bebek1.Ad}, Soyad: {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

// Parametreli bebek nesnesi
Bebek bebek2 = new Bebek("Can", "Aydın");

Console.WriteLine($"Bebek 2 - Ad: {bebek2.Ad}, Soyad: {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");









