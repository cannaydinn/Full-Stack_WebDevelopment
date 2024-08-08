# Çalışan Görev Sistemi

Bu proje, bir şirketin çalışanlarını temsil eden bir programdır. Her çalışan, ad, soyad, departman gibi ortak özelliklere sahiptir. Ayrıca her çalışan kendi görevine özgü bir iş yapar. Bu proje, C# dilinde nesne yönelimli programlama (OOP) ilkelerini kullanarak, Soyutlama(Abstract) kalıtım(inheritance) ve Çok Biçimlilik(polymorphism) konseptlerini örneklemektedir.

## Proje Özeti

- **Base Sınıf:** `Calisan`  
  - Ortak özellikler (`Ad`, `Soyad`, `Departman`) ve bir `Gorev` metodu içeren soyut bir sınıf.
  
- **Türetlenmiş Sınıflar:**
  - `YazilimGelistirici`: Yazılım geliştirici olarak çalışanları temsil eder.
  - `ProjeYoneticisi`: Proje yöneticisi olarak çalışanları temsil eder.
  - `SatisTemsilcisi`: Satış temsilcisi olarak çalışanları temsil eder.
  
- **Polimorfizm Kullanımı:**
  - `Calisan` sınıfından türeyen her sınıf, `Gorev` metodunu kendine özgü bir şekilde uygulamaktadır.

## Kullanılan Teknolojiler
- **Programlama Dili:** C#
- **Nesne Yönelimli Programlama (OOP)**
  - Abstraction (Soyutlama)
  - Inheritance (Kalıtım)
  - Polymorphism (Çok Biçimlilik)

