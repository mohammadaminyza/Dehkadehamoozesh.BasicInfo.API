using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts
{
    public interface ITicketQueryRepository : IQueryRepository
    {
        PagedData<TicketDto> Select(ITicketsDto ticketsDto);
        TicketWithAnswersDto Select(ITicketWithAnswerDto ticketWithAnswerDto);
    }
}