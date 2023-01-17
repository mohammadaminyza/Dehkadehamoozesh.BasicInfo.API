using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;

public interface ITicketsDto : IPageQuery<PagedData<TicketDto>>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}
