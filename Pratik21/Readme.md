# Kahve Listesi Uygulaması

Bu proje, kullanıcının konsol üzerinden gireceği kahve isimleriyle bir liste oluşturur ve bu listeyi ekrana yazdırır. Bu basit C# uygulaması, temel veri yapılarından olan `List<T>` kullanımını ve döngü yapılarıyla verilerin nasıl işlenebileceğini gösterir.

## Proje Özeti

- Kullanıcıdan 5 kahve ismi girmesi istenir.
- Girilen kahve isimleri bir listeye (`List<string>`) eklenir.
- Daha sonra, girilen kahve isimleri ekrana yazdırılır.

## Kod Açıklaması

- `kahveListesi` adlı bir `List<string>` nesnesi oluşturulur.
- `for` döngüsü ile 5 kez kullanıcıdan kahve isimleri istenir ve bu isimler listeye eklenir.
- `foreach` döngüsü kullanılarak listenin elemanları ekrana yazdırılır.

## Örnek Kullanım
Kahve 1: Latte
Kahve 2: Espresso
Kahve 3: Cappuccino
Kahve 4: Mocha
Kahve 5: Americano

Girilen kahve isimleri:
Latte
Espresso
Cappuccino
Mocha
Americano
  

## Kullanılan Teknolojiler

- **Dil:** C#
- **Framework:** .NET Core / .NET Framework (Projenin hedeflediği framework)