using Dedsi.AspNetCore;
using DedsiServiceA.HttpApi.Client;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DedsiServiceA;

[DependsOn(
    typeof(DedsiServiceAHttpApiClientModule),

    typeof(DedsiServiceAUseCaseModule),
    typeof(DedsiAspNetCoreModule)
)]
public class DedsiServiceAHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DedsiServiceAHttpApiModule).Assembly);
        });
    }
}