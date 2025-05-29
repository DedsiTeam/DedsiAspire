using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints().SwaggerDocument();
builder.AddServiceDefaults();

var app = builder.Build();

app.UseFastEndpoints().UseSwaggerGen();
app.MapDefaultEndpoints();

app.Run();