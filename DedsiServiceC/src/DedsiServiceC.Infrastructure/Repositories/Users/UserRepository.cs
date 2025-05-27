using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using DedsiServiceC.EntityFrameworkCore;
using DedsiServiceC.Users;
using Volo.Abp.EntityFrameworkCore;

namespace DedsiServiceC.Repositories.Users;

public interface IUserRepository : IDedsiCqrsRepository<User, Guid>;

public class UserRepository(IDbContextProvider<DedsiServiceCDbContext> dbContextProvider)
    : DedsiCqrsEfCoreRepository<DedsiServiceCDbContext, User, Guid>(dbContextProvider),
        IUserRepository;