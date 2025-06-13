using McpOnePiece.MCP.Models;
using McpOnePiece.MCP.Services;

namespace McpOnePiece.MCP.Endpoints.OnePiece;

public class OnePieceHandler
{
  private readonly IOnePieceService _onePieceService;

  public OnePieceHandler(IOnePieceService onePieceService)
  {
    _onePieceService = onePieceService;
  }

  public async Task<IResult> GetCharacters()
  {
    var characters = await _onePieceService.GetCharactersAsync();
    return Results.Ok(characters);
  }

  public async Task<IResult> GetCharacterById(int id)
  {
    var character = await _onePieceService.GetCharacterByIdAsync(id);
    if (character == null)
    {
      return Results.NotFound($"Character with id {id} not found");
    }
    return Results.Ok(character);
  }

  public async Task<IResult> SearchCharacters(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Results.BadRequest("Name parameter is required");
    }

    var characters = await _onePieceService.SearchCharactersAsync(name);
    return Results.Ok(characters);
  }

  public async Task<IResult> GetCrews()
  {
    var crews = await _onePieceService.GetCrewsAsync();
    return Results.Ok(crews);
  }

  public async Task<IResult> GetCrewById(int id)
  {
    var crew = await _onePieceService.GetCrewByIdAsync(id);
    if (crew == null)
    {
      return Results.NotFound($"Crew with id {id} not found");
    }
    return Results.Ok(crew);
  }

  public async Task<IResult> SearchCrews(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Results.BadRequest("Name parameter is required");
    }

    var crews = await _onePieceService.SearchCrewsAsync(name);
    return Results.Ok(crews);
  }

  public async Task<IResult> GetDevilFruits()
  {
    var fruits = await _onePieceService.GetDevilFruitsAsync();
    return Results.Ok(fruits);
  }

  public async Task<IResult> GetDevilFruitById(int id)
  {
    var fruit = await _onePieceService.GetDevilFruitByIdAsync(id);
    if (fruit == null)
    {
      return Results.NotFound($"Devil fruit with id {id} not found");
    }
    return Results.Ok(fruit);
  }

  public async Task<IResult> SearchDevilFruits(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
    {
      return Results.BadRequest("Name parameter is required");
    }

    var fruits = await _onePieceService.SearchDevilFruitsAsync(name);
    return Results.Ok(fruits);
  }
}
