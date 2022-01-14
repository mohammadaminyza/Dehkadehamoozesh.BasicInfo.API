using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.QueryModels.Outputs;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetailById;

public class GetWalletTransactionDetailByIdQueryHandler : QueryHandler<GetWalletTransactionDetailByIdQuery, WalletTransactionDetailByIdDto>
{
    private readonly IWalletTransactionDetailQueryRepository _walletTransactionDetailQueryRepository;

    public GetWalletTransactionDetailByIdQueryHandler(BasementServices basementServices, IWalletTransactionDetailQueryRepository walletTransactionDetailQueryRepository) : base(basementServices)
    {
        _walletTransactionDetailQueryRepository = walletTransactionDetailQueryRepository;
    }

    public override async Task<QueryResult<WalletTransactionDetailByIdDto>> Handle(GetWalletTransactionDetailByIdQuery request)
    {
        return await ResultAsync(_walletTransactionDetailQueryRepository.Select(request));
    }
}