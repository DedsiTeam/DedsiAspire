namespace DedsiAuthCenter.Host.Apis;

public static class AuthApis
{
    public static RouteGroupBuilder MapAuthApis(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("api/auth");

        return api;
    }
}
