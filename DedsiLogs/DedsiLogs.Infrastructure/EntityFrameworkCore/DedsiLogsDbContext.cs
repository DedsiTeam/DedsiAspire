using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace DedsiLogs.EntityFrameworkCore;

[ConnectionStringName(DedsiLogsDomainConsts.ConnectionStringName)]
public class DedsiLogsDbContext(DbContextOptions<DedsiLogsDbContext> options) 
    : DedsiEfCoreDbContext<DedsiLogsDbContext>(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}