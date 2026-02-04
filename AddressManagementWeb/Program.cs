var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Статические файлы (css, js)
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Маршрут по умолчанию: / → AddressController → Index()
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Address}/{action=Index}/{id?}");

app.Run();