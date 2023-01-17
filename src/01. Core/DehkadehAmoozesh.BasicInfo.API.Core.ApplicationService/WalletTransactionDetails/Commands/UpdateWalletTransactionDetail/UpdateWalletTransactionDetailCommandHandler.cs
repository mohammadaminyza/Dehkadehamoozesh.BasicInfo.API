using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.UpdateWalletTransactionDetail;

public class UpdateWalletTransactionDetailCommandHandler : CommandHandler<UpdateWalletTransactionDetailCommand>
{
    private readonly IWalletTransactionDetailCommandRepository _transactionDetailCommandRepository;

    public UpdateWalletTransactionDetailCommandHandler(BasementServices basementServices, IWalletTransactionDetailCommandRepository transactionDetailCommandRepository) : base(basementServices)
    {
        _transactionDetailCommandRepository = transactionDetailCommandRepository;
    }

    public override async Task<CommandResult> Handle(UpdateWalletTransactionDetailCommand request)
    {
        var entity = await _transactionDetailCommandRepository.GetAsync(request.BusinessId);

        entity.Update(request.BusinessId, request.UserId, request.Description, request.TransactionTypeId);

        await _transactionDetailCommandRepository.CommitAsync();
        return await OkAsync();
    }
}