var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
  name: "default",
  pattern: "{controller=Home}/{action=index}/{id?}"
);

app.Run();
