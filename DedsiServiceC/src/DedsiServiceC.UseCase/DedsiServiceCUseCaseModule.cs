using Volo.Abp.Modularity;

namespace DedsiServiceC;

[DependsOn(
    // DedsiServiceC
    typeof(DedsiServiceCDomainModule),
    typeof(DedsiServiceCSharedModule),
    typeof(DedsiServiceCInfrastructureModule)
)]
public class DedsiServiceCUseCaseModule : AbpModule;