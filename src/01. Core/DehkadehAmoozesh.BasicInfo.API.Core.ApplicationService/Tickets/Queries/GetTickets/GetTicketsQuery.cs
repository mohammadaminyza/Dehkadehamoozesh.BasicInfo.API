using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTickets;

public class GetTicketsQuery : PageQuery<PagedData<TicketDto>>, ITicketsDto
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}