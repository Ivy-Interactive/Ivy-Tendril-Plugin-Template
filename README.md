# Ivy Tendril Plugin Template

A template for creating [Ivy Tendril](https://github.com/Ivy-Interactive/Ivy-Tendril) plugins.

## Getting Started

1. Clone or use this template repository
2. Rename `Ivy.Tendril.Plugin.Template` to your plugin name (e.g., `Ivy.Tendril.Plugin.MyPlugin`)
3. Update `TemplatePlugin.cs` with your plugin logic
4. Update the `.csproj` metadata (PackageId, Authors, Description, URLs)

## Development

Build the plugin:

```bash
dotnet build
```

### Testing Locally

Add your plugin to `<TENDRIL_HOME>/plugins/plugin-references.yaml`:

```yaml
- /absolute/path/to/your/plugin/project
```

Tendril will automatically build and load your plugin. Source file changes trigger hot-reload.

## Publishing

To publish to NuGet for marketplace submission:

```bash
dotnet pack -c Release
dotnet nuget push bin/Release/*.nupkg --source https://api.nuget.org/v3/index.json --api-key YOUR_KEY
```

## Project Structure

```
Ivy.Tendril.Plugin.Template/
├── Ivy.Tendril.Plugin.Template.csproj   # Project file with NuGet metadata
├── TemplatePlugin.cs                     # Plugin entry point
└── README.md
```

## Plugin Capabilities

Depending on which abstraction package you reference, your plugin can:

| Package | Capabilities |
|---------|-------------|
| `Ivy.Tendril.Plugin.Abstractions` | Messaging channels, `TendrilHome` access |
| `Ivy.Tendril.Plugin.Extended.Abstractions` | UI contributions (dialogs, menu items, apps) |

To add UI contributions, add the extended package:

```bash
dotnet add package Ivy.Tendril.Plugin.Extended.Abstractions
```

Then cast to `ITendrilExtendedPluginContext` in your `Configure()` method.

## Resources

- [Tendril Plugin Developer Guide](https://github.com/Ivy-Interactive/Ivy-Tendril/tree/main/src/plugins/README.md)
