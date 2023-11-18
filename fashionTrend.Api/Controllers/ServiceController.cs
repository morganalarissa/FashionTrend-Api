using fashionTrend.Application.UseCases.ServiceCases.CreateServices;
using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier;
using fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceRequest request)
        {
            var service = await _mediator.Send(request);
            return Ok(service);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateServiceResponse>>
        Update(Guid id, UpdateServiceRequest request, CancellationToken cancellationToken)
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

            var deleteRequest = new DeleteServiceRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllServiceResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllServiceRequest(), cancellationToken);
            return Ok(response);
        }

    }
}
