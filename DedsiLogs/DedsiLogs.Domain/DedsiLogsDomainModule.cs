using Dedsi.CleanArchitecture.Domain;
using Volo.Abp.Modularity;

namespace DedsiLogs;

[DependsOn(
    typeof(DedsiCleanArchitectureDomainModule)    
)]
public class DedsiLogsDomainModule : AbpModule;