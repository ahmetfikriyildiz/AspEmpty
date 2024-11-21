var builder = WebApplication.CreateBuilder(args);

// MVC Servislerini Ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik Dosyalar�n Kullan�m�
app.UseStaticFiles();

// Routing Yap�land�rmas�
app.UseRouting();

// Varsay�lan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
 * A��klamalar:
 *
 * 1. Controller:
 *    - MVC'de, kullan�c�dan gelen istekleri kar��layan ve i� mant���n� y�neten bir s�n�ft�r.
 *    - �rnek: HomeController, kullan�c�dan gelen "/Home" iste�ini ele al�r.
 *
 * 2. Action:
 *    - Controller i�inde tan�mlanan bir y�ntemdir.
 *    - Kullan�c�dan gelen isteklere g�re belirli bir i�lemi yapar ve bir View veya sonu� d�nd�r�r.
 *    - �rnek: HomeController'daki Index() metodu bir Action'd�r.
 *
 * 3. Model:
 *    - Uygulamadaki veri yap�s�n� veya i� mant���n� temsil eden s�n�ft�r.
 *    - Veri taban�ndan gelen verileri ta��r ve i�lenmesini sa�lar.
 *    - �rnek: Kullan�c� bilgilerini tutan bir User model s�n�f�.
 *
 * 4. View:
 *    - Kullan�c�ya sunulan aray�z� olu�turmak i�in kullan�lan yap�d�r.
 *    - Razor dilini kullanarak dinamik HTML i�erik olu�turabilir.
 *    - �rnek: Views/Home/Index.cshtml.
 *
 * 5. Razor:
 *    - ASP.NET Core taraf�ndan kullan�lan, HTML ve C#'� birle�tiren bir i�aretleme dilidir.
 *    - �rnek: @if (Model != null) { <p>Veri Mevcut</p> }.
 *
 * 6. RazorView:
 *    - Razor motoru taraf�ndan i�lenen ve kullan�c�ya sunulan dinamik bir HTML ��kt�s�d�r.
 *    - View dosyalar�ndan olu�turulur.
 *
 * 7. wwwroot:
 *    - Uygulaman�n statik dosyalar�n�n (CSS, JS, resimler) sakland��� klas�rd�r.
 *    - �rnek: wwwroot/css/styles.css taray�c�dan eri�ilebilir.
 *
 * 8. builder.Build():
 *    - Uygulaman�n yap�land�rmas�n� tamamlar ve �al��t�r�labilir bir uygulama �rne�i olu�turur.
 *
 * 9. app.Run():
 *    - Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinlemeye ba�lar.
 *    - Bu metot, uygulaman�n ana �al��t�rma d�ng�s�n� ba�lat�r.
 */