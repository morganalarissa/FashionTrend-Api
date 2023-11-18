
using fashionTrend.Application.UseCases.SupplierCases.CreateSupplier;
using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier;
using fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier;
using fashionTrend.Domain.Entities;
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
        public async Task<IActionResult> Create(CreateServiceOrderRequest request)
        {
            var serviceOrder = await _mediator.Send(request);
            return Ok(serviceOrder);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateServiceOrderResponse>>
        Update(Guid id, UpdateServiceOrderRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeleteServiceOrderRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllServiceOrderResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllServiceOrderRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
