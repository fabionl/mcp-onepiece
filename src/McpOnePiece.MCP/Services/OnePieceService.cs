using McpOnePiece.MCP.Models;

namespace McpOnePiece.MCP.Services;

public interface IOnePieceService
{
  Task<List<Character>> GetCharactersAsync(int page = 1, int limit = 20);
  Task<Character?> GetCharacterByIdAsync(int id);
  Task<List<Character>> SearchCharactersAsync(string name, int page = 1, int limit = 20);

  Task<List<Crew>> GetCrewsAsync(int page = 1, int limit = 20);
  Task<Crew?> GetCrewByIdAsync(int id);
  Task<List<Crew>> SearchCrewsAsync(string name, int page = 1, int limit = 20);

  Task<List<DevilFruit>> GetDevilFruitsAsync(int page = 1, int limit = 20);
  Task<DevilFruit?> GetDevilFruitByIdAsync(int id);
  Task<List<DevilFruit>> SearchDevilFruitsAsync(string name, int page = 1, int limit = 20);
}

public class OnePieceService : IOnePieceService
{
  private readonly IOnePieceApiClient _apiClient;
  private readonly ILogger<OnePieceService> _logger;

  public OnePieceService(IOnePieceApiClient apiClient, ILogger<OnePieceService> logger)
  {
    _apiClient = apiClient;
    _logger = logger;
  }

  public async Task<List<Character>> GetCharactersAsync(int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.GetCharactersAsync();
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting characters from One Piece API");
      return new List<Character>();
    }
  }

  public async Task<Character?> GetCharacterByIdAsync(int id)
  {
    try
    {
      var response = await _apiClient.GetCharacterByIdAsync(id);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting character {CharacterId} from One Piece API", id);
      return null;
    }
  }

  public async Task<List<Character>> SearchCharactersAsync(string name, int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.SearchCharactersAsync(name);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error searching characters with name '{Name}' from One Piece API", name);
      return new List<Character>();
    }
  }

  public async Task<List<Crew>> GetCrewsAsync(int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.GetCrewsAsync(page, limit);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting crews from One Piece API");
      return new List<Crew>();
    }
  }

  public async Task<Crew?> GetCrewByIdAsync(int id)
  {
    try
    {
      var response = await _apiClient.GetCrewByIdAsync(id);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting crew {CrewId} from One Piece API", id);
      return null;
    }
  }

  public async Task<List<Crew>> SearchCrewsAsync(string name, int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.SearchCrewsAsync(name, page, limit);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error searching crews with name '{Name}' from One Piece API", name);
      return new List<Crew>();
    }
  }

  public async Task<List<DevilFruit>> GetDevilFruitsAsync(int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.GetDevilFruitsAsync(page, limit);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting devil fruits from One Piece API");
      return new List<DevilFruit>();
    }
  }

  public async Task<DevilFruit?> GetDevilFruitByIdAsync(int id)
  {
    try
    {
      var response = await _apiClient.GetDevilFruitByIdAsync(id);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error getting devil fruit {FruitId} from One Piece API", id);
      return null;
    }
  }

  public async Task<List<DevilFruit>> SearchDevilFruitsAsync(string name, int page = 1, int limit = 20)
  {
    try
    {
      var response = await _apiClient.SearchDevilFruitsAsync(name: name);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error searching devil fruits with name '{Name}' from One Piece API", name);
      return new List<DevilFruit>();
    }
  }
}
