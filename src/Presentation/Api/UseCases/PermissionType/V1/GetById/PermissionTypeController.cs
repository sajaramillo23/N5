using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.PermissionType.GetById;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.PermissionType.V1
{
    public partial class PermissionTypeController
    {
        [HttpGet]
        [Route("{permissionTypeId}")]
        [ProducesResponseType(typeof(GetPermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPermissionTypeAsync(int itemId)
        {
            var response = await _mediator.Send(new GetPermissionTypeRequest(itemId));
            return Ok(response);
        }
    }
}
