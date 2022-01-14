using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.AddTicketAnswer;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.CreateTicket;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Commands.RemoveTicket;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTickets;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Tickets.Queries.GetTicketWithAnswerById;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.QueryModels.Outputs;
using Microsoft.AspNetCore.Mvc;
using M.YZ.Basement.EndPoints.Web.Controllers;

namespace DehkadehAmoozesh.BasicInfo.API.EndpointAPI.Controllers.Tickets;

[Route("api/[controller]")]
[ApiController]
public class TicketsController : BaseController
{
    #region Query

    [HttpGet("get")]
    public async Task<IActionResult> GetTickets([FromQuery] GetTicketsQuery getTicketsQuery)
    {
        return await Query<GetTicketsQuery, PagedData<TicketDto>>(getTicketsQuery);
    }

    [HttpGet("getTicketWithAnswer")]
    public async Task<IActionResult> GetTicketWithAnswerById([FromQuery] GetTicketWithAnswerByIdQuery getTicketWithAnswerQuery)
    {
        return await Query<GetTicketWithAnswerByIdQuery, TicketWithAnswersDto>(getTicketWithAnswerQuery);
    }

    #endregion

    #region Command

    [HttpPost("create")]
    public async Task<IActionResult> CreateTicket(CreateTicketCommand createTicketCommand)
    {
        return await Create(createTicketCommand);
    }

    [HttpPost("addTicketAnswer")]
    public async Task<IActionResult> AddTicketAnswer(AddTicketAnswerCommand addTicketAnswerCommand)
    {
        return await Create(addTicketAnswerCommand);
    }

    [HttpDelete("remove")]
    public async Task<IActionResult> RemoveTicket(RemoveTicketCommand removeTicketCommand)
    {
        return await Delete(removeTicketCommand);
    }

    #endregion
}