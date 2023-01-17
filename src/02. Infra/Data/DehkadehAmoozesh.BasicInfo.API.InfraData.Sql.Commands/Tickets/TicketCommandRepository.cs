using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;
using M.YZ.Basement.Infra.Data.Sql.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Tickets;

public class TicketCommandRepository : BaseCommandRepository<Ticket, BasicInfoCommandDbContext>, ITicketCommandRepository
{
    public TicketCommandRepository(BasicInfoCommandDbContext dbContext) : base(dbContext)
    {
    }
}