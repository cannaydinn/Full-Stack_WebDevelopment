# Sayı Girişi Doğrulayıcı

Bu proje, kullanıcıdan geçerli bir sayı girilene kadar devam eden bir döngü kullanarak kullanıcı girişi doğrulaması yapan basit bir C# konsol uygulamasıdır. Kullanıcı, geçersiz bir giriş yaptığında, program hatayı yakalar ve doğru bir giriş yapana kadar tekrar denemesini ister.

## Proje Özeti

Bu projede, `while` döngüsü ve `try-catch` bloğu kullanılarak, kullanıcıdan geçerli bir tamsayı girişi alınması sağlanır. Eğer kullanıcı geçersiz bir giriş yaparsa, program bir `FormatException` hatası yakalar ve kullanıcıya hata mesajı gösterir. Geçerli bir sayı girildiğinde döngü sona erer.

## Kullanılan Teknolojiler

	•	C#: Programlama dili
	•	.NET Core: Projenin geliştirildiği ve çalıştığı platform
	•	Exception Handling: Hatalı girişlerin yönetimi
