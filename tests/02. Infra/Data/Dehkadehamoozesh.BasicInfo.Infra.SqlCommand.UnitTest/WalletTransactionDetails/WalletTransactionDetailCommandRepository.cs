using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Contracts;
using Xunit;

namespace Dehkadehamoozesh.BasicInfo.Infra.SqlCommand.UnitTest.WalletTransactionDetails;

public class WalletTransactionDetailCommandRepositoryTest : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly IWalletTransactionDetailCommandRepository _walletTransactionDetailCommandRepository;

    public WalletTransactionDetailCommandRepositoryTest(IWalletTransactionDetailCommandRepository walletTransactionDetailCommandRepository)
    {
        _walletTransactionDetailCommandRepository = walletTransactionDetailCommandRepository;
    }

    //[Fact]
    //public async Task Insert_Test()
    //{
    //}
}