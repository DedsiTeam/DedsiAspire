using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DedsiServiceB.EntityFrameworkCore;

public static class DedsiServiceBDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}