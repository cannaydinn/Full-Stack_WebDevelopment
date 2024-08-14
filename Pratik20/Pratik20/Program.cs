

// List yapısı kullaanılarak değerlerin ataması
List<string> davetliler = new List<string>() { "Steve Jobs", "Bernard Arnault", "Elon Musk", "Jeff Bezos", "Mark Zuckerberg", "Can Aydın"};

int sayac = 1;

Console.WriteLine("*** Davetliler ***");

// Liste elemanlarını yazdırma işlemi
foreach (var item in davetliler)
{
    Console.WriteLine(sayac+ " - " +item);
    sayac++;
}

