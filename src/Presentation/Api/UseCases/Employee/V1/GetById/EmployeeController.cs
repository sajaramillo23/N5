using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Employee.GetById;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpGet]
        [Route("{employeeId}")]
        [ProducesResponseType(typeof(GetEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEmployeeAsync(int itemId)
        {
            var response = await _mediator.Send(new GetEmployeeRequest(itemId));
            return Ok(response);
        }
    }
}
