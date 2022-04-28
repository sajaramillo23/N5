using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Net_Experience.UseCases.Employee.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Employees")]
    public partial class EmployeeController : ControllerBase 
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IMediator mediator, ILogger<EmployeeController> logger)
        {
            _mediator = mediator;
            _logger = logger;

        }
    }
}
