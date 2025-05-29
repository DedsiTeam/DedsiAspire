using FastEndpoints;

namespace DedsiIdentity.Host.Endpoints.Users;

public record UserCreateRequest(string Name, string Email, string Password);

public record UserCreateResponse(Guid Id);


public class UserCreateEndpoint : Endpoint<UserCreateRequest, UserCreateResponse>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UserCreateRequest request, CancellationToken ct)
    {
        await SendAsync(new UserCreateResponse(Guid.NewGuid()));
    }
}
