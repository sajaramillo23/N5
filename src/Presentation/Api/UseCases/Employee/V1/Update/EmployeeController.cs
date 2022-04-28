using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Employee.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpPut]
        [Route("{employeeId}")]
        [ProducesResponseType(typeof(UpdateEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateEmployeeAsync(UpdateEmployeeRequest itemRequest, int itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdateEmployeeRequest());
            return Ok(response);
        }
    }
}
