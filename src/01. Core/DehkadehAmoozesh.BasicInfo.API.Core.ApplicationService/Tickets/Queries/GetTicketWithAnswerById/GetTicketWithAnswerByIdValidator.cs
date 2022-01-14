using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTicketWithAnswerById;

public class GetTicketWithAnswerByIdValidator : AbstractValidator<GetTicketWithAnswerByIdQuery>
{
    public GetTicketWithAnswerByIdValidator(ITranslator translator, ITicketCommandRepository ticketCommandRepository)
    {
        RuleFor(p => p.BusinessId)
            .NotEmpty().WithMessage(translator[ResourceKeys.BusinessIdRequiredError])
            .Must(bid => ticketCommandRepository.Exists(p => p.BusinessId.Equals(bid)))
            .WithMessage(translator[ResourceKeys.BusinessIdNotFound]);
    }
}