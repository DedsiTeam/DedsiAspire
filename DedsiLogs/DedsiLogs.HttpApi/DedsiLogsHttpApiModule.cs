using Dedsi.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DedsiLogs;

[DependsOn(
    typeof(DedsiLogsUseCaseModule),
    typeof(DedsiAspNetCoreModule)
)]
public class DedsiLogsHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DedsiLogsHttpApiModule).Assembly);
        });
    }
}