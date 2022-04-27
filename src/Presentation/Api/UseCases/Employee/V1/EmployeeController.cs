using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Employee.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Employees")]
    public partial class EmployeeController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
