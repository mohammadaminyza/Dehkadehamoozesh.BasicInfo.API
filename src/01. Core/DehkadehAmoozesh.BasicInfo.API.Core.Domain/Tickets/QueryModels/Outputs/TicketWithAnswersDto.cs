using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Enums;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.QueryModels.Outputs;

public class TicketWithAnswersDto
{
    public Guid BusinessId { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public Guid UserId { get; set; }
    public TicketState State { get; set; }
    public List<TicketAnswerDto> TicketAnswers { get; set; }

    public string CreatedByUser { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string ModifiedByUser { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}
