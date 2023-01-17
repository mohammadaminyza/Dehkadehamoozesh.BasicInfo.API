using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;

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