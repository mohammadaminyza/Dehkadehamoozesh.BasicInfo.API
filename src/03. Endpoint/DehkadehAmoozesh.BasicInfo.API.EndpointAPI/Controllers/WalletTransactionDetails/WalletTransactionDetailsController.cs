using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Commands.CreateWalletTransactionDetail;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetailById;
using DehkadehAmoozesh.BasicInfo.API.Core.ApplicationService.WalletTransactionDetails.Queries.GetWalletTransactionDetails;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;
using M.YZ.Basement.EndPoints.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DehkadehAmoozesh.BasicInfo.API.EndpointAPI.Controllers.WalletTransactionDetails;

[Route("api/[controller]")]
[ApiController]
public class WalletTransactionDetailsController : BaseController
{
    #region Query

    [HttpGet("get")]
    public async Task<IActionResult> GetTransactionDetails([FromQuery] GetWalletTransactionDetailsQuery getTransactionDetailsQuery)
    {
        return await Query<GetWalletTransactionDetailsQuery,
            PagedData<WalletTransactionDetailsDto>>(getTransactionDetailsQuery);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetTransactionDetails([FromQuery] GetWalletTransactionDetailByIdQuery getWalletTransactionDetailByIdQuery)
    {
        return await Query<GetWalletTransactionDetailByIdQuery,
            WalletTransactionDetailByIdDto>(getWalletTransactionDetailByIdQuery);
    }

    #endregion

    #region Command

    [HttpPost("create")]
    public async Task<IActionResult> CreateTransactionDetail([FromBody] CreateWalletTransactionDetailCommand createTransactionDetailCommand)
    {
        return await Create(createTransactionDetailCommand);
    }

    #endregion
}