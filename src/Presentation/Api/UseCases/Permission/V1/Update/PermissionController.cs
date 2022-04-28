﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Permission.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(UpdatePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updatePermissionAsync(UpdatePermissionRequest itemRequest, int id)
        {
            itemRequest.Id = id;

            var response = await _mediator.Send(itemRequest.ToUpdatePermissionRequest());
            return Ok(response);
        }
    }
}
