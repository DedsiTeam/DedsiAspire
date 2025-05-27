using Microsoft.EntityFrameworkCore;
using DedsiServiceC.Users;
using Volo.Abp;

namespace DedsiServiceC.EntityFrameworkCore;

public static class DedsiServiceCDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<User>(b =>
        {
            b.ToTable("Users", DedsiServiceCDomainConsts.DbSchemaName);
            b.HasKey(a => a.Id);
        });
    }
}