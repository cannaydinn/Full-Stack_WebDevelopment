# DependencyInjectionProject

Bu proje, ASP.NET Core üzerinde bağımlılık enjeksiyonu (Dependency Injection) ve Entity Framework Core kullanarak bir öğretmen yönetim sistemini temel alır. Projede öğretmen bilgilerini yönetmek için bir `Teacher` sınıfı ve bu sınıfla ilgili işlemleri gerçekleştirmek üzere bağımlılık enjeksiyonu (DI) kullanımı gösterilmiştir.

## Proje Yapısı

### Katmanlar

- **Entities:** Veritabanı tablolarına karşılık gelen sınıfların yer aldığı katman.
- **Services:** Uygulama içerisinde kullanılacak bağımlılıkların tanımlandığı ve yönlendirildiği katman.
- **Context:** Veritabanı ile uygulama arasındaki etkileşimi sağlayan DbContext sınıfı.

### Öne Çıkan Özellikler

- **DbContext:** `TeacherDbContext` sınıfı, `Teacher` sınıfına ait verilerin yönetildiği ve Entity Framework Core ile çalışan veritabanı bağlamını tanımlar.
- **Dependency Injection:** `ITeacher` arayüzü üzerinden bağımlılık enjeksiyonu gerçekleştirilmiş ve bu sayede öğretmen bilgileri hem controller'da hem de sınıflarda bağımsız olarak kullanılabilmiştir.
- **API Controller:** `ValuesController` sınıfı, `Teacher` sınıfına ait verileri API üzerinden sunmak için kullanılır.

### 1. Teknolojiler

- .NET 7.0 SDK
- Entity Framework Core
- SQL Server veya uygun bir veritabanı

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=TeacherDb;Trusted_Connection=True;"
  }
}
