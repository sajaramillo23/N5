using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.PermissionType.Save;

using System.Threading.Tasks;

namespace N5.UseCases.PermissionType.V1
{
    public partial class PermissionTypeController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SavePermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> savePermissionTypeAsync(SavePermissionTypeRequest permissionTypeRequest)
        {
            _logger.LogInformation($"Executing PermissionType operation Save", permissionTypeRequest);
            var response = await _mediator.Send(permissionTypeRequest.ToSavePermissionTypeRequest());
            
            return Ok(response);
        }
    }
}
