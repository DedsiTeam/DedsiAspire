using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace DedsiServiceA.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceADomainConsts.ConnectionStringName)]
public class DedsiServiceADbContext(DbContextOptions<DedsiServiceADbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceADbContext>(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}