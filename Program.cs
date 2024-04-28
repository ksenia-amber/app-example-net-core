var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "TimeWeb Cloud + .NET Core = ❤️");
app.MapGet("/version", () => "1.0.0");

app.Run();
