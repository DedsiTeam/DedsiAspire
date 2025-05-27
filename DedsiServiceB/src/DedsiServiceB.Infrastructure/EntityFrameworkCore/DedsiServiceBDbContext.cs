using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DedsiServiceB.Users;
using Volo.Abp.Data;

namespace DedsiServiceB.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceBDomainConsts.ConnectionStringName)]
public class DedsiServiceBDbContext(DbContextOptions<DedsiServiceBDbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceBDbContext>(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}