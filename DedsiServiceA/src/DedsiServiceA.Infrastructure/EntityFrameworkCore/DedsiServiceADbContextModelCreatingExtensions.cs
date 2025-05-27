using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DedsiServiceA.EntityFrameworkCore;

public static class DedsiServiceADbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}