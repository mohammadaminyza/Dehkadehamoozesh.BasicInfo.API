using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Fields.Queries.GetFields;

public class GetFieldsQuery : IQuery<IEnumerable<FieldDto>>, IFieldsDto
{
    public string Name { get; set; }
}