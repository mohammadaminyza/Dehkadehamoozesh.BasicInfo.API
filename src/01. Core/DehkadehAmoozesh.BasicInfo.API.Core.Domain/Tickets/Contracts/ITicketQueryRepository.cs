using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts
{
    public interface ITicketQueryRepository : IQueryRepository
    {
        PagedData<TicketDto> Select(ITicketsDto ticketsDto);
        TicketWithAnswersDto Select(ITicketWithAnswerDto ticketWithAnswerDto);
    }
}