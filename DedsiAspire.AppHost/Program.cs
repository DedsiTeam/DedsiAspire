var builder = DistributedApplication.CreateBuilder(args);

var dedsiServiceA = builder.AddProject<Projects.DedsiServiceA_Host>("DedsiServiceA");

var dedsiServiceB = builder
    .AddProject<Projects.DedsiServiceB_Host>("DedsiServiceB")
    .WithExternalHttpEndpoints()
    .WithReference(dedsiServiceA)
    .WaitFor(dedsiServiceA);

var dedsiServiceC = builder.AddProject<Projects.DedsiServiceC_Host>("DedsiServiceC");


var dedsiAuthCenter = builder.AddProject<Projects.DedsiAuthCenter_Host>("DedsiAuthCenter");


builder.Build().Run();
