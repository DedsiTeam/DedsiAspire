using Microsoft.EntityFrameworkCore;
using DedsiLogs.Users;
using Volo.Abp;

namespace DedsiLogs.EntityFrameworkCore;

public static class DedsiLogsDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<User>(b =>
        {
            b.ToTable("Users", DedsiLogsDomainConsts.DbSchemaName);
            b.HasKey(a => a.Id);
        });
    }
}