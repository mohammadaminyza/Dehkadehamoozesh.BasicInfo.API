using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetails;

public class GetWalletTransactionDetailsQuery : PageQuery<PagedData<WalletTransactionDetailsDto>>, IWalletTransactionDetailsDto
{
    public Guid? UserId { get; set; }
    public string Description { get; set; }
    public int? TransactionTypeId { get; set; }
}