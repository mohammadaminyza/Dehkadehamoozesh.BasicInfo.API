using M.YZ.Basement.Core.ApplicationServices.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.UpdateWalletTransactionDetail;

public class UpdateWalletTransactionDetailCommand : ICommand
{
    public Guid BusinessId { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public int TransactionTypeId { get; set; }

}