using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DedsiServiceC.EntityFrameworkCore;

public static class DedsiServiceCDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}