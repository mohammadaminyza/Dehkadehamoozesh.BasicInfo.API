using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetailById;

public class GetWalletTransactionDetailByIdQuery : IQuery<WalletTransactionDetailByIdDto>, IWalletTransactionDetailByIdDto
{
    public Guid BusinessId { get; set; }
}