var builder = WebApplication.CreateBuilder(args); // default
// Add services to the container.
builder.Services.AddControllersWithViews(); // adding ability to use controller files (restric personalized views)
var app = builder.Build(); // defualt

app.UseStaticFiles(); // enabling user of css/js/imgs
app.UseRouting(); // enables us to have more than one route / page / view (adds the ./*)
app.UseAuthorization(); // used with db for auth / login

// to set to development mode (error templates)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// app.MapGet("/", () => "Hello World! This is my first web development project with C#");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" // helps set up pattern for routes and tells program to look for the routes in the controller files - [requires controller file]
);

app.Run(); // default