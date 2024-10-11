# Survivor Projesi

Bu proje, Entity Framework Core kullanarak Survivor yarışmasındaki kategoriler ve yarışmacılar arasındaki ilişkileri yöneten bir uygulamadır. Proje, kategori ve yarışmacı yönetimi için RESTful API hizmetleri sunar.

## Proje Yapısı

### Katmanlar

- **Entities:** Veritabanı tablolarına karşılık gelen sınıflar burada yer alır. `CategoryEntity` ve `CompetitorEntity` sınıfları burada bulunmaktadır.
- **Context:** Veritabanı ile uygulama arasındaki etkileşimi yöneten `DbContext` sınıfıdır. Bu sınıf, veritabanındaki tabloların ve ilişkilerin oluşturulmasını sağlar.
- **Controllers:** `CategoriesController` ve `CompetitorsController` sınıfları, API isteklerine yanıt veren kontrolcülerdir.

### Öne Çıkan Özellikler

- **Entity Framework Core:** `SurvivorDbContext` sınıfı ile veritabanı işlemleri yönetilmektedir. Kategoriler ve yarışmacılar arasındaki bire-çok ilişki tanımlanmıştır.
- **Code-First Yaklaşımı:** Veritabanı tabloları, doğrudan C# sınıfları üzerinden oluşturulur.
- **RESTful API:** Yarışmacılar ve kategoriler üzerinde CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilir.

## Proje Kurulumu

### Teknolojiler

- .NET 7.0 SDK
- Entity Framework Core
- SQL Server
