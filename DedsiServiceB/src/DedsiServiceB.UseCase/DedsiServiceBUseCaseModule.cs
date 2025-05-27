using Volo.Abp.Modularity;

namespace DedsiServiceB;

[DependsOn(
    // DedsiServiceB
    typeof(DedsiServiceBDomainModule),
    typeof(DedsiServiceBSharedModule),
    typeof(DedsiServiceBInfrastructureModule)
)]
public class DedsiServiceBUseCaseModule : AbpModule;