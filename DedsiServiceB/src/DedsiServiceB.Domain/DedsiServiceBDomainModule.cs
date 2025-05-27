using Dedsi.CleanArchitecture.Domain;
using Volo.Abp.Modularity;

namespace DedsiServiceB;

[DependsOn(
    typeof(DedsiCleanArchitectureDomainModule)    
)]
public class DedsiServiceBDomainModule : AbpModule;