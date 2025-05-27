using Dedsi.CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using DedsiServiceA.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DedsiServiceA;

[DependsOn(
    typeof(DedsiCleanArchitectureInfrastructureModule)
)]
public class DedsiServiceAInfrastructureModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // EntityFrameworkCore
        context.Services.AddAbpDbContext<DedsiServiceADbContext>(options =>
        {
            options.AddDefaultRepositories(true);
        });
    }
}