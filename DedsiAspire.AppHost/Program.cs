var builder = DistributedApplication.CreateBuilder(args);

var dedsiServiceA = builder.AddProject<Projects.DedsiServiceA_Host>("dedsiservicea-host");

var dedsiServiceB = builder.AddProject<Projects.DedsiServiceB_Host>("dedsiserviceb-host");

var dedsiServiceC = builder.AddProject<Projects.DedsiServiceC_Host>("dedsiservicec-host");


builder.Build().Run();
