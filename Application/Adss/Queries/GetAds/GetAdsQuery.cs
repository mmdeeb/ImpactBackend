using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Adss.GetAds;

public record GetAdsQuery(int Id) : IRequest<Ads>;

public class GetPatientQueryHandler : IRequestHandler<GetAdsQuery, Ads>
{
    private readonly IApplicationDbContext context;

    public GetPatientQueryHandler(IApplicationDbContext context)
    {
        this.context = context;
    }
    public async Task<Ads> Handle(GetAdsQuery request, CancellationToken cancellationToken)
    {
        var entity = await context.Ads.FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Ads), request.Id);
        }

        return entity;
    }
}
