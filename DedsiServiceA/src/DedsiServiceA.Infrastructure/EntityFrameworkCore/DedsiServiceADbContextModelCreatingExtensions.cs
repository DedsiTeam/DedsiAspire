using Microsoft.EntityFrameworkCore;
using DedsiServiceA.Users;
using Volo.Abp;

namespace DedsiServiceA.EntityFrameworkCore;

public static class DedsiServiceADbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<User>(b =>
        {
            b.ToTable("Users", DedsiServiceADomainConsts.DbSchemaName);
            b.HasKey(a => a.Id);
        });
    }
}