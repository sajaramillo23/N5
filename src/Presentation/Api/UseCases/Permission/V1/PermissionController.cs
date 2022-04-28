using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Permission.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Permissions")]
    public partial class PermissionController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
