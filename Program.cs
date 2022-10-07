var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:2095");
var app = builder.Build();


app.MapGet("/", () => StatusCodes.Status200OK );
app.Run();
