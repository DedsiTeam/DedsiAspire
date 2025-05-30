using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DedsiLogs.EntityFrameworkCore;

public static class DedsiLogsDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}