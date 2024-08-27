var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Controller: Client tarafından gelen isteklerin yönetildiği katmandır. Model ve View arasındaki akışı kontrol eder.

//Action: Controller içerisinde tanımlanan clientten gelen istekleri karşılamak için kullanılan metotlardır.

//Model: Tüm veri işlemlerinin gerçekleştiği katmandır. Veritabanından veri çekmekten, iş kurallarının uygulanmasına kadar tüm işlemler burada gerçekleşir.

//View: Uygulamanın son kullanıcıyla etkileşime girdiği katmandır. UI ile ilgili herşey bu katmanda bulunur.

//Razor: C# kodları ile HTML kodlarını bir arada kullanrak web uygulaması geliştirilmesine olanak sağlayan teknolojidir.

//RazorView: C# ile HTML kodlarının bir arada kullanılabilmesini sağlayan teknoloji bileşenidir.

//wwwroot: Uygulamanın içerisinde kullanılacak statik elemanları barındırır. Bunlara CSS, JS ve images örnek gösterilebilir.