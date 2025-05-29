using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using DedsiLogs.EntityFrameworkCore;
using DedsiLogs.Users;
using Volo.Abp.EntityFrameworkCore;

namespace DedsiLogs.Repositories.Users;

public interface IUserRepository : IDedsiCqrsRepository<User, Guid>;

public class UserRepository(IDbContextProvider<DedsiLogsDbContext> dbContextProvider)
    : DedsiCqrsEfCoreRepository<DedsiLogsDbContext, User, Guid>(dbContextProvider),
        IUserRepository;