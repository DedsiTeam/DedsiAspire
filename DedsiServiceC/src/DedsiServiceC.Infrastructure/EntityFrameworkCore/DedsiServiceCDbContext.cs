using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace DedsiServiceC.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceCDomainConsts.ConnectionStringName)]
public class DedsiServiceCDbContext(DbContextOptions<DedsiServiceCDbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceCDbContext>(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}