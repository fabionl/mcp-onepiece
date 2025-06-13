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
