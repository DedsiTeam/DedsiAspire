var builder = DistributedApplication.CreateBuilder(args);

var DedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");


var DedsiIdentity = builder
    .AddProject<Projects.DedsiIdentity_Host>("DedsiIdentity")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);

var DedsiLog = builder
    .AddProject<Projects.DedsiLogs_Host>("DedsiLogs")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);

var PublicApiGateway = builder.AddProject<Projects.PublicApiGateway>("PublicApiGateway")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter)
    .WithReference(DedsiIdentity)
    .WaitFor(DedsiIdentity)
    .WithReference(DedsiLog)
    .WaitFor(DedsiLog);

builder.Build().Run();
