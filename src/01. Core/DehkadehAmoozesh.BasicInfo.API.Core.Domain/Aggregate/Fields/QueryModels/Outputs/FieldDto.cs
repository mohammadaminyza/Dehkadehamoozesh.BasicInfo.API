namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.QueryModels.Outputs;

public class FieldDto
{
    public string Name { get; set; }

    public string CreatedByUser { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string ModifiedByUser { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public Guid BusinessId { get; set; }
}