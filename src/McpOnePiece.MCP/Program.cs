using McpOnePiece.MCP.McpTools;
using McpOnePiece.MCP.Services;
using Refit;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<OnePieceTools>();

// Configure One Piece API client
builder.Services
    .AddRefitClient<IOnePieceApiClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.api-onepiece.com/v2"));

// Add One Piece service
builder.Services.AddScoped<IOnePieceService, OnePieceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapMcp();

app.Run();


