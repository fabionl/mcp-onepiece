using System.Text.Json.Serialization;

namespace McpOnePiece.MCP.Models;

public class Character
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("french_name")]
  public string FrenchName { get; set; } = string.Empty;

  [JsonPropertyName("english_name")]
  public string EnglishName { get; set; } = string.Empty;

  [JsonPropertyName("japanese_name")]
  public string JapaneseName { get; set; } = string.Empty;

  [JsonPropertyName("job")]
  public string? Job { get; set; }

  [JsonPropertyName("bounty")]
  public string? Bounty { get; set; }

  [JsonPropertyName("status")]
  public string? Status { get; set; }

  [JsonPropertyName("size")]
  public string? Size { get; set; }

  [JsonPropertyName("age")]
  public string? Age { get; set; }

  [JsonPropertyName("birthday")]
  public string? Birthday { get; set; }

  [JsonPropertyName("crew")]
  public Crew? Crew { get; set; }

  [JsonPropertyName("fruit")]
  public DevilFruit? Fruit { get; set; }
}

public class Crew
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("french_name")]
  public string FrenchName { get; set; } = string.Empty;

  [JsonPropertyName("english_name")]
  public string EnglishName { get; set; } = string.Empty;

  [JsonPropertyName("japanese_name")]
  public string JapaneseName { get; set; } = string.Empty;

  [JsonPropertyName("roman_name")]
  public string? RomanName { get; set; }

  [JsonPropertyName("description")]
  public string? Description { get; set; }

  [JsonPropertyName("status")]
  public string? Status { get; set; }

  [JsonPropertyName("number")]
  public string? Number { get; set; }

  [JsonPropertyName("roman_number")]
  public string? RomanNumber { get; set; }

  [JsonPropertyName("total_prime")]
  public string? TotalPrime { get; set; }

  [JsonPropertyName("is_yonko")]
  public bool? IsYonko { get; set; }
}

public class DevilFruit
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("french_name")]
  public string FrenchName { get; set; } = string.Empty;

  [JsonPropertyName("english_name")]
  public string EnglishName { get; set; } = string.Empty;

  [JsonPropertyName("japanese_name")]
  public string JapaneseName { get; set; } = string.Empty;

  [JsonPropertyName("roman_name")]
  public string? RomanName { get; set; }

  [JsonPropertyName("type")]
  public string? Type { get; set; }

  [JsonPropertyName("description")]
  public string? Description { get; set; }

  [JsonPropertyName("technicalFile")]
  public string? TechnicalFile { get; set; }

  [JsonPropertyName("filename")]
  public string? Filename { get; set; }
}
