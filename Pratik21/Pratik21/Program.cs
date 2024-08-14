
// Kahve listesi oluşturma
List<string> kahveListesi = new List<string>();


// Konsoldan veri girişi ve listeye atama
for(int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i+1}: ");
    string kahve = Console.ReadLine();
    kahveListesi.Add(kahve);
}

// Liste elemanlarını yazdırma
Console.WriteLine("Girilen kahve isimleri: ");
foreach(string str in kahveListesi)
{
    Console.WriteLine(str);
}