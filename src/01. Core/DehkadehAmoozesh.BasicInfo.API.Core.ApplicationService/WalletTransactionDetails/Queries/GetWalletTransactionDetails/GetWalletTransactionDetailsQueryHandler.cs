using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetails;

public class GetWalletTransactionDetailsQueryHandler : QueryHandler<GetWalletTransactionDetailsQuery, PagedData<WalletTransactionDetailsDto>>
{
    private readonly IWalletTransactionDetailQueryRepository _transactionDetailQueryRepository;

    public GetWalletTransactionDetailsQueryHandler(BasementServices basementServices, IWalletTransactionDetailQueryRepository transactionDetailQueryRepository) : base(basementServices)
    {
        _transactionDetailQueryRepository = transactionDetailQueryRepository;
    }

    public override async Task<QueryResult<PagedData<WalletTransactionDetailsDto>>> Handle(GetWalletTransactionDetailsQuery request)
    {
        var res = _transactionDetailQueryRepository.Select(request);

        return await ResultAsync(res);
    }
}