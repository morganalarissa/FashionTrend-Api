using fashionTrend.Application.UseCases.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        IMediator _mediator;

        public ContractController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContractRequest request)
        {
            var contract = await _mediator.Send(request);
            return Ok(contract);
        }
    }
}
