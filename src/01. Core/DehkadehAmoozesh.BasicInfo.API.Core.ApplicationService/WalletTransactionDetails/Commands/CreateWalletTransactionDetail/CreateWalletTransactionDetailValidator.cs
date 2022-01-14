using DA.Utilities.Extensions;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using FluentValidation;
using M.YZ.Basement.Utilities.Services.Localizations;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.CreateWalletTransactionDetail;

public class CreateWalletTransactionDetailValidator : AbstractValidator<CreateWalletTransactionDetailCommand>
{
    public CreateWalletTransactionDetailValidator(ITranslator translator)
    {
        CascadeMode = CascadeMode.Stop;

        //Todo Check Exist
        RuleFor(p => p.UserId);

        RuleFor(o => o.Description)
            .MinimumLength(2).When(p => !p.Description.IsNullOrEmpty())
            .WithMessage(translator[ResourceKeys.InvalidMinLength])
            .MaximumLength(255).When(p => !p.Description.IsNullOrEmpty())
            .WithMessage(translator[ResourceKeys.InvalidMaxLength]);
    }
}