# Polymorphism (Çok Biçimlilik)

Bu proje, C# dilinde kapsülleme, kalıtım ve polimorfizm ilkelerini kullanarak geometrik şekillerin alanlarını hesaplayan bir uygulamadır. Proje, `BaseGeometrikSekil`, `Kare`, `Dikdortgen` ve `DikUcgen` sınıflarını içermektedir.

## Sınıflar ve Özellikler

### BaseGeometrikSekil Sınıfı
- **Yukseklik** ve **Genislik** özellikleri.
- `AlanHesapla()` abstract metodu.

### Kare Sınıfı
- `BaseGeometrikSekil` sınıfından türetilmiştir.
- `AlanHesapla()` metodunu override eder.

### Dikdortgen Sınıfı
- `BaseGeometrikSekil` sınıfından türetilmiştir.
- `AlanHesapla()` metodunu override eder.

### DikUcgen Sınıfı
- `BaseGeometrikSekil` sınıfından türetilmiştir.
- `AlanHesapla()` metodunu override eder.
