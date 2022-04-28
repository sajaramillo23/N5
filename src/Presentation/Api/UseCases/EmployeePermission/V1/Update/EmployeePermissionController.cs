using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.EmployeePermission.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(UpdateEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateEmployeePermissionAsync(UpdateEmployeePermissionRequest itemRequest, int id)
        {
            itemRequest.Id = id;
            _logger.LogInformation($"Calling method EmployeePermission/update {id}", itemRequest);
            var response = await _mediator.Send(itemRequest.ToUpdateEmployeePermissionRequest());
            return Ok(response);
        }
    }
}
