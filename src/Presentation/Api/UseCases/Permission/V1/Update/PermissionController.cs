using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.Permission.Update;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpPut]
        [Route("ModifyPermission/{id}")]
        [ProducesResponseType(typeof(UpdatePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updatePermissionAsync(UpdatePermissionRequest itemRequest, int id)
        {
            itemRequest.Id = id;
            _logger.LogInformation($"Calling method EmployeePermission/ModifyPermission {id}", itemRequest);
            var response = await _mediator.Send(itemRequest.ToUpdatePermissionRequest());
            return Ok(response);
        }
    }
}
