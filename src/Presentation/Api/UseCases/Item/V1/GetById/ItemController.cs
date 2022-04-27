﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Item.GetById;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class EmployeeController
    {
        [HttpGet]
        [Route("{itemId}")]
        [ProducesResponseType(typeof(GetItemResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetItemAsync(Guid itemId)
        {
            var response = await _mediator.Send(new GetItemRequest(itemId));
            return Ok(response);
        }
    }
}
