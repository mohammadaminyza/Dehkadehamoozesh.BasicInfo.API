using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.Contracts;

public interface IFieldQueryRepository : IQueryRepository
{
    IEnumerable<FieldDto> Select(IFieldsDto fieldsDto);
}