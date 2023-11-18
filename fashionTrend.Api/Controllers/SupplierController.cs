using fashionTrend.Application.UseCases.SupplierCases.CreateSupplier;
using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier;
using fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        IMediator _mediator;
        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSupplierRequest request)
        {
            var supplier = await _mediator.Send(request);
            return Ok(supplier);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateSupplierResponse>>
        Update(Guid id, UpdateSupplierRequest request, CancellationToken cancellationToken)
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

        var deleteRequest = new DeleteSupplierRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllSupplierResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
