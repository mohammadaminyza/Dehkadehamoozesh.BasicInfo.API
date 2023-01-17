using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.EndpointAPI;
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