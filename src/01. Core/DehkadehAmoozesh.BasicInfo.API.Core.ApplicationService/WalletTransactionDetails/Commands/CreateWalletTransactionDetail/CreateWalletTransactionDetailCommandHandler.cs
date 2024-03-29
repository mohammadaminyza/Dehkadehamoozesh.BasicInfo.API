﻿using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Entities;

namespace DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.CreateWalletTransactionDetail;

public class CreateWalletTransactionDetailCommandHandler : CommandHandler<CreateWalletTransactionDetailCommand>
{
    private readonly IWalletTransactionDetailCommandRepository _transactionDetailCommandRepository;

    public CreateWalletTransactionDetailCommandHandler(BasementServices basementServices, IWalletTransactionDetailCommandRepository transactionDetailCommandRepository) : base(basementServices)
    {
        _transactionDetailCommandRepository = transactionDetailCommandRepository;
    }

    public override async Task<CommandResult> Handle(CreateWalletTransactionDetailCommand request)
    {
        var entity = new WalletTransactionDetail(Guid.NewGuid(), request.UserId, request.Description, request.TransactionTypeId);

        await _transactionDetailCommandRepository.InsertAsync(entity);
        await _transactionDetailCommandRepository.CommitAsync();

        return await OkAsync();
    }
}