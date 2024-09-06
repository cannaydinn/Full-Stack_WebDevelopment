var builder = WebApplication.CreateBuilder(args);

// MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews();



var app = builder.Build();
app.MapGet("/", () => "Hello World!");

// Routing Konfig�rasyonu
app.UseRouting();


// Statik dosyalar�n kullan�lmas�n� sa�lar
app.UseStaticFiles();


// Authorization'� aktif eder
app.UseAuthorization();


// Varsay�lan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller = Home}/{action=Index}");

app.Run();

/*
    Controller: MVC mimarisinde, gelen istekleri i�leyen ve ilgili modeli veya g�r�n�m� d�nd�ren s�n�ft�r.
                �� mant���n� y�netir ve Model ile View aras�nda k�pr� g�revi g�r�r.
    
    Action: Controller i�inde yer alan metotlard�r ve her biri bir HTTP iste�ini i�lemek i�in tasarlanm��t�r. 
            �rne�in, bir sayfan�n GET veya POST iste�i ile tetiklenebilir.

    Model: Verileri ve uygulaman�n i� mant���n� temsil eden yap�d�r. 
           Veritaban� ile etkile�ime girer ve verilerin do�rulanmas� veya i�lenmesini sa�lar.
    
    View: Kullan�c�ya g�sterilecek olan aray�zd�r. HTML, CSS ve Razor ile yaz�l�r ve dinamik i�erik sunar.

    Razor: ASP.NET MVC ve Razor Pages ile birlikte kullan�lan bir �ablon motorudur. 
           C# kodunu HTML i�inde kolayca kullanmaya olanak tan�r. "@{}" yap�s�yla C# kodu yaz�labilir.

    RazorView: Razor motoru taraf�ndan i�lenen, kullan�c�ya HTML format�nda sunulan dinamik sayfalar� olu�turur.

    wwwroot: Projedeki statik dosyalar�n (CSS, JavaScript, resimler vb.) bulundu�u klas�rd�r. 
             Bu dosyalar do�rudan istemcilere sunulur ve URL �zerinden eri�ilebilir.

    builder.Build(): Uygulaman�n yap�land�rmas�n� tamamlar ve uygulamay� ba�lat�r. 
                     T�m servislerin, middleware'lerin ve yap�land�rmalar�n tamamland���n� belirtir.

    app.Run(): Uygulaman�n ana �al��t�rma d�ng�s�n� ba�lat�r. 
               Gelen HTTP isteklerini dinler ve yan�t verir. Uygulama �al��t��� s�rece bu metod durmadan devam eder.

    
*/
