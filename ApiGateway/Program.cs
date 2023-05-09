using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//app.MapGet("/", () => "Hello World!");

//OCELOT SETTING
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration);

//OCELOT SETTING

var app = builder.Build();
await app.UseOcelot();
app.Run();
