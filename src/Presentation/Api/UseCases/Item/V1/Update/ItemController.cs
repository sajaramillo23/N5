using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Item.Update;
using System;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class EmployeeController
    {
        [HttpPut]
        [Route("{itemId}")]
        [ProducesResponseType(typeof(UpdateItemResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> updateItemAsync(UpdateItemRequest itemRequest, Guid itemId)
        {
            itemRequest.Id = itemId;

            var response = await _mediator.Send(itemRequest.ToUpdateItemRequest());
            return Ok(response);
        }
    }
}
