

using Pratik24;
using System.Runtime.Intrinsics.Arm;


// Liste Araba sınıfı özelliğinde
List<Araba> arabalar = new List<Araba>();



bool isValidInput = false;
while (!isValidInput)
{

    // Yanlış harf girilmesi durumunda try-catch yapısı ile hatayı yakalayıp tekrar başa döndürür
    try
    {
        Console.Write("\nAraba üretmek istiyor musunuz? (E/H): ");
        string arabaUretim = Console.ReadLine().ToLower();

        if (arabaUretim == "e")
        {
            // Araba Nesnesi oluşturulduğu aşamasında üretim tarihinide oluşturur
            Araba araba = new Araba(DateTime.Now);
            

            // Konsol ekranından değerlerin alınması
            Console.Write("Arabanın seri numarasını giriniz: ");
            araba.SeriNumarasi = Console.ReadLine();

            Console.Write("Arabanın markasını giriniz: ");
            araba.Marka = Console.ReadLine();

            Console.Write("Arabanın modelini giriniz: ");
            araba.Model = Console.ReadLine();

            Console.Write("Arabanın rengini giriniz: ");
            araba.Renk = Console.ReadLine();

        // goto kullanımı
        KapiSayisi:
            try
            {
                Console.Write("Arabanın kapı sayısını giriniz: ");
                araba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş lütfen sayısal bir değer giriniz!!!! ");
                goto KapiSayisi;
            }

            // Listeye elemanları ekler
            arabalar.Add(araba);

        }
        // Araba üretimini sonlandırır
        else if (arabaUretim == "h")
        {
            Console.WriteLine("Araba üretimi iptal edildi.");
            isValidInput = true;
        }
        else
        {
            // Geçersiz cevap için hata fırlatma
            throw new FormatException("Geçersiz cevap! Lütfen 'E' veya 'H' harflerinden birini giriniz.");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Ekrana Liste elemanlarını yazdırma
Console.WriteLine("\n*** Üretilen Arabalar ***");
foreach (var araba in arabalar)
{
    Console.WriteLine("\nSeri Numarası: " + araba.SeriNumarasi);
    Console.WriteLine("Markası: " + araba.Marka);
    Console.WriteLine("Modeli: " + araba.Model);
    Console.WriteLine("Rengi: " + araba.Renk);
    Console.WriteLine("Üretim Tarihi: " + araba.UretimTarihi);
}





