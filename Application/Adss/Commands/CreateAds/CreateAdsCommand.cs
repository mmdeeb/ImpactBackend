using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;

using MediatR;

namespace Application.Adss.Commands.CreateAds;

public record CreateAdsCommand : IRequest<int>
{
        public string? ListAdsMedia { get; set; }
        public string? AdsTitle { get; set; }
        public string? AdsDescription { get; set; }
    }
public class CreateAdsCommandHandler : IRequestHandler<CreateAdsCommand, int>
{
	private readonly IApplicationDbContext context;
	private readonly IMapper mapper;

	public CreateAdsCommandHandler(IApplicationDbContext context, IMapper mapper)
	{
		this.context = context;
		this.mapper = mapper;
	}
	public async Task<int> Handle(CreateAdsCommand request, CancellationToken cancellationToken)
	{
		var entity = mapper.Map<Ads>(request);
		entity.Created = DateTime.Now;
		await context.Ads.AddAsync(entity);
		await context.SaveChangesAsync();

		return entity.Id;
	}
}
