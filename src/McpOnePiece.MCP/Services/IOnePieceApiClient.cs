using McpOnePiece.MCP.Models;
using Refit;

namespace McpOnePiece.MCP.Services;

public interface IOnePieceApiClient
{
  [Get("/characters/en")]
  Task<OnePieceApiListResponse<Character>> GetCharactersAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/characters/en/{id}")]
  Task<OnePieceApiResponse<Character>> GetCharacterByIdAsync(int id);

  [Get("/characters/search")]
  Task<OnePieceApiListResponse<Character>> SearchCharactersAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);

  [Get("/crews/en")]
  Task<OnePieceApiListResponse<Crew>> GetCrewsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/crews/en/{id}")]
  Task<OnePieceApiResponse<Crew>> GetCrewByIdAsync(int id);

  [Get("/crews/search")]
  Task<OnePieceApiListResponse<Crew>> SearchCrewsAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits/en")]
  Task<OnePieceApiListResponse<DevilFruit>> GetDevilFruitsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits/en/{id}")]
  Task<OnePieceApiResponse<DevilFruit>> GetDevilFruitByIdAsync(int id);

  [Get("/fruits/search")]
  Task<OnePieceApiListResponse<DevilFruit>> SearchDevilFruitsAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);
}
