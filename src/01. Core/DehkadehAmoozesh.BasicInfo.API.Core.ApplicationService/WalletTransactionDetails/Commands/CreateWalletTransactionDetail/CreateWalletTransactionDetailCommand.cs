using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Enums;
using M.YZ.Basement.Core.ApplicationServices.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.CreateWalletTransactionDetail;
public class CreateWalletTransactionDetailCommand : ICommand
{
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public WalletTransactionType TransactionTypeId { get; set; }
}
