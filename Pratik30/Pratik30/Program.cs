var builder = WebApplication.CreateBuilder(args);

// MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews();



var app = builder.Build();
app.MapGet("/", () => "Hello World!");

// Routing Konfigürasyonu
app.UseRouting();


// Statik dosyalarýn kullanýlmasýný saðlar
app.UseStaticFiles();


// Authorization'ý aktif eder
app.UseAuthorization();


// Varsayýlan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller = Home}/{action=Index}");

app.Run();

/*
    Controller: MVC mimarisinde, gelen istekleri iþleyen ve ilgili modeli veya görünümü döndüren sýnýftýr.
                Ýþ mantýðýný yönetir ve Model ile View arasýnda köprü görevi görür.
    
    Action: Controller içinde yer alan metotlardýr ve her biri bir HTTP isteðini iþlemek için tasarlanmýþtýr. 
            Örneðin, bir sayfanýn GET veya POST isteði ile tetiklenebilir.

    Model: Verileri ve uygulamanýn iþ mantýðýný temsil eden yapýdýr. 
           Veritabaný ile etkileþime girer ve verilerin doðrulanmasý veya iþlenmesini saðlar.
    
    View: Kullanýcýya gösterilecek olan arayüzdür. HTML, CSS ve Razor ile yazýlýr ve dinamik içerik sunar.

    Razor: ASP.NET MVC ve Razor Pages ile birlikte kullanýlan bir þablon motorudur. 
           C# kodunu HTML içinde kolayca kullanmaya olanak tanýr. "@{}" yapýsýyla C# kodu yazýlabilir.

    RazorView: Razor motoru tarafýndan iþlenen, kullanýcýya HTML formatýnda sunulan dinamik sayfalarý oluþturur.

    wwwroot: Projedeki statik dosyalarýn (CSS, JavaScript, resimler vb.) bulunduðu klasördür. 
             Bu dosyalar doðrudan istemcilere sunulur ve URL üzerinden eriþilebilir.

    builder.Build(): Uygulamanýn yapýlandýrmasýný tamamlar ve uygulamayý baþlatýr. 
                     Tüm servislerin, middleware'lerin ve yapýlandýrmalarýn tamamlandýðýný belirtir.

    app.Run(): Uygulamanýn ana çalýþtýrma döngüsünü baþlatýr. 
               Gelen HTTP isteklerini dinler ve yanýt verir. Uygulama çalýþtýðý sürece bu metod durmadan devam eder.

    
*/
