using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Employee.GetById;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(GetEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEmployeeAsync(int id)
        {
            _logger.LogInformation($"Calling method Employee/get {id}", id);
            var response = await _mediator.Send(new GetEmployeeRequest(id));
            return Ok(response);
        }
    }
}
