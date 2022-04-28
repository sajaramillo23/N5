using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.EmployeePermission.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public partial class EmployeePermissionController
    {
        [HttpPut]
        [Route("{EmployeePermissionId}")]
        [ProducesResponseType(typeof(UpdateEmployeePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateEmployeePermissionAsync(UpdateEmployeePermissionRequest itemRequest, int itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdateEmployeePermissionRequest());
            return Ok(response);
        }
    }
}
