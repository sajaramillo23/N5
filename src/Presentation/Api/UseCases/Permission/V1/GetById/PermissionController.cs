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
        [Route("{id}")]
        [ProducesResponseType(typeof(GetPermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPermissionAsync(int id)
        {
            var response = await _mediator.Send(new GetPermissionRequest(id));
            return Ok(response);
        }
    }
}
