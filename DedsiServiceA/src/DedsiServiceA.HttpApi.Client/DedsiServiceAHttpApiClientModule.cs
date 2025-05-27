using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DedsiServiceA.HttpApi.Client;

[DependsOn(
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpHttpClientModule)
)]
public class DedsiServiceAHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "DedsiServiceA";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DedsiServiceAHttpApiClientModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DedsiServiceAHttpApiClientModule>();
        });
    }
}
