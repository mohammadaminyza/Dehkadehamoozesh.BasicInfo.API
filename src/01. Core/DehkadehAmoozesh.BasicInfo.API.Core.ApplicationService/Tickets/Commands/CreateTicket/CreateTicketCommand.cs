namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.CreateTicket;

public class CreateTicketCommand : ICommand
{
    public string Title { get; set; }
    public string Text { get; set; }
    public Guid UserId { get; set; }
}
