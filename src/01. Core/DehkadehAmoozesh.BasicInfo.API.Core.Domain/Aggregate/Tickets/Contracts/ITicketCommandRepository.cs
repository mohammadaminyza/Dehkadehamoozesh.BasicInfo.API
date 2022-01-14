using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Entities;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Contracts;

public interface ITicketCommandRepository : ICommandRepository<Ticket>
{
}