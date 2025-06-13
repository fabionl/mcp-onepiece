using McpOnePiece.MCP.Models;
using Refit;

namespace McpOnePiece.MCP.Services;

public interface IOnePieceApiClient
{
  [Get("/characters")]
  Task<OnePieceApiListResponse<Character>> GetCharactersAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/characters/{id}")]
  Task<OnePieceApiResponse<Character>> GetCharacterByIdAsync(int id);

  [Get("/characters/search")]
  Task<OnePieceApiListResponse<Character>> SearchCharactersAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);

  [Get("/crews")]
  Task<OnePieceApiListResponse<Crew>> GetCrewsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/crews/{id}")]
  Task<OnePieceApiResponse<Crew>> GetCrewByIdAsync(int id);

  [Get("/crews/search")]
  Task<OnePieceApiListResponse<Crew>> SearchCrewsAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits")]
  Task<OnePieceApiListResponse<DevilFruit>> GetDevilFruitsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits/{id}")]
  Task<OnePieceApiResponse<DevilFruit>> GetDevilFruitByIdAsync(int id);

  [Get("/fruits/search")]
  Task<OnePieceApiListResponse<DevilFruit>> SearchDevilFruitsAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);
}
