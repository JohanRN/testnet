var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "Net 6 Running";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "Net 6 Running";
});

app.Run($"http://0.0.0.0:{port}");

