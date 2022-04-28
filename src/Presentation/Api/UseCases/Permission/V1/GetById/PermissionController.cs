using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Permission.GetById;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpGet]
        [Route("{permissionId}")]
        [ProducesResponseType(typeof(GetPermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPermissionAsync(int itemId)
        {
            var response = await _mediator.Send(new GetPermissionRequest(itemId));
            return Ok(response);
        }
    }
}
