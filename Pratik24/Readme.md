# Araba Üretim Simülasyonu

Bu proje, konsol üzerinden kullanıcı etkileşimiyle araba üretimi yapan basit bir C# uygulamasıdır. Kullanıcı, bir araba üretmek isteyip istemediğini belirleyebilir ve eğer araba üretmek istiyorsa arabanın özelliklerini girerek bir `Araba` nesnesi oluşturur. Proje ayrıca sayısal olmayan değerlerin girilmesini engellemek için bir hata kontrol mekanizması içermektedir.

## Özellikler

- Kullanıcıya araba üretmek isteyip istemediği sorulur (`E/H` olarak).
- Araba üretimi sırasında, seri numarası, marka, model, renk, ve kapı sayısı kullanıcıdan alınır.
- Üretim tarihi otomatik olarak atanır.
- Kapı sayısı için sayısal olmayan bir giriş yapılırsa, kullanıcıya hata mesajı gösterilir ve doğru bir değer girilene kadar tekrar giriş yapılması istenir.
- Kullanıcı `H` tuşuna bastığında, araba üretimi iptal edilir ve program sonlandırılır.
- Üretilen tüm arabalar, konsol ekranında listelenir.

## Kullanılan Teknolojiler

- **C#**
- **.NET Core**

## Nasıl Kullanılır

1. Uygulama çalıştırıldığında, size araba üretmek isteyip istemediğiniz sorulacak.
2. `E` tuşuna basarsanız, araba üretim sürecine girersiniz ve sizden bazı bilgiler istenecektir.
3. `H` tuşuna basarsanız, uygulama sonlandırılır.
4. Kapı sayısı gibi sayısal veri istenen durumlarda, sayısal olmayan bir değer girerseniz, hata mesajı alırsınız ve tekrar giriş yapmanız istenir.
5. Üretim işlemi tamamlandıktan sonra, üretilen arabalar liste halinde ekrana yazdırılır.
