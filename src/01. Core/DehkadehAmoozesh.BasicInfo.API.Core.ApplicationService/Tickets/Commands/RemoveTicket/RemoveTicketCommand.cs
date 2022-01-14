using M.YZ.Basement.Core.ApplicationServices.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.RemoveTicket;

public class RemoveTicketCommand : ICommand
{
    public Guid BusinessId { get; set; }
}