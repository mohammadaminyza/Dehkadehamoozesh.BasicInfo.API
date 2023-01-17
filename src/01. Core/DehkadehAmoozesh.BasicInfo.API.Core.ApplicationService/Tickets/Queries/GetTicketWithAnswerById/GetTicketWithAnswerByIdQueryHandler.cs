using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTicketWithAnswerById;

public class GetTicketWithAnswerByIdQueryHandler : QueryHandler<GetTicketWithAnswerByIdQuery, TicketWithAnswersDto>
{
    private readonly ITicketQueryRepository _ticketQueryRepository;

    public GetTicketWithAnswerByIdQueryHandler(BasementServices basementServices, ITicketQueryRepository ticketQueryRepository) : base(basementServices)
    {
        _ticketQueryRepository = ticketQueryRepository;
    }

    public override async Task<QueryResult<TicketWithAnswersDto>> Handle(GetTicketWithAnswerByIdQuery request)
    {
        var res = _ticketQueryRepository.Select(request);
        return await ResultAsync(res);
    }
}