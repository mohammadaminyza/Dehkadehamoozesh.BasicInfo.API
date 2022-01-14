using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.CreateTicket;

namespace DehkadehAmoozesh.BasicInfo.API.ApplicationServices.IntegrationTest.Tickets.Command.CreateTicket;

public class CreateTicketCommandHandler : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly ICommandDispatcher _commandDispatcher;

    public CreateTicketCommandHandler(CustomWebApplicationFactory<Program> factory)
    {
        _commandDispatcher = factory.Services.CreateScope().ServiceProvider.GetService<ICommandDispatcher>();
    }

    [Theory]
    [MemberData(nameof(GetCreateTicketCommand))]
    public async Task Handler(CreateTicketCommand createTicketCommand, ApplicationServiceStatus status)
    {
        //Arrange
        var commandResult = await _commandDispatcher.Send(createTicketCommand);

        ////Act
        var state = commandResult.Status;

        //Assert
        Assert.True(state == status);
    }

    public static IEnumerable<object[]> GetCreateTicketCommand()
    {
        yield return new object[] {new CreateTicketCommand()
                {
                    Title = "",
                    Text = "",
                    UserId = Guid.NewGuid(),
                },ApplicationServiceStatus.ValidationError };

        yield return new object[] { new CreateTicketCommand()
                {
                    Title = "تیکت معتبر",
                    Text = "این تست یک تیکت معتبر است",
                    UserId = Guid.NewGuid(),
                },ApplicationServiceStatus.Ok };
    }
}