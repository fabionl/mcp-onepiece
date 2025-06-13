using McpOnePiece.MCP.Models;
using Refit;

namespace McpOnePiece.MCP.Services;

public interface IOnePieceApiClient
{
  [Get("/characters/en")]
  Task<List<Character>> GetCharactersAsync();

  [Get("/characters/en/{id}")]
  Task<Character> GetCharacterByIdAsync(int id);

  [Get("/characters/en/search")]
  Task<List<Character>> SearchCharactersAsync([Query] string name);

  [Get("/crews/en")]
  Task<List<Crew>> GetCrewsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/crews/en/{id}")]
  Task<Crew> GetCrewByIdAsync(int id);

  [Get("/crews/en/search")]
  Task<List<Crew>> SearchCrewsAsync([Query] string name, [Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits/en")]
  Task<List<DevilFruit>> GetDevilFruitsAsync([Query] int? page = null, [Query] int? limit = null);

  [Get("/fruits/en/{id}")]
  Task<DevilFruit> GetDevilFruitByIdAsync(int id);

  [Get("/fruits/en/search")]
  Task<List<DevilFruit>> SearchDevilFruitsAsync([Query] string? name = null, [Query] string? fruitType = null);
}
