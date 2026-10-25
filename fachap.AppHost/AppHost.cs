var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.fachap>("fachap");

builder.Build().Run();
