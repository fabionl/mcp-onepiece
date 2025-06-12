using McpOnePiece.MCP.Endpoints.WeatherForecast;

namespace McpOnePiece.MCP.Endpoints;

public static class MapEndpointsExtensions
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/weatherforecast", GetWeatherForecast)
            .WithName("GetWeatherForecast");

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