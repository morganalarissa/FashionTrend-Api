using fashionTrend.Application.UseCases.ContractCases.CreateContract;
using fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier;
using fashionTrend.Application.UseCases.SupplierCases.GetAllSupplier;
using fashionTrend.Application.UseCases.SupplierCases.UpdateSupplier;
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

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateContractResponse>>
        Update(Guid id, UpdateContractRequest request, CancellationToken cancellationToken)
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

            var deleteRequest = new DeleteContractRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllContractResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllContractRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
