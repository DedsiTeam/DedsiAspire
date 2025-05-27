using Dedsi.CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using DedsiServiceB.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DedsiServiceB;

[DependsOn(
    typeof(DedsiCleanArchitectureInfrastructureModule)
)]
public class DedsiServiceBInfrastructureModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // EntityFrameworkCore
        context.Services.AddAbpDbContext<DedsiServiceBDbContext>(options =>
        {
            options.AddDefaultRepositories(true);
        });
    }
}