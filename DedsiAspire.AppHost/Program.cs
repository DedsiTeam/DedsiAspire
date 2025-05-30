var builder = DistributedApplication.CreateBuilder(args);

var DedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");


var DedsiIdentity = builder
    .AddProject<Projects.DedsiIdentity_Host>("DedsiIdentity")
    .WithExternalHttpEndpoints();

var DedsiLog = builder
    .AddProject<Projects.DedsiLogs_Host>("DedsiLog")
    .WithExternalHttpEndpoints();

var PublicApiGateway = builder
    .AddProject<Projects.PublicApiGateway>("PublicApiGateway")
    .WithReference(DedsiAuthCenter)
    .WithReference(DedsiIdentity)
    .WithReference(DedsiLog);

DedsiIdentity.WithReference(PublicApiGateway);
DedsiLog.WithReference(PublicApiGateway);

builder.Build().Run();
