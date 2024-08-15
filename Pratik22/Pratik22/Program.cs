

using Pratik22;


// Liste tanımlama
// Liste tipi Film sınıfı
List<Film> filmListesi = new List<Film>();
string devam;

do
{
    // Film Sınıfından nesne oluşturma
    Film film = new Film();

    Console.Write("\nFilm Adını giriniz: ");
    film.FilmAdi = Console.ReadLine();

    Console.Write("IMDB puanını giriniz: ");
    film.ImdbPuani = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("\nYeni bir film eklemek ister misiniz? (Evet/Hayır): ");
    devam = Console.ReadLine().ToLower();
    // Listeye elemanları ekleme
    filmListesi.Add(film);

}
while (devam == "evet");


Console.WriteLine("\n1 - Bütün filmleri listele");
// Listedeki büütn elemanları Konsol ekranına yazar
foreach (var film in filmListesi)
{
    film.FilmGetir();
}

// Koşula göre liste elemanlarını konsola yazar
Console.WriteLine("\n2 - IMDB puanı 4 ile 9 arasında olan bütün filmleri listele");
foreach (var film in filmListesi)
{
    film.IMDBPuani();
}

// Koşula göre liste elemanlarını konsola yazar
Console.WriteLine("\n3 - İsmi 'A' ile başlayan filmler ve IMDB puanları listele");
foreach(var film in filmListesi)
{
    film.BaslangicHarfiA();
}