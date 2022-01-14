using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetailById;

public class GetWalletTransactionDetailByIdValidator : AbstractValidator<GetWalletTransactionDetailByIdQuery>
{
    public GetWalletTransactionDetailByIdValidator(ITranslator translator)
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(w => w.BusinessId)
            .NotEmpty().WithMessage(translator[ResourceKeys.BusinessIdRequiredError])
            .NotEqual(Guid.Empty).WithMessage(translator[ResourceKeys.InvalidValue]);
    }
}