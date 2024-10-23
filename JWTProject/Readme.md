# JWTProject

JWTProject, ASP.NET Core kullanarak kullanıcı kimlik doğrulaması sağlayan bir Web API projesidir. Projede, kullanıcılar e-posta ve şifre ile giriş yaparak JWT (JSON Web Token) ile kimlik doğrulaması yapılır. Projede, kullanıcı bilgilerinin yönetimi için bir veritabanı bağlantısı ve JWT token üretimi ile doğrulaması yapılmaktadır.

## Özellikler

- **JWT Authentication:** Kullanıcılar e-posta ve şifre ile giriş yaparak bir JWT token alır.
- **Token Doğrulama:** Her istekte alınan token doğrulanarak, sadece yetkili kullanıcıların işlemler yapabilmesi sağlanır.
- **Veritabanı Entegrasyonu:** Kullanıcı bilgileri, veritabanında saklanır ve sorgulanır.

## Kullanılan Teknolojiler

- **ASP.NET Core 6**
- **Entity Framework Core** (EF Core) 
- **SQL Server** (Veritabanı)
- **JWT (JSON Web Token)**
- **Symmetric Security Key** (HMACSHA256 ile imzalama)

## Proje Yapısı

- **Entities:** Uygulamada kullanılan veritabanı varlıkları (`UserEntity`).
- **Dtos:** Veri transfer objeleri (DTO) (`UserLoginDto`).
- **Context:** Veritabanı işlemleri için kullanılan `AppDbContext`.
- **Controllers:** API işlemlerini gerçekleştiren denetleyiciler (`AuthController`).
