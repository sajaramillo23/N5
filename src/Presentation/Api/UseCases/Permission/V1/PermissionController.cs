using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;

namespace N5.UseCases.Permission.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Permissions")]
    public partial class PermissionController : ControllerBase 
    {
        private readonly IMediator _mediator;
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<PermissionController> _logger;

        public PermissionController(IMediator mediator, IElasticClient elasticClient, ILogger<PermissionController> logger)
        {
            _mediator = mediator;
            _elasticClient = elasticClient;
            _logger = logger;
            
        }
    }
}
