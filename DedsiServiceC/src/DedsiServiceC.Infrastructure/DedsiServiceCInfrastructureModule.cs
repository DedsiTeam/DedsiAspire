using Dedsi.CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using DedsiServiceC.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DedsiServiceC;

[DependsOn(
    typeof(DedsiCleanArchitectureInfrastructureModule)
)]
public class DedsiServiceCInfrastructureModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // EntityFrameworkCore
        context.Services.AddAbpDbContext<DedsiServiceCDbContext>(options =>
        {
            options.AddDefaultRepositories(true);
        });
    }
}