using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.PermissionType.Save;

using System.Threading.Tasks;

namespace Net_Experience.UseCases.PermissionType.V1
{
    public partial class PermissionTypeController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SavePermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> savePermissionTypeAsync(SavePermissionTypeRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSavePermissionTypeRequest());
            
            return Ok(response);
        }
    }
}
