using fashionTrend.Application.UseCases.DraftContractCases;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    // Nome da Rota
    [Route("api/[controller]")]
    [ApiController]
    public class DraftController : ControllerBase
    {
        IMediator _mediator;

        public DraftController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDraftContractRequest request)
        {
            var message = await _mediator.Send(request);
            return Ok(message);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AcceptedDraftContractResponse>>
           Update(Guid id, AcceptedDraftContractRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
                return BadRequest();

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
