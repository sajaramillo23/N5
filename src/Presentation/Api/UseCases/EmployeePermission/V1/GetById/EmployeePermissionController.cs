using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.EmployeePermission.GetById;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(GetEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEmployeePermissionAsync(int id)
        {
            _logger.LogInformation($"Calling method EmployeePermission/get {id}");
            var response = await _mediator.Send(new GetEmployeePermissionRequest(id));
            return Ok(response);
        }
    }
}
