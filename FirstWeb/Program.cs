var builder = WebApplication.CreateBuilder(args);
// Services brought in befroe you build
builder.Services.AddControllersWithViews();
var app = builder.Build();
// Bring in some features for our app
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Tell our project to run using controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id}");

//This is ALWAYS the last line
app.Run();
