using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.PermissionType.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("PermissionTypes")]
    public partial class PermissionTypeController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public PermissionTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
