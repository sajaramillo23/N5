using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.EmployeePermission.GetById;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpGet]
        [Route("{EmployeePermissionId}")]
        [ProducesResponseType(typeof(GetEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEmployeePermissionAsync(int itemId)
        {
            var response = await _mediator.Send(new GetEmployeePermissionRequest(itemId));
            return Ok(response);
        }
    }
}
