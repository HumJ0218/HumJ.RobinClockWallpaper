var app = WebApplication.CreateBuilder(args).Build();
app.UseStaticFiles().UseDefaultFiles();
app.Run();
