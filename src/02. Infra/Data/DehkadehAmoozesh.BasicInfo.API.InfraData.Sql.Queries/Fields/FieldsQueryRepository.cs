using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Fields.QueryModels.Outputs;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Fields;

public class FieldsQueryRepository : BaseQueryRepository<BasicInfoQueryDbContext>, IFieldQueryRepository
{
    public FieldsQueryRepository(BasicInfoQueryDbContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<FieldDto> Select(IFieldsDto fieldsDto)
    {

        #region Query

        var query = _dbContext.Fields.AsQueryable();

        #endregion

        #region Filter

        if (!fieldsDto.Name.IsNullOrEmpty())
            query = query.Where(p => p.Name.Equals(fieldsDto.Name));

        #endregion

        #region Result

        var result = query.Select(f => new FieldDto()
        {
            BusinessId = f.BusinessId,
            Name = f.Name,
            CreatedByUser = "",
            CreatedDateTime = f.CreatedDateTime,
            ModifiedByUser = "",
            ModifiedDateTime = f.ModifiedDateTime,
        }).ToList();

        #endregion

        return result;
    }
}