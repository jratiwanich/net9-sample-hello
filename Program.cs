var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.UseStaticFiles(); // Enable serving static files (if needed)
app.UseRouting();
//app.MapDefaultControllerRoute();
app.MapDefaultControllerRoute();
app.Run();
