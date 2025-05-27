using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace DedsiServiceB.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceBDomainConsts.ConnectionStringName)]
public class DedsiServiceBDbContext(DbContextOptions<DedsiServiceBDbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceBDbContext>(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}