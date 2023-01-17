using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.Fields.Queries.GetFields;

public class GetFieldsQueryHandler : QueryHandler<GetFieldsQuery, IEnumerable<FieldDto>>
{
    private readonly IFieldQueryRepository _fieldQueryRepository;

    public GetFieldsQueryHandler(BasementServices basementServices, IFieldQueryRepository fieldQueryRepository) : base(basementServices)
    {
        _fieldQueryRepository = fieldQueryRepository;
    }

    public override async Task<QueryResult<IEnumerable<FieldDto>>> Handle(GetFieldsQuery request)
    {
        return await ResultAsync(_fieldQueryRepository.Select(request));
    }
}