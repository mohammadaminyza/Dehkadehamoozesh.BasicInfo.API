using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.RemoveWalletTransactionDetail;

public class RemoveWalletTransactionDetailCommandHandler : CommandHandler<RemoveWalletTransactionDetailCommand>
{
    private readonly IWalletTransactionDetailCommandRepository _transactionDetailCommandRepository;

    public RemoveWalletTransactionDetailCommandHandler(BasementServices basementOptions, IWalletTransactionDetailCommandRepository transactionDetailCommandRepository) : base(basementOptions)
    {
        _transactionDetailCommandRepository = transactionDetailCommandRepository;
    }

    public override async Task<CommandResult> Handle(RemoveWalletTransactionDetailCommand request)
    {
        var entity = await _transactionDetailCommandRepository.GetAsync(request.BusinessId);

        entity.Delete();

        _transactionDetailCommandRepository.Delete(entity);
        await _transactionDetailCommandRepository.CommitAsync();

        return await OkAsync();
    }
}