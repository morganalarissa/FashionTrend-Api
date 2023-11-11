
using fashionTrend.Application.UseCases.CreateSupplier;
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
    }
}
