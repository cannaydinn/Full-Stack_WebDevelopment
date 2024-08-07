
# Inheritance

Bu proje, C# dilinde kapsülleme (encapsulation) ve kalıtım (inheritance) kullanılarak oluşturulmuş bir örnek uygulamadır. Proje, `BaseKisi`, `Ogrenci` ve `Ogretmen` sınıflarını içermektedir.

## Sınıflar ve Özellikler

### BaseKisi Sınıfı
- **Ad** ve **Soyad** özellikleri.
- `BilgiYazdir()` metodu.

### Ogrenci Sınıfı
- `BaseKisi` sınıfından türetilmiştir.
- **OgrenciNumarasi** özelliği.
- `OgrenciBilgiYazdir()` metodu.

### Ogretmen Sınıfı
- `BaseKisi` sınıfından türetilmiştir.
- **MaasBilgisi** özelliği.
- `OgretmenBilgiYazdir()` metodu.
