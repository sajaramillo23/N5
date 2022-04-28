using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            _logger.LogInformation($"Executing PermissionType operation get with Id {id}", id);
            var response = await _mediator.Send(new GetPermissionTypeRequest(id));
            return Ok(response);
        }
    }
}
