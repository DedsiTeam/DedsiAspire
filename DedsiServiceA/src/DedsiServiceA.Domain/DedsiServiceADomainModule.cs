using Dedsi.CleanArchitecture.Domain;
using Volo.Abp.Modularity;

namespace DedsiServiceA;

[DependsOn(
    typeof(DedsiCleanArchitectureDomainModule)    
)]
public class DedsiServiceADomainModule : AbpModule;