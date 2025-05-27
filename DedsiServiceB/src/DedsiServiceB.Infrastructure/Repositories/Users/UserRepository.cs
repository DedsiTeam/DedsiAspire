using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using DedsiServiceB.EntityFrameworkCore;
using DedsiServiceB.Users;
using Volo.Abp.EntityFrameworkCore;

namespace DedsiServiceB.Repositories.Users;

public interface IUserRepository : IDedsiCqrsRepository<User, Guid>;

public class UserRepository(IDbContextProvider<DedsiServiceBDbContext> dbContextProvider)
    : DedsiCqrsEfCoreRepository<DedsiServiceBDbContext, User, Guid>(dbContextProvider),
        IUserRepository;