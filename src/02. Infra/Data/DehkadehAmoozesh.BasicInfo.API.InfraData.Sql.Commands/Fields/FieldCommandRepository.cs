using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.Entities;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;
using M.YZ.Basement.Infra.Data.Sql.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Fields;

public class FieldCommandRepository : BaseCommandRepository<Field, BasicInfoCommandDbContext>, IFieldCommandRepository
{
    public FieldCommandRepository(BasicInfoCommandDbContext dbContext) : base(dbContext)
    {
    }
}