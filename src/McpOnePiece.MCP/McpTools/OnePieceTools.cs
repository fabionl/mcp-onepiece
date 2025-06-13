using System.ComponentModel;
using McpOnePiece.MCP.Models;
using McpOnePiece.MCP.Services;
using ModelContextProtocol.Server;

namespace McpOnePiece.MCP.McpTools;

[McpServerToolType]
public sealed class OnePieceTools(IOnePieceService onePieceService)
{
    [McpServerTool, Description("Get a list of characters.")]
    public async Task<List<Character>> GetCharacters()
    {
        return await onePieceService.GetCharactersAsync();
    }

    [McpServerTool, Description("Get a character by ID.")]
    public async Task<Character?> GetCharacter([Description("The ID of the character to get details for")] int id)
    {
        return await onePieceService.GetCharacterByIdAsync(id);
    }
    
    [McpServerTool, Description("Search for characters by name.")]
    public async Task<List<Character>> SearchCharacters([Description("The name of the character to search for")] string name)
    {
        return await onePieceService.SearchCharactersAsync(name);
    }
}