using McpOnePiece.MCP.Endpoints.WeatherForecast;
using McpOnePiece.MCP.Endpoints.OnePiece;

namespace McpOnePiece.MCP.Endpoints;

public static class MapEndpointsExtensions
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
    {
        // Weather forecast endpoints (keeping for now)
        builder.MapGet("/weatherforecast", GetWeatherForecast)
            .WithName("GetWeatherForecast");

        // One Piece API endpoints
        var onePieceGroup = builder.MapGroup("/onepiece")
            .WithTags("One Piece");

        // Character endpoints
        onePieceGroup.MapGet("/characters",
            async (OnePieceHandler handler) =>
                await handler.GetCharacters())
            .WithName("GetCharacters")
            .WithOpenApi();

        onePieceGroup.MapGet("/characters/{id:int}",
            async (OnePieceHandler handler, int id) =>
                await handler.GetCharacterById(id))
            .WithName("GetCharacterById")
            .WithOpenApi();

        onePieceGroup.MapGet("/characters/search",
            async (OnePieceHandler handler, string name) =>
                await handler.SearchCharacters(name))
            .WithName("SearchCharacters")
            .WithOpenApi();

        // Crew endpoints
        onePieceGroup.MapGet("/crews",
            async (OnePieceHandler handler) =>
                await handler.GetCrews())
            .WithName("GetCrews")
            .WithOpenApi();

        onePieceGroup.MapGet("/crews/{id:int}",
            async (OnePieceHandler handler, int id) =>
                await handler.GetCrewById(id))
            .WithName("GetCrewById")
            .WithOpenApi();

        onePieceGroup.MapGet("/crews/search",
            async (OnePieceHandler handler, string name) =>
                await handler.SearchCrews(name))
            .WithName("SearchCrews")
            .WithOpenApi();

        // Devil Fruit endpoints
        onePieceGroup.MapGet("/fruits",
            async (OnePieceHandler handler) =>
                await handler.GetDevilFruits())
            .WithName("GetDevilFruits")
            .WithOpenApi();

        onePieceGroup.MapGet("/fruits/{id:int}",
            async (OnePieceHandler handler, int id) =>
                await handler.GetDevilFruitById(id))
            .WithName("GetDevilFruitById")
            .WithOpenApi();

        onePieceGroup.MapGet("/fruits/search",
            async (OnePieceHandler handler, string name) =>
                await handler.SearchDevilFruits(name))
            .WithName("SearchDevilFruits")
            .WithOpenApi();

        return builder;
    }

    private static WeatherForecastResponse[] GetWeatherForecast(
        WeatherForecastHandler weatherForecastHandler)
    {
        return weatherForecastHandler
            .GetWeatherForecast()
            .ToArray();
    }
}