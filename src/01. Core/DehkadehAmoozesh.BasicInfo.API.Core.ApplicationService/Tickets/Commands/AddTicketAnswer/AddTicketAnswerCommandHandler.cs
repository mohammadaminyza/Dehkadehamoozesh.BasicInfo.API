using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.AddTicketAnswer;

public class AddTicketAnswerCommandHandler : CommandHandler<AddTicketAnswerCommand>
{
    private readonly ITicketCommandRepository _ticketCommandRepository;

    public AddTicketAnswerCommandHandler(BasementServices basementServices, ITicketCommandRepository ticketCommandRepository) : base(basementServices)
    {
        _ticketCommandRepository = ticketCommandRepository;
    }

    public override async Task<CommandResult> Handle(AddTicketAnswerCommand request)
    {
        var ticket = await _ticketCommandRepository.GetAsync(request.TicketId);

        ticket.AddTicketAnswer(new TicketAnswer(Guid.NewGuid(), request.UserId, request.TicketId, request.Text));
        await _ticketCommandRepository.CommitAsync();

        return await OkAsync();
    }
}