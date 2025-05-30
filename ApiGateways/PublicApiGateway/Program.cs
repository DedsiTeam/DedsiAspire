using Microsoft.Extensions.Primitives;
using Yarp.ReverseProxy.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration)
    .AddServiceDiscoveryDestinationResolver();

builder.Services.AddSingleton<IProxyConfigProvider, DBProxyConfigProvider>();

var app = builder.Build();

app.MapReverseProxy();

app.Run();


public class DBProxyConfigProvider : IProxyConfigProvider
{
    public IProxyConfig GetConfig()
    {
        return new InDBConfig(
        [
            new RouteConfig
            {
                RouteId = "forDBRoute",
                ClusterId = "forDBCluster",
                Match = new RouteMatch
                {
                    Path = "/forDB/{**catch-all}"
                }
            }
        ],
        [
            new ClusterConfig
            {
                ClusterId = "forDBCluster",
                Destinations = new Dictionary<string, DestinationConfig>
                {
                    { "forDBDestination", new DestinationConfig { Address = "http://localhost:5000/" } }
                }
            }
        ]);
    }

    private sealed class InDBConfig : IProxyConfig
    {
        // Used to implement the change token for the state
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        public InDBConfig(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
            : this(routes, clusters, Guid.NewGuid().ToString())
        { }

        public InDBConfig(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters, string revisionId)
        {
            RevisionId = revisionId ?? throw new ArgumentNullException(nameof(revisionId));
            Routes = routes;
            Clusters = clusters;
            ChangeToken = new CancellationChangeToken(_cts.Token);
        }

        /// <inheritdoc/>
        public string RevisionId { get; }

        /// <summary>
        /// A snapshot of the list of routes for the proxy
        /// </summary>
        public IReadOnlyList<RouteConfig> Routes { get; }

        /// <summary>
        /// A snapshot of the list of Clusters which are collections of interchangeable destination endpoints
        /// </summary>
        public IReadOnlyList<ClusterConfig> Clusters { get; }

        /// <summary>
        /// Fired to indicate the proxy state has changed, and that this snapshot is now stale
        /// </summary>
        public IChangeToken ChangeToken { get; }

        internal void SignalChange()
        {
            _cts.Cancel();
        }
    }
}