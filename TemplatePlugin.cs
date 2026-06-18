using Ivy.Plugins;

[assembly: IvyPlugin(typeof(Ivy.Tendril.Plugin.Template.TemplatePlugin))]

namespace Ivy.Tendril.Plugin.Template;

public class TemplatePlugin : IIvyPlugin<ITendrilPluginContext>
{
    public PluginManifest Manifest { get; } = new()
    {
        Id = "Ivy.Tendril.Plugin.Template",
        Title = "Template",
        ConfigSectionName = "Template",
        Version = new Version(1, 0, 0),
        Icon = PluginIcon.Named("Puzzle"),
    };

    public PluginConfigurationSchema ConfigurationSchema { get; } = new()
    {
        Fields =
        [
            new()
            {
                Key = "ApiKey",
                Type = ConfigFieldType.Secret,
                IsRequired = true,
                Description = "Your API key"
            }
        ]
    };

    public void Configure(ITendrilPluginContext context)
    {
        var apiKey = context.Config.GetValue("ApiKey")!;

        // Register services, messaging channels, etc.
        // Example: context.RegisterMessagingChannel(new MyChannel(apiKey));
    }
}
