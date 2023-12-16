var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

//var port = Environment.GetEnvironmentVariable("PORT")??"8080";

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "V1 Diboks enginier GET - Net 6";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "V1 Diboks enginier  POST - Net 6";
});

//app.Run($"http://0.0.0.0:{port}");
app.Run();
