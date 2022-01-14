namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.AddTicketAnswer;

public class AddTicketAnswerCommand : ICommand
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
    public string Text { get; set; }
}