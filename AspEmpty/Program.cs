var builder = WebApplication.CreateBuilder(args);

// MVC Servislerini Ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik Dosyalarýn Kullanýmý
app.UseStaticFiles();

// Routing Yapýlandýrmasý
app.UseRouting();

// Varsayýlan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
 * Açýklamalar:
 *
 * 1. Controller:
 *    - MVC'de, kullanýcýdan gelen istekleri karþýlayan ve iþ mantýðýný yöneten bir sýnýftýr.
 *    - Örnek: HomeController, kullanýcýdan gelen "/Home" isteðini ele alýr.
 *
 * 2. Action:
 *    - Controller içinde tanýmlanan bir yöntemdir.
 *    - Kullanýcýdan gelen isteklere göre belirli bir iþlemi yapar ve bir View veya sonuç döndürür.
 *    - Örnek: HomeController'daki Index() metodu bir Action'dýr.
 *
 * 3. Model:
 *    - Uygulamadaki veri yapýsýný veya iþ mantýðýný temsil eden sýnýftýr.
 *    - Veri tabanýndan gelen verileri taþýr ve iþlenmesini saðlar.
 *    - Örnek: Kullanýcý bilgilerini tutan bir User model sýnýfý.
 *
 * 4. View:
 *    - Kullanýcýya sunulan arayüzü oluþturmak için kullanýlan yapýdýr.
 *    - Razor dilini kullanarak dinamik HTML içerik oluþturabilir.
 *    - Örnek: Views/Home/Index.cshtml.
 *
 * 5. Razor:
 *    - ASP.NET Core tarafýndan kullanýlan, HTML ve C#'ý birleþtiren bir iþaretleme dilidir.
 *    - Örnek: @if (Model != null) { <p>Veri Mevcut</p> }.
 *
 * 6. RazorView:
 *    - Razor motoru tarafýndan iþlenen ve kullanýcýya sunulan dinamik bir HTML çýktýsýdýr.
 *    - View dosyalarýndan oluþturulur.
 *
 * 7. wwwroot:
 *    - Uygulamanýn statik dosyalarýnýn (CSS, JS, resimler) saklandýðý klasördür.
 *    - Örnek: wwwroot/css/styles.css tarayýcýdan eriþilebilir.
 *
 * 8. builder.Build():
 *    - Uygulamanýn yapýlandýrmasýný tamamlar ve çalýþtýrýlabilir bir uygulama örneði oluþturur.
 *
 * 9. app.Run():
 *    - Uygulamayý baþlatýr ve gelen HTTP isteklerini dinlemeye baþlar.
 *    - Bu metot, uygulamanýn ana çalýþtýrma döngüsünü baþlatýr.
 */