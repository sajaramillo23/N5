using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Net_Experience.UseCases.Item.V1
{
    [ApiController]
    //[EnableCors("allowSpecificOrigins")]
    [Route("Items")]
    public partial class EmployeeController : ControllerBase 
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
