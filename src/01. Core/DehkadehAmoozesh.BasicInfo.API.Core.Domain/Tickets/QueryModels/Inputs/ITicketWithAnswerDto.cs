namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Inputs;

public interface ITicketWithAnswerDto
{
    public Guid BusinessId { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
}