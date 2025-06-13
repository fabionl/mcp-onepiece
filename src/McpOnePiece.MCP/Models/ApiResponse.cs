using System.Text.Json.Serialization;

namespace McpOnePiece.MCP.Models;

public class OnePieceApiResponse<T>
{
  [JsonPropertyName("data")]
  public T Data { get; set; } = default!;

  [JsonPropertyName("meta")]
  public Meta? Meta { get; set; }
}

public class OnePieceApiListResponse<T>
{
  [JsonPropertyName("data")]
  public List<T> Data { get; set; } = new();

  [JsonPropertyName("meta")]
  public Meta? Meta { get; set; }
}

public class Meta
{
  [JsonPropertyName("total")]
  public int Total { get; set; }

  [JsonPropertyName("per_page")]
  public int PerPage { get; set; }

  [JsonPropertyName("current_page")]
  public int CurrentPage { get; set; }

  [JsonPropertyName("last_page")]
  public int LastPage { get; set; }

  [JsonPropertyName("first_page_url")]
  public string? FirstPageUrl { get; set; }

  [JsonPropertyName("last_page_url")]
  public string? LastPageUrl { get; set; }

  [JsonPropertyName("next_page_url")]
  public string? NextPageUrl { get; set; }

  [JsonPropertyName("prev_page_url")]
  public string? PrevPageUrl { get; set; }

  [JsonPropertyName("path")]
  public string? Path { get; set; }

  [JsonPropertyName("from")]
  public int? From { get; set; }

  [JsonPropertyName("to")]
  public int? To { get; set; }
}
