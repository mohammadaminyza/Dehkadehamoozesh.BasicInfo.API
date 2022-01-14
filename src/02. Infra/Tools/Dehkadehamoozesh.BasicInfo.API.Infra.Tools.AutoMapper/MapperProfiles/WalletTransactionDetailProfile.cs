using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Outputs;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;
using M.YZ.Basement.Infra.Tools.OM.AutoMapper.MapperProfiles;

namespace Dehkadehamoozesh.BasicInfo.API.Infra.Tools.AutoMapper.MapperProfiles;

public class WalletTransactionDetailProfile : SharedProfile
{
    public WalletTransactionDetailProfile()
    {
        CreateMap<WalletTransactionDetail, WalletTransactionDetailsDto>();
        CreateMap<WalletTransactionDetail, WalletTransactionDetailByIdDto>();
    }
}