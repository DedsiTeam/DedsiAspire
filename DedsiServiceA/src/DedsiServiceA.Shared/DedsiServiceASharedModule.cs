using Dedsi.Ddd.Application.Contracts;
using Dedsi.Ddd.CQRS;
using Dedsi.Ddd.Domain.Shared;
using Volo.Abp.Modularity;

namespace DedsiServiceA;

[DependsOn(
    typeof(DedsiDddApplicationContractsModule),
    typeof(DedsiDddDomainSharedModule),
    typeof(DedsiDddCqrsModule)
)]
public class DedsiServiceASharedModule: AbpModule;