

using Pratik13;

Kitap kitap = new Kitap();
kitap.YazarAd = "Halide Edib";
kitap.YazarSoyad = "Adıvar";
kitap.KitapAdi = "Ateşten Gömlek";
kitap.SayfaSayisi = 253;
kitap.YayinEvi = "Can Yayınları";
kitap.Show();

Kitap kitap1 = new Kitap("Beyaz Zambaklar Ülkesinde", "Grigory", "Petrov", 140, "Koridor Yayıncılık");
kitap1.Show();

Kitap kitap2 = new Kitap("Notre Dame'ın Kamburu", "Victor", "Hugo", 656, "Can Yayınları");
kitap2.Show();

/*
    Class: Kitap Sınıfı, nesneleri ve metotları tanımlamak için kullanılır.

    Property: KitapAdi, YazarAdi, YazarSoyadi, SayfaSayisi, YayinEvi, ve KayitTarihi, Kitap sınıfının özellikleridir.

    New: new anahtar kelimesi, yeni bir Kitap nesnesi oluşturmak için kullanılır.

    Constructor: Kitap sınıfının iki constructor'ı vardır. Default constructor parametre almaz ve KayitTarihi'ni o anki tarih olarak atar. Alternatif constructor ise kitap adı, yazar adı, yazar soyadı, sayfa sayısı ve yayınevi bilgilerini alır ve bu bilgileri ilgili özelliklere atar.
*/




