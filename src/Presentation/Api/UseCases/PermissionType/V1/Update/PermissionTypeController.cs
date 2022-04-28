using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.PermissionType.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.PermissionType.V1
{
    public partial class PermissionTypeController
    {
        [HttpPut]
        [Route("{PermissionTypeId}")]
        [ProducesResponseType(typeof(UpdatePermissionTypeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updatePermissionTypeAsync(UpdatePermissionTypeRequest itemRequest, int itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdatePermissionTypeRequest());
            return Ok(response);
        }
    }
}
