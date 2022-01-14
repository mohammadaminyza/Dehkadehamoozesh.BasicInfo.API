using M.YZ.Basement.Core.ApplicationServices.Commands;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.RemoveWalletTransactionDetail;

public class RemoveWalletTransactionDetailCommand : ICommand
{
    public Guid BusinessId { get; set; }
}