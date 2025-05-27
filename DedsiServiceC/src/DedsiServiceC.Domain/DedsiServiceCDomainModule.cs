using Dedsi.CleanArchitecture.Domain;
using Volo.Abp.Modularity;

namespace DedsiServiceC;

[DependsOn(
    typeof(DedsiCleanArchitectureDomainModule)    
)]
public class DedsiServiceCDomainModule : AbpModule;