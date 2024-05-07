var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();
