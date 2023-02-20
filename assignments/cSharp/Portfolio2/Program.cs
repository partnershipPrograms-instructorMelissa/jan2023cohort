var builder = WebApplication.CreateBuilder(args); // default
builder.Services.AddControllersWithViews(); // restric personalized views
var app = builder.Build(); // defualt

app.UseStaticFiles(); // enabling user of css/js/imgs
app.UseRouting(); // enables us to have more than one route / page / view (adds the ./*)
app.UseAuthorization(); // used with db for auth / login

// to set to development mode (error templates)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" // [requires controller file]
);

app.Run(); // default