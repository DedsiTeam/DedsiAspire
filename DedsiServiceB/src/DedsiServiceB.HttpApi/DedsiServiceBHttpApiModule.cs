using Dedsi.AspNetCore;
using DedsiServiceA.HttpApi.Client;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DedsiServiceB;

[DependsOn(
    typeof(DedsiServiceAHttpApiClientModule),

    typeof(DedsiServiceBUseCaseModule),
    typeof(DedsiAspNetCoreModule)
)]
public class DedsiServiceBHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DedsiServiceBHttpApiModule).Assembly);
        });
    }
}