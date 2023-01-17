using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;
using M.YZ.Basement.Infra.Tools.OM.AutoMapper.MapperProfiles;

namespace Dehkadehamoozesh.BasicInfo.API.Infra.Tools.AutoMapper.MapperProfiles;

public class TicketProfile : SharedProfile
{
    public TicketProfile()
    {
        CreateMap<Ticket, TicketDto>()
            .ForMember(t => t.CreatedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.CreatedByUserId.ToString()))
            .ForMember(t => t.ModifiedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.ModifiedByUserId.ToString()));

        CreateMap<TicketAnswer, TicketAnswerDto>()
            .ForMember(t => t.CreatedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.CreatedByUserId.ToString()))
            .ForMember(t => t.ModifiedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.ModifiedByUserId.ToString()));

        CreateMap<Ticket, TicketWithAnswersDto>()
            .ForMember(t => t.CreatedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.CreatedByUserId.ToString()))
            .ForMember(t => t.ModifiedByUser,
                tm =>
                    tm.MapFrom(ticket => ticket.ModifiedByUserId.ToString()))
            .ForMember(t => t.TicketAnswers,
                tm =>
                    tm.MapFrom(t => t.TicketAnswers.ToList()));
    }
}