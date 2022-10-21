var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/version", () => Environment.Version.ToString());
app.MapGet("/", () => "Hello World!");

app.Run();
