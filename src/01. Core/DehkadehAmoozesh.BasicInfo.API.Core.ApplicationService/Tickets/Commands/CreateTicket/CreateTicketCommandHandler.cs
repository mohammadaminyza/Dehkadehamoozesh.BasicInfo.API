using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Entities;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Enums;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.CreateTicket;

public class CreateTicketCommandHandler : CommandHandler<CreateTicketCommand>
{
    private readonly ITicketCommandRepository _ticketCommandRepository;

    public CreateTicketCommandHandler(BasementServices basementServices, ITicketCommandRepository ticketCommandRepository) : base(basementServices)
    {
        _ticketCommandRepository = ticketCommandRepository;
    }

    public override async Task<CommandResult> Handle(CreateTicketCommand request)
    {
        var entity = new Ticket(Guid.NewGuid(), request.UserId, request.Title, request.Text, TicketState.WaitForAnswer);

        await _ticketCommandRepository.InsertAsync(entity);
        await _ticketCommandRepository.CommitAsync();

        return await OkAsync();
    }
}