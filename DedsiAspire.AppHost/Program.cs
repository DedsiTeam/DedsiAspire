var builder = DistributedApplication.CreateBuilder(args);

var MessagingRabbitMQ = builder.AddRabbitMQ("MessagingRabbitMQ")
    .WithManagementPlugin();

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

builder.Build().Run();
