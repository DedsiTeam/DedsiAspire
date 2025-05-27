using Microsoft.EntityFrameworkCore;
using DedsiServiceB.Users;
using Volo.Abp;

namespace DedsiServiceB.EntityFrameworkCore;

public static class DedsiServiceBDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<User>(b =>
        {
            b.ToTable("Users", DedsiServiceBDomainConsts.DbSchemaName);
            b.HasKey(a => a.Id);
        });
    }
}