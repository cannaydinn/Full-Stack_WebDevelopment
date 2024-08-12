# Teknoloji Mağazası Ürün Yönetim Sistemi

Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar ürünlerinin kayıt altına alınmasını ve yönetilmesini sağlayan bir konsol uygulamasıdır.

## Teknolojiler
Bu proje C# dilinde yazılmış olup nesne yönelimli programlama (OOP) ilkelerini kullanarak sınıf ve metodlar arasında kalıtım, kapsülleme, polimorfizm ve soyutlama gibi kavramlar kullanılmıştır.
.NET 8 SDK: Bu projede, C# dilinde yazılmış kodların derlenmesi ve çalıştırılması için .NET 8 SDK kullanılmıştır.

## Özellikler

- **Telefon ve Bilgisayar ürünlerinin kaydı**: Kullanıcı, telefon veya bilgisayar üretme seçeneklerinden birini seçerek ilgili ürünü kaydedebilir.
- **Ürün özelliklerinin belirlenmesi**: Kullanıcı, her bir ürün için gerekli olan bilgileri (Ad, Seri Numarası, İşletim Sistemi, vb.) konsol üzerinden girer.
- **Polimorfizm (Çok Biçimlilik)**: `BaseMakine` sınıfında tanımlanan `BilgileriYazdir()` ve `UrunAdiGetir()` metotları, `Telefon` ve `Bilgisayar` sınıflarında ezilmiştir. Bu sayede her ürün türü, kendi özelliklerine uygun çıktılar verir.
- **Kapsülleme (Encapsulation)**: Bilgisayar sınıfında `UsbGirisSayisi` değişkeni sadece 2 veya 4 olarak atanabilir. Aksi durumda varsayılan olarak `-1` değeri atanır ve bir uyarı mesajı verilir.
- **Abstraction (Soyutlama)**: `BaseMakine` sınıfında soyut olarak tanımlanan `UrunAdiGetir()` metodu, her alt sınıfta (Telefon, Bilgisayar) farklı bir biçimde uygulanır.

## Kullanım

1. Proje çalıştırıldığında, kullanıcıdan telefon veya bilgisayar üretmek için bir seçenek seçmesi istenir.
2. Seçime bağlı olarak, ilgili ürünün özellikleri konsol üzerinden girilir.
3. Girilen bilgilere göre ürün oluşturulur ve ürün bilgileri konsola yazdırılır.
4. Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur.
5. Kullanıcı devam etmek isterse program yeniden başlar, aksi takdirde program sonlanır.
