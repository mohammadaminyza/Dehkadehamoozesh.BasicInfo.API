using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = new BasementProgram().Main(args, "appsettings.json", "appsettings.Basement.json", "appsettings.serilog.json");

var services = builder.Services;

//Configuration
ConfigurationManager Configuration = builder.Configuration;

services.AddBasementApiServices(Configuration);

// Add services to the container.

services.AddDbContext<BasicInfoCommandDbContext>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("DA_BasicInfo_ConnectionString"));
});

services.AddDbContext<BasicInfoQueryDbContext>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("DA_BasicInfo_ConnectionString"));
});

//Middlewares
var app = builder.Build();
var basementOptions = app.Services.GetService<BasementConfigurationOptions>();

app.UseBasementApiConfigure(basementOptions, app.Environment);

app.Run();


public partial class Program { }