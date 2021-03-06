using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.PermissionType.Update;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.PermissionType.V1
{
    public partial class PermissionTypeController
    {
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(UpdatePermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updatePermissionTypeAsync(UpdatePermissionTypeRequest permissionTypeRequest, int id)
        {
            permissionTypeRequest.Id = id;
            _logger.LogInformation($"Executing PermissionType operation Update with Id {id}", permissionTypeRequest);

            var response = await _mediator.Send(permissionTypeRequest.ToUpdatePermissionTypeRequest());
            return Ok(response);
        }
    }
}
