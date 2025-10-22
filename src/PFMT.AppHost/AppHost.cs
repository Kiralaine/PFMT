var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PFMT_Server>("pfmt-server");

builder.Build().Run();
