using McpOnePiece.MCP.Models;

namespace McpOnePiece.MCP.Services;

public interface IOnePieceService
{
  Task<List<Character>> GetCharactersAsync();
  Task<Character?> GetCharacterByIdAsync(int id);
  Task<List<Character>> SearchCharactersAsync(string name);

  Task<List<Crew>> GetCrewsAsync();
  Task<Crew?> GetCrewByIdAsync(int id);
  Task<List<Crew>> SearchCrewsAsync(string name);

  Task<List<DevilFruit>> GetDevilFruitsAsync();
  Task<DevilFruit?> GetDevilFruitByIdAsync(int id);
  Task<List<DevilFruit>> SearchDevilFruitsAsync(string name);
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

  public async Task<List<Character>> GetCharactersAsync()
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

  public async Task<List<Character>> SearchCharactersAsync(string name)
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

  public async Task<List<Crew>> GetCrewsAsync()
  {
    try
    {
      var response = await _apiClient.GetCrewsAsync();
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

  public async Task<List<Crew>> SearchCrewsAsync(string name)
  {
    try
    {
      var response = await _apiClient.SearchCrewsAsync(name);
      return response;
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error searching crews with name '{Name}' from One Piece API", name);
      return new List<Crew>();
    }
  }

  public async Task<List<DevilFruit>> GetDevilFruitsAsync()
  {
    try
    {
      var response = await _apiClient.GetDevilFruitsAsync();
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

  public async Task<List<DevilFruit>> SearchDevilFruitsAsync(string name)
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
