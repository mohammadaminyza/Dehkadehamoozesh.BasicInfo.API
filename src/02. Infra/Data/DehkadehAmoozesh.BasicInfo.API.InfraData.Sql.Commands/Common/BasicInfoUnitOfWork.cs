using DehkadehAmoozesh.BasicInfo.API.Core.Domain;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using M.YZ.Basement.Infra.Data.Sql.Commands;
using M.YZ.Basement.Utilities;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;

public class BasicInfoUnitOfWork : BaseEntityFrameworkUnitOfWork<BasicInfoCommandDbContext>, IBasicInfoUnitOfWork
{
    public BasicInfoUnitOfWork(BasicInfoCommandDbContext dbContext, BasementServices basementServices) : base(dbContext, basementServices)
    {
    }
}