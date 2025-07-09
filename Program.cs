
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Serves index.html by default
app.UseStaticFiles();  // Serves files in wwwroot

app.Run();
