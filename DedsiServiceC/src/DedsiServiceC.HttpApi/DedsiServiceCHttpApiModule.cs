using Dedsi.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DedsiServiceC;

[DependsOn(
    typeof(DedsiServiceCUseCaseModule),
    typeof(DedsiAspNetCoreModule)
)]
public class DedsiServiceCHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DedsiServiceCHttpApiModule).Assembly);
        });
    }
}