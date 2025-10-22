var builder = DistributedApplication.CreateBuilder(args);

var webApp = builder.AddProject<Projects.PFMT_Server>("pfmt-server");
var mysql = builder.AddMySql("myDatabase").WithLifetime(ContainerLifetime.Persistent); ;

// This is the magic line that links the DB to the app
webApp.WithReference(mysql);

builder.Build().Run();
