using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.Contracts;

public interface IFieldQueryRepository : IQueryRepository
{
    IEnumerable<FieldDto> Select(IFieldsDto fieldsDto);
}