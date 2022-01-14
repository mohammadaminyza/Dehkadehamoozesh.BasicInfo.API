namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;

public class TicketAnswer
{
    public long Id { get; set; }

    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
    public string Text { get; set; }


    public int? CreatedByUserId { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public int? ModifiedByUserId { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public Guid BusinessId { get; set; }

    public Ticket Ticket { get; set; }
}