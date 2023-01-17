using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.CreateTicket;

public class CreateTicketValidator : AbstractValidator<CreateTicketCommand>
{
    public CreateTicketValidator(ITicketCommandRepository ticketCommandRepository, ITranslator translator)
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(p => p.UserId)
            .NotEmpty().WithMessage(translator[ResourceKeys.BusinessIdNotFound]);

        RuleFor(p => p.Title)
            .MinimumLength(2).WithMessage(translator[ResourceKeys.InvalidMinLength])
            .MaximumLength(40).WithMessage(translator[ResourceKeys.InvalidMaxLength]);

        RuleFor(p => p.Text)
            .MinimumLength(2).WithMessage(translator[ResourceKeys.InvalidMinLength])
            .MaximumLength(255).WithMessage(translator[ResourceKeys.InvalidMaxLength]);
    }
}
