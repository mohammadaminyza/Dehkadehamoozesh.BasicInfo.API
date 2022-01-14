using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.AddTicketAnswer;

public class AddTicketAnswerValidator : AbstractValidator<AddTicketAnswerCommand>
{
    public AddTicketAnswerValidator(ITicketCommandRepository ticketCommandRepository, ITranslator translator)
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(p => p.TicketId)
            .Must(bid => ticketCommandRepository.Exists(p => p.BusinessId.Equals(bid))).WithMessage(translator[ResourceKeys.BusinessIdNotFound]);

        RuleFor(p => p.Text)
            .MinimumLength(2).WithMessage(translator[ResourceKeys.InvalidMinLength])
            .MaximumLength(255).WithMessage(translator[ResourceKeys.InvalidMaxLength]);

        RuleFor(p => p.UserId)
            .NotEmpty().WithMessage(translator[ResourceKeys.BusinessIdNotFound]);
    }
}