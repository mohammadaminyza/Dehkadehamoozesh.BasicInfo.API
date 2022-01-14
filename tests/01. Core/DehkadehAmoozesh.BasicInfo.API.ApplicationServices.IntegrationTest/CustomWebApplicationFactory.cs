using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts;
using M.YZ.Basement.Utilities.Configurations;

namespace DehkadehAmoozesh.BasicInfo.API.ApplicationServices.IntegrationTest;

public class CustomWebApplicationFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // Replace in-memory database for command testing
            var commandDescriptor = services.Single(
                d => d.ServiceType == typeof(DbContextOptions<BasicInfoCommandDbContext>));

            services.Remove(commandDescriptor);

            services.AddDbContext<BasicInfoCommandDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
            });

            // Replace in-memory database for query testing
            var queryDescriptor = services.Single(
               d => d.ServiceType == typeof(DbContextOptions<BasicInfoQueryDbContext>));

            services.Remove(queryDescriptor);

            services.AddDbContext<BasicInfoQueryDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
            });

            //Replace CommandHandler

            #region Repository

            var ticketCommandRepository = services.FirstOrDefault(d => d.ServiceType == typeof(ITicketCommandRepository));
            services.Remove(ticketCommandRepository);
            services.AddScoped<ITicketCommandRepository>(repository => new Mock<ITicketCommandRepository>().Object);

            #endregion
        });
    }
}