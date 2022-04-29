using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace N5.UseCases.Employee.V1
{
    [ApiController]
    
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
