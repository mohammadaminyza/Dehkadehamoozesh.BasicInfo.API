using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Entities;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;
using M.YZ.Basement.Infra.Data.Sql.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.WalletTransactionDetails;

public class WalletTransactionDetailCommandRepository : BaseCommandRepository<WalletTransactionDetail, BasicInfoCommandDbContext>, IWalletTransactionDetailCommandRepository
{
    public WalletTransactionDetailCommandRepository(BasicInfoCommandDbContext dbContext) : base(dbContext)
    {
    }
}