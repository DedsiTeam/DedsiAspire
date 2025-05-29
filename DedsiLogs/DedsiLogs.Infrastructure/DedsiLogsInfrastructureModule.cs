using Dedsi.CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using DedsiLogs.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DedsiLogs;

[DependsOn(
    typeof(DedsiCleanArchitectureInfrastructureModule)
)]
public class DedsiLogsInfrastructureModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // EntityFrameworkCore
        context.Services.AddAbpDbContext<DedsiLogsDbContext>(options =>
        {
            options.AddDefaultRepositories(true);
        });
    }
}