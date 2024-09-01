# Kitap ve Yazar Yönetim Sistemi

Bu proje, temel nesne yönelimli programlama (OOP) kavramlarını ve LINQ sorgularını kullanarak iki liste üzerinde birleştirme işlemleri gerçekleştiren basit bir C# konsol uygulamasıdır.

## Özellikler

- **Kitap Sınıfı (Book Class)**: `BookID`, `Title` ve `AuthorID` özelliklerine sahip bir kitap nesnesini temsil eder.
- **Yazar Sınıfı (Author Class)**: `AuthorID` ve `Name` özelliklerine sahip bir yazar nesnesini temsil eder.
- **LINQ Join Sorgusu**: `Book` ve `Author` listelerini `AuthorID`'ye göre birleştirerek kitap başlıklarını ve yazarlarını ekrana yazdırır.

## Kullanılan Teknolojiler

- **C#**: Projenin ana programlama dili.
- **.NET Core**: Konsol uygulamasının derlenmesi ve çalıştırılması için kullanılan framework.
- **LINQ**: Veri sorgulama ve manipülasyonu için kullanılan dil.
- **OOP Kavramları**: Kapsülleme, yapıcı metotlar ve özellikler gibi nesne yönelimli programlama prensipleri uygulanmıştır.

## Gelecekteki Geliştirmeler

- Kitap değerlendirmeleri, yayın yılları ve türleri gibi daha fazla özellik ekleyin.
- Kitap ve yazarlar için CRUD işlemleri (Create, Read, Update, Delete) ekleyin.
- Projeyi Entity Framework kullanarak veritabanı entegrasyonu ile genişletin.
