using System;
using System.Collections.Generic;
using Jellyfin.Plugin.MediaList.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.MediaList;

/// <summary>
/// The main plugin.
/// </summary>
public class MediaListPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Plugin"/> class.
    /// </summary>
    /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
    /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
    public MediaListPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    /// <inheritdoc />
    public override string Name => "MediaList";

    /// <inheritdoc />
    public override Guid Id => Guid.Parse("a708187e-5f82-4610-9c84-ec1f2837d5fe");

    /// <summary>
    /// Gets the current plugin instance.
    /// </summary>
    public static MediaListPlugin? Instance { get; private set; }

    /// <inheritdoc />
    public IEnumerable<PluginPageInfo> GetPages()
    {
            var prefix = GetType().Namespace;
            yield return new PluginPageInfo
            {
                Name = Name,
                EmbeddedResourcePath = prefix + ".Configuration.config.html",
            };

            // yield return new PluginPageInfo
            // {
            //     Name = $"{Name}.js",
            //     EmbeddedResourcePath = prefix + ".Configuration.config.js"
            // };
    }
}
