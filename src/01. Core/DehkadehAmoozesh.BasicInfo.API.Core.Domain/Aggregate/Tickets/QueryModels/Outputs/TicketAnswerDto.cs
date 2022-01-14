namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.QueryModels.Outputs;

public class TicketAnswerDto
{
    public Guid BusinessId { get; set; }
    public string Text { get; set; }
    public Guid TicketId { get; set; }
    public Guid UserId { get; set; }

    public string CreatedByUser { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string ModifiedByUser { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}