using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.RemoveTicket;

public class RemoveTicketCommandHandler : CommandHandler<RemoveTicketCommand>
{
    private readonly ITicketCommandRepository _ticketCommandRepository;
    public RemoveTicketCommandHandler(BasementServices basementServices, ITicketCommandRepository ticketCommandRepository) : base(basementServices)
    {
        _ticketCommandRepository = ticketCommandRepository;
    }

    public override async Task<CommandResult> Handle(RemoveTicketCommand request)
    {
        var entity = await _ticketCommandRepository.GetAsync(request.BusinessId);

        _ticketCommandRepository.Delete(entity);
        await _ticketCommandRepository.CommitAsync();

        return await OkAsync();
    }
}
