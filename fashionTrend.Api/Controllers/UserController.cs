using fashionTrend.Application.UseCases.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace fashionTrend.Api.Controllers
{
    // Nome da Rota
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            var user = await _mediator.Send(request);
            return Ok(user);
        }
    }
}
