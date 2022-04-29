using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace N5.UseCases.PermissionType.V1
{
    [ApiController]
    
    [Route("PermissionTypes")]
    public partial class PermissionTypeController : ControllerBase 
    {
        private readonly IMediator _mediator;
        private readonly ILogger<PermissionTypeController> _logger;

        public PermissionTypeController(IMediator mediator,ILogger<PermissionTypeController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}
