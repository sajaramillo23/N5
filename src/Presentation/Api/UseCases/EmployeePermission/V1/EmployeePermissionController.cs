using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("EmployeePermissions")]
    public partial class EmployeePermissionController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public EmployeePermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
