using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Microsoft.EntityFrameworkCore;
using DedsiServiceA.EntityFrameworkCore;
using DedsiServiceA.Users.Dtos;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;

namespace DedsiServiceA.Users.Queries;

public interface IUserQuery : IDedsiQuery
{
    Task<UserInfoResponseDto> GetByidAsync(Guid id, CancellationToken cancellationToken);
}

public class UserQuery(IDbContextProvider<DedsiServiceADbContext> dbContextProvider)
    : DedsiEfCoreQuery<DedsiServiceADbContext>(dbContextProvider),
        IUserQuery
{
    public async Task<UserInfoResponseDto> GetByidAsync(Guid id, CancellationToken cancellationToken)
    {
        var userDbSet = await GetDbSetAsync<User>();
        
        var user = await userDbSet.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);

        if (user is null)
        {
            throw new UserFriendlyException("用户不存在！");
        }

        return new UserInfoResponseDto()
        {
            Id = user.Id,
            UserName = user.UserName,
            Account = user.Account,
            Email = user.Email
        };
    }
}