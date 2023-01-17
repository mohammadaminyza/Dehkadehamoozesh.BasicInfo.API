using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Enums;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.CreateWalletTransactionDetail;
public class CreateWalletTransactionDetailCommand : ICommand
{
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public WalletTransactionType TransactionTypeId { get; set; }
}
