using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTicketWithAnswerById;

public class GetTicketWithAnswerByIdQuery : IQuery<TicketWithAnswersDto>, ITicketWithAnswerDto
{
    public Guid BusinessId { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
}