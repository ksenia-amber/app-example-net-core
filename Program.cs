var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();//.AddNewtonsoftJson();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/", () => "TimeWeb Cloud + .NET Core = ❤️");
// app.MapGet("/version", () => "1.0.0");

app.Run();
