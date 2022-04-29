using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.EmployeePermission.Save;

using System.Threading.Tasks;

namespace N5.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveEmployeePermissionAsync(SaveEmployeePermissionRequest employeeRequest)
        {
            _logger.LogInformation($"Calling method EmployeePermission/save", employeeRequest);
            var response = await _mediator.Send(employeeRequest.ToSaveEmployeePermissionRequest());
            
            return Ok(response);
        }
    }
}
