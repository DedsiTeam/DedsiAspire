using Dedsi.Ddd.CQRS.Mediators;
using Microsoft.AspNetCore.Mvc;
using DedsiLogs.Users.CommandHandlers;
using DedsiLogs.Users.Dtos;
using DedsiLogs.Users.Queries;

namespace DedsiLogs.Users;

public class UserController(IUserQuery userQuery,IDedsiMediator dedsiMediator) : DedsiLogsController
{
    /// <summary>
    /// 创建用户
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<Guid> CreateAsync(CreateUserRequestDto input)
    {
        return dedsiMediator.SendAsync(new CreateUserCommand(input.UserName, input.Account, input.Email), HttpContext.RequestAborted);
    }
    
    /// <summary>
    /// 获取用户信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Task<UserInfoResponseDto> GetAsync(Guid id)
    {
        return userQuery.GetByidAsync(id, HttpContext.RequestAborted);
    }
}