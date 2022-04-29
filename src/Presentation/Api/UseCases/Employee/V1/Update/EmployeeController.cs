using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.Employee.Update;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(UpdateEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateEmployeeAsync(UpdateEmployeeRequest employeeRequest, int id)
        {
            employeeRequest.Id = id;
            _logger.LogInformation($"Calling method Employee/update {id}", employeeRequest);
            var response = await _mediator.Send(employeeRequest.ToUpdateEmployeeRequest());
            return Ok(response);
        }
    }
}
