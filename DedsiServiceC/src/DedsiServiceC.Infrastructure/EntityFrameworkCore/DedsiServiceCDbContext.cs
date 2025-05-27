using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DedsiServiceC.Users;
using Volo.Abp.Data;

namespace DedsiServiceC.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceCDomainConsts.ConnectionStringName)]
public class DedsiServiceCDbContext(DbContextOptions<DedsiServiceCDbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceCDbContext>(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}