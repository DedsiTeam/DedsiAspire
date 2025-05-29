using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DedsiLogs.Users;
using Volo.Abp.Data;

namespace DedsiLogs.EntityFrameworkCore;

[ConnectionStringName(DedsiLogsDomainConsts.ConnectionStringName)]
public class DedsiLogsDbContext(DbContextOptions<DedsiLogsDbContext> options) 
    : DedsiEfCoreDbContext<DedsiLogsDbContext>(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}