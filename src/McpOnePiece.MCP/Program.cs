using McpOnePiece.MCP.Endpoints;
using McpOnePiece.MCP.Endpoints.WeatherForecast;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
    .AddOpenApi()
    .AddSingleton<WeatherForecastHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();
