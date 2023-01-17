using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Contracts;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Inputs;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts;
using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;
using M.YZ.Basement.Utilities.Services.ObjectMappers;
using Microsoft.EntityFrameworkCore;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.WalletTransactionDetails;

public class WalletTransactionDetailQueryRepository : BaseQueryRepository<BasicInfoQueryDbContext>, IWalletTransactionDetailQueryRepository
{
    private readonly IMapperAdapter _mapper;

    public WalletTransactionDetailQueryRepository(BasicInfoQueryDbContext dbContext, IMapperAdapter mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    public PagedData<WalletTransactionDetailsDto> Select(IWalletTransactionDetailsDto transactionDetailsDto)
    {
        #region Query

        var query = _dbContext.TransactionDetails.AsQueryable();

        #endregion

        #region Properties

        var sortBy = transactionDetailsDto.SortBy ?? string.Empty;
        var sortAscending = transactionDetailsDto.SortAscending;
        var pageSize = transactionDetailsDto.PageSize;
        var pageNumber = transactionDetailsDto.PageNumber;

        #endregion

        #region Filter

        if (!transactionDetailsDto.Description.IsNullOrEmpty())
            query = query.Where(p => p.Description.Contains(transactionDetailsDto.Description));

        if (!transactionDetailsDto.UserId.IsNullOrEmpty())
            query = query.Where(p => p.UserId.Equals(transactionDetailsDto.UserId));

        if (!transactionDetailsDto.TransactionTypeId.IsNullOrEmpty())
            query = query.Where(p => p.TransactionTypeId.Equals(transactionDetailsDto.TransactionTypeId));

        #endregion

        #region Sorts

        if (typeof(WalletTransactionDetail).GetProperty(sortBy) is not null)
        {
            query = sortAscending
                ? query.OrderBy(m => EF.Property<WalletTransactionDetail>(m, sortBy))
                : query.OrderByDescending(m => EF.Property<WalletTransactionDetail>(m, sortBy));
        }

        #endregion

        #region Paging

        var result = _mapper.MapTo<WalletTransactionDetail, WalletTransactionDetailsDto>(query).PagingResult(transactionDetailsDto);

        #endregion

        return result;
    }

    public WalletTransactionDetailByIdDto Select(IWalletTransactionDetailByIdDto transactionDetailsDto)
    {
        #region Query

        var query = _dbContext.TransactionDetails.AsQueryable();

        #endregion

        #region Filter

        query = query.Where(p => p.BusinessId == transactionDetailsDto.BusinessId);

        #endregion

        #region Result

        var result = _mapper.MapTo<WalletTransactionDetail, WalletTransactionDetailByIdDto>(query);

        #endregion

        return result.SingleOrDefault();
    }
}