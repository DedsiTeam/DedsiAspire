var builder = DistributedApplication.CreateBuilder(args);

var DedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");


var DedsiIdentity = builder
    .AddProject<Projects.DedsiIdentity_Host>("DedsiIdentity")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);

var DedsiLog = builder
    .AddProject<Projects.DedsiLogs_Host>("DedsiLog")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);

var PublicApiGateway = builder
    .AddProject<Projects.PublicApiGateway>("PublicApiGateway")
    .WithReference(DedsiAuthCenter)
    .WithReference(DedsiIdentity)
    .WithReference(DedsiLog);

builder.Build().Run();
