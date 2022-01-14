using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Outputs;
using M.YZ.Basement.Core.ApplicationServices.Queries;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetailById;

public class GetWalletTransactionDetailByIdQuery : IQuery<WalletTransactionDetailByIdDto>, IWalletTransactionDetailByIdDto
{
    public Guid BusinessId { get; set; }
}