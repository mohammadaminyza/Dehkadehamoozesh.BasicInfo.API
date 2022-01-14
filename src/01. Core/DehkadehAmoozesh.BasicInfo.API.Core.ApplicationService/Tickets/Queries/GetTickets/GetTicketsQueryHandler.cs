using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTickets;

public class GetTicketsQueryHandler : QueryHandler<GetTicketsQuery, PagedData<TicketDto>>
{
    private readonly ITicketQueryRepository _ticketQueryRepository;

    public GetTicketsQueryHandler(BasementServices basementServices, ITicketQueryRepository ticketQueryRepository) : base(basementServices)
    {
        _ticketQueryRepository = ticketQueryRepository;
    }

    public override async Task<QueryResult<PagedData<TicketDto>>> Handle(GetTicketsQuery request)
    {
        var res = _ticketQueryRepository.Select(request);

        return await ResultAsync(res);
    }
}