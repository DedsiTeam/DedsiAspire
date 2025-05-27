using Volo.Abp.Modularity;

namespace DedsiServiceA;

[DependsOn(
    // DedsiServiceA
    typeof(DedsiServiceADomainModule),
    typeof(DedsiServiceASharedModule),
    typeof(DedsiServiceAInfrastructureModule)
)]
public class DedsiServiceAUseCaseModule : AbpModule;