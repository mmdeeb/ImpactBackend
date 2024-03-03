using Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Adss.Queries.GetAdsWithPagination;
using Application.Adss.GetAds;
using Application.Adss.Commands.CreateAds;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Controllers
{

    [Authorize]
    public class AdsController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<PaginatedList<Ads>>> GetPatientsPagination([FromQuery] GetAdsWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ads>> Update([FromRoute] int id)
        {
            return await Mediator.Send(new GetAdsQuery(id));
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateAdsCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
