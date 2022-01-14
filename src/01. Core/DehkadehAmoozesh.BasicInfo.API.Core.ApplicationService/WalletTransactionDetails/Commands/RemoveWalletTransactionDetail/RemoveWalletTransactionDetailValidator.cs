using DehkadehAmoozesh.BasicInfo.API.Core.Domain;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using FluentValidation;
using M.YZ.Basement.Utilities.Services.Localizations;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.RemoveWalletTransactionDetail;

public class RemoveWalletTransactionDetailValidator : AbstractValidator<RemoveWalletTransactionDetailCommand>
{
    public RemoveWalletTransactionDetailValidator(IWalletTransactionDetailCommandRepository transactionDetailCommandRepository, ITranslator translator)
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(p => p.BusinessId)
            .NotEmpty().WithMessage(translator[ResourceKeys.BusinessIdNotFound])
            .Must(bid => transactionDetailCommandRepository.Exists(p => p.BusinessId.Equals(bid)));
    }
}