# CodeFirstRelation Projesi

Bu proje, Entity Framework Core kullanarak Code-First yaklaşımı ile kullanıcılar ve postlar (gönderiler) arasında bir ilişki oluşturur. Projede bir kullanıcı birden fazla post yazabilir ve bu ilişki veritabanında sağlanmıştır.

## Proje Yapısı

### Katmanlar

- **Entities:** Veritabanı tablolarına karşılık gelen sınıfların bulunduğu katmandır. `UserEntity` ve `PostEntity` sınıfları burada yer alır.
- **Context:** Veritabanı ile uygulama arasındaki etkileşimi yöneten `DbContext` sınıfıdır. Bu sınıf, veritabanındaki tabloların ve ilişkilerin oluşturulmasını sağlar.
- **Controllers:** `HomeController` sınıfı, API isteklerine yanıt veren kontrolcü katmanıdır.

### Öne Çıkan Özellikler

- **Entity Framework Core:** `PatikaSecondDbContext` sınıfı Entity Framework Core ile veritabanı işlemlerini yönetir. Bu sınıfta kullanıcılar ve postlar arasında bire-çok ilişki tanımlanmıştır.
- **Relational Mapping:** Kullanıcılar ve postlar arasında bire-çok ilişki, `UserEntity` ve `PostEntity` sınıfları aracılığıyla tanımlanmıştır.
- **Code-First Yaklaşımı:** Veritabanı tabloları, doğrudan C# sınıfları (Entity sınıfları) üzerinden oluşturulur ve güncellenir.

## Proje Kurulumu

### Teknolojiler

- .NET 7.0 SDK
- Entity Framework Core
- SQL Server
