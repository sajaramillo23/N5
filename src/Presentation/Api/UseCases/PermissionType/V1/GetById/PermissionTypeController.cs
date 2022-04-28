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
        [Route("{id}")]
        [ProducesResponseType(typeof(GetPermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPermissionTypeAsync(int id)
        {
            var response = await _mediator.Send(new GetPermissionTypeRequest(id));
            return Ok(response);
        }
    }
}
