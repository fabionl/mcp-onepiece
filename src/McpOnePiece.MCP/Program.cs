using McpOnePiece.MCP.Endpoints;
using McpOnePiece.MCP.Endpoints.WeatherForecast;
using McpOnePiece.MCP.Endpoints.OnePiece;
using McpOnePiece.MCP.Services;
using Refit;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
    .AddOpenApi()
    .AddSingleton<WeatherForecastHandler>()
    .AddScoped<OnePieceHandler>();

// Configure One Piece API client
builder.Services.AddRefitClient<IOnePieceApiClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.api-onepiece.com/v2"));

// Add One Piece service
builder.Services.AddScoped<IOnePieceService, OnePieceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();  // default path: /scalar
}

// app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();
