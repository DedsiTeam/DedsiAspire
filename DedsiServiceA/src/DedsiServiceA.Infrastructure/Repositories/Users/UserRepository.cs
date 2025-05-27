using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using DedsiServiceA.EntityFrameworkCore;
using DedsiServiceA.Users;
using Volo.Abp.EntityFrameworkCore;

namespace DedsiServiceA.Repositories.Users;

public interface IUserRepository : IDedsiCqrsRepository<User, Guid>;

public class UserRepository(IDbContextProvider<DedsiServiceADbContext> dbContextProvider)
    : DedsiCqrsEfCoreRepository<DedsiServiceADbContext, User, Guid>(dbContextProvider),
        IUserRepository;