var builder = DistributedApplication.CreateBuilder(args);

var dedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");

var dedsiServiceA = builder
    .AddProject<Projects.DedsiServiceA_Host>("DedsiServiceA")
    .WithExternalHttpEndpoints()
    .WithReference(dedsiAuthCenter)
    .WaitFor(dedsiAuthCenter);

var dedsiServiceB = builder
    .AddProject<Projects.DedsiServiceB_Host>("DedsiServiceB")
    .WithExternalHttpEndpoints()
    .WithReference(dedsiServiceA)
    .WaitFor(dedsiServiceA)
    .WithReference(dedsiAuthCenter)
    .WaitFor(dedsiAuthCenter);

var dedsiServiceC = builder
    .AddProject<Projects.DedsiServiceC_Host>("DedsiServiceC")
    .WithExternalHttpEndpoints()
    .WithReference(dedsiAuthCenter)
    .WaitFor(dedsiAuthCenter);




builder.Build().Run();
