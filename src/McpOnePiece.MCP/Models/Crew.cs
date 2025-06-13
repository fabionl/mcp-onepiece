using System.Text.Json.Serialization;

namespace McpOnePiece.MCP.Models;

public class Crew
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("roman_name")]
    public string? RomanName { get; set; }

    [JsonPropertyName("total_prime")]
    public string? TotalPrime { get; set; }

    [JsonPropertyName("is_yonko")]
    public bool? IsYonko { get; set; }
}