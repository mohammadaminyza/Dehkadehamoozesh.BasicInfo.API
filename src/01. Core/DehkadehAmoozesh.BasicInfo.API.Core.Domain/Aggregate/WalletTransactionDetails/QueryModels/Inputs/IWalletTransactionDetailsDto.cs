using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Inputs;

public interface IWalletTransactionDetailsDto : IPageQuery<PagedData<WalletTransactionDetailsDto>>
{
    public Guid? UserId { get; set; }
    public string Description { get; set; }
    public int? TransactionTypeId { get; set; }
}