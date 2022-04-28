using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Permission.Save;

using System.Threading.Tasks;

namespace Net_Experience.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SavePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> savePermissionAsync(SavePermissionRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSavePermissionRequest());
            
            return Ok(response);
        }
    }
}
