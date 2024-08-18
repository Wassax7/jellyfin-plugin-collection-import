using MediaBrowser.Controller;
using MediaBrowser.Controller.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Jellyfin.Plugin.CollectionImport
{
    /// <summary>
    /// Register CollectionImport services.
    /// </summary>
    public class PluginServiceRegistrator : IPluginServiceRegistrator
    {
        /// <inheritdoc />
        public void RegisterServices(IServiceCollection serviceCollection, IServerApplicationHost applicationHost)
        {
           serviceCollection.AddSingleton<CollectionImportManager>();
           serviceCollection.AddSingleton<MdbClientManager>();
           //serviceCollection.AddScoped<IEnumerableInterleave>();
        }
    }
}