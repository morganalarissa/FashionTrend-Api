using fashionTrend.Application.UseCases.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrderController : ControllerBase
    {
        IMediator _mediator;

        public ServiceOrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceOrdersRequest request)
        {
            var serviceOrder = await _mediator.Send(request);
            return Ok(serviceOrder);
        }
    }
}
