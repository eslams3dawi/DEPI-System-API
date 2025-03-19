var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DEPI_DAS>("depi-das");

builder.Build().Run();
