using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.EmployeePermission.Save;

using System.Threading.Tasks;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveEmployeePermissionAsync(SaveEmployeePermissionRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSaveEmployeePermissionRequest());
            
            return Ok(response);
        }
    }
}
