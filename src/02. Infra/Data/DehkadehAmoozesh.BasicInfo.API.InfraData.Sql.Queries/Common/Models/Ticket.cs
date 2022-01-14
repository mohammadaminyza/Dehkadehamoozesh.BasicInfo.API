namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;

public class Ticket
{
    public long Id { get; set; }

    public string Title { get; set; }
    public string Text { get; set; }
    public Guid UserId { get; set; }
    public int State { get; set; }

    public int? CreatedByUserId { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public int? ModifiedByUserId { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public Guid BusinessId { get; set; }

    public ICollection<TicketAnswer> TicketAnswers { get; set; }
}