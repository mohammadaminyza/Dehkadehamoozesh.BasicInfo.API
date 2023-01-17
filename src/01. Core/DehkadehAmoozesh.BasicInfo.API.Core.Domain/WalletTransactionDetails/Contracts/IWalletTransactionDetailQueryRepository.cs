using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;

public interface IWalletTransactionDetailQueryRepository : IQueryRepository
{
    PagedData<WalletTransactionDetailsDto> Select(IWalletTransactionDetailsDto transactionDetailsDto);
    WalletTransactionDetailByIdDto Select(IWalletTransactionDetailByIdDto transactionDetailsDto);
}