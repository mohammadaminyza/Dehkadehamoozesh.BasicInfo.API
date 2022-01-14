using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.RemoveTicket;

public class RemoveTicketValidator : AbstractValidator<RemoveTicketCommand>
{
    public RemoveTicketValidator(ITranslator translator, ITicketCommandRepository ticketCommandRepository)
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(p => p.BusinessId)
            .Must(bid => ticketCommandRepository.Exists(p => p.BusinessId.Equals(bid)))
            .WithMessage(translator[ResourceKeys.BusinessIdNotFound]);
    }
}