var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.AspireApi>("demoapi");
var cache = builder.AddRedisContainer("rediscache");

builder.AddProject<Projects.AspireApp>("demoapp")
    .WithReference(api)
    .WithReference(cache);

builder.Build().Run();
