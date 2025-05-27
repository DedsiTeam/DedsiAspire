using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DedsiServiceA.Users;
using Volo.Abp.Data;

namespace DedsiServiceA.EntityFrameworkCore;

[ConnectionStringName(DedsiServiceADomainConsts.ConnectionStringName)]
public class DedsiServiceADbContext(DbContextOptions<DedsiServiceADbContext> options) 
    : DedsiEfCoreDbContext<DedsiServiceADbContext>(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}