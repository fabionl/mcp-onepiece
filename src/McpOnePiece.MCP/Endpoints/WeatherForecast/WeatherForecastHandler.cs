namespace McpOnePiece.MCP.Endpoints.WeatherForecast;

public class WeatherForecastHandler
{
    private readonly Random _randomGenerator = Random.Shared;
    private readonly string[] _summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];
    public IEnumerable<WeatherForecastResponse> GetWeatherForecast()
    {
        return Enumerable.Range(1, 5).Select(index =>
            new WeatherForecastResponse
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                _randomGenerator.Next(-20, 55),
                _summaries[_randomGenerator.Next(_summaries.Length)]
            ));
    }
}