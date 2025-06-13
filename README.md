
To use the MCP with VS Code Copilot,
start by initializing the MCP server.

Then add a MCP Server folloing these steps in the UI:

- click on Configure Tools,
- Add More Tools / Add MCP Server / HTTP
- Type the URL of the server: `http://localhost:5100`
- Give it a name, e.g. `OnePieceMCP`
- Choose User or Workspace settings

VS Code will open a settings.json file, add the following configuration:

```json
    "mcp": {
        "servers": {
            "OnePieceMCP": {
                "url": "http://localhost:5100"
            }
        }
    }
```

Clicking again at Configure Tools will show the
MCP server in the list of tools.

<!-- markdownlint-disable-next-line MD033 -->
<img src="vs-code-configure-tools-done.jpg" alt="VS Code Configure Tools Done" width="400" />

After copilot is configured, using the following
prompt will leade Copilot to use the MCP:

```text
What can you tell me about the characters of the OnePiece anime?
```
