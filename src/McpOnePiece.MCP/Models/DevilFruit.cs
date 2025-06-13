using System.Text.Json.Serialization;

namespace McpOnePiece.MCP.Models;

public class DevilFruit
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("roman_name")]
    public string? RomanName { get; set; }

    [JsonPropertyName("technicalFile")]
    public string? TechnicalFile { get; set; }
}