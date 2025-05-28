var builder = DistributedApplication.CreateBuilder(args);

var MessagingRabbitMQ = builder.AddRabbitMQ("MessagingRabbitMQ")
    .WithManagementPlugin();

var DedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");

var DedsiServiceA = builder
    .AddProject<Projects.DedsiServiceA_Host>("DedsiServiceA")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter)
    .WithReference(MessagingRabbitMQ);

var DedsiServiceB = builder
    .AddProject<Projects.DedsiServiceB_Host>("DedsiServiceB")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiServiceA)
    .WaitFor(DedsiServiceA)
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);

var DedsiServiceC = builder
    .AddProject<Projects.DedsiServiceC_Host>("DedsiServiceC")
    .WithExternalHttpEndpoints()
    .WithReference(DedsiAuthCenter)
    .WaitFor(DedsiAuthCenter);




builder.Build().Run();
