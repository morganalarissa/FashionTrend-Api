using fashionTrend.Application.UseCases.Consumer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    // Nome da Rota
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        IMediator _mediator;

        public ConsumerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ConsumerMessageRequest request)
        {
            var message = await _mediator.Send(request);
            return Ok(message);
        }

    }
}
