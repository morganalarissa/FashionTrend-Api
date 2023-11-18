using fashionTrend.Application.UseCases.MessageCases.CreateMessage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMediator _mediator;
        public MessageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMessageRequest request)
        {
            var message = await _mediator.Send(request);
            return Ok(message);
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<UpdateSupplierResponse>>
        //Update(Guid id, UpdateSupplierRequest request, CancellationToken cancellationToken)
        //{
        //    if (id != request.Id)
        //    {
        //        return BadRequest();
        //    }
        //    var response = await _mediator.Send(request, cancellationToken);
        //    return Ok(response);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        //{
        //if (id is null)
        //{
        //    return BadRequest();
        //}

        //var deleteRequest = new DeleteSupplierRequest(id.Value);
        //var response = await _mediator.Send(deleteRequest, cancellationToken);
        //return Ok(response);
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<GetAllSupplierResponse>>> GetAll(CancellationToken cancellationToken)
        //{
        //    var response = await _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
        //    return Ok(response);
        //}
    }
}
