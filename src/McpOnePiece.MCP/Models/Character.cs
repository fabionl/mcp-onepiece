using System.Text.Json.Serialization;

namespace McpOnePiece.MCP.Models;

public class Character
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("name")]
  public string Name { get; set; } = string.Empty;

  [JsonPropertyName("job")]
  public string? Job { get; set; }

  [JsonPropertyName("size")]
  public string? Size { get; set; }

  [JsonPropertyName("birthday")]
  public string? Birthday { get; set; }

  [JsonPropertyName("age")]
  public string? Age { get; set; }

  [JsonPropertyName("bounty")]
  public string? Bounty { get; set; }

  [JsonPropertyName("status")]
  public string? Status { get; set; }

  [JsonPropertyName("crew")]
  public Crew? Crew { get; set; }

  [JsonPropertyName("fruit")]
  public DevilFruit? Fruit { get; set; }
}