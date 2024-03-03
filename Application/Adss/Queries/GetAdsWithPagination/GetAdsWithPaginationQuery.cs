using Application.Common.Interfaces;
using Application.Common.Mappings;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;

using MediatR;

namespace Application.Adss.Queries.GetAdsWithPagination;

public record GetAdsWithPaginationQuery : IRequest<PaginatedList<Ads>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetAdsWithPaginationQueryHandler : IRequestHandler<GetAdsWithPaginationQuery, PaginatedList<Ads>>
{
    private readonly IApplicationDbContext context;
    private readonly IMapper mapper;

    public GetAdsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;              
    }
    public async Task<PaginatedList<Ads>> Handle(GetAdsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        var query = context.Ads.AsQueryable();

        return await query
            .ProjectTo<Ads>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}

