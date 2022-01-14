namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;

public class Field
{
    public long Id { get; set; }

    public string Name { get; set; }

    public int? CreatedByUserId { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public int? ModifiedByUserId { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public Guid BusinessId { get; set; }
}