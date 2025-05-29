using Volo.Abp.Modularity;

namespace DedsiLogs;

[DependsOn(
    // DedsiLogs
    typeof(DedsiLogsDomainModule),
    typeof(DedsiLogsSharedModule),
    typeof(DedsiLogsInfrastructureModule)
)]
public class DedsiLogsUseCaseModule : AbpModule;