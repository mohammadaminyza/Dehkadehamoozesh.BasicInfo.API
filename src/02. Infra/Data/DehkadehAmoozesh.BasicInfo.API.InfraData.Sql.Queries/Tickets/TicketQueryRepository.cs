using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;
using M.YZ.Basement.Utilities.Services.ObjectMappers;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Tickets;

public class TicketQueryRepository : BaseQueryRepository<BasicInfoQueryDbContext>, ITicketQueryRepository
{
    private readonly IMapperAdapter _mapper;

    public TicketQueryRepository(BasicInfoQueryDbContext dbContext, IMapperAdapter mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    public PagedData<TicketDto> Select(ITicketsDto ticketsDto)
    {
        #region Query

        var query = _dbContext.Tickets.AsQueryable();

        #endregion

        #region Result

        var result = _mapper.MapTo<Ticket, TicketDto>(query).PagingResult(ticketsDto);

        #endregion

        return result;
    }

    public TicketWithAnswersDto Select(ITicketWithAnswerDto ticketWithAnswerDto)
    {
        #region Query

        var query = _dbContext.Tickets.AsQueryable();

        #endregion

        #region Filter

        query = query.Where(p => p.BusinessId.Equals(ticketWithAnswerDto.BusinessId));

        if (ticketWithAnswerDto.UserId != Guid.Empty && !ticketWithAnswerDto.UserId.IsNullOrEmpty())
            query = query.Where(p => p.UserId.Equals(ticketWithAnswerDto.UserId));

        if (!ticketWithAnswerDto.Title.IsNullOrEmpty())
            query = query.Where(p => p.Title.Equals(ticketWithAnswerDto.Title));

        #endregion

        #region Result

        var result = _mapper.MapTo<Ticket, TicketWithAnswersDto>(query).SingleOrDefault();

        #endregion

        return result;
    }
}