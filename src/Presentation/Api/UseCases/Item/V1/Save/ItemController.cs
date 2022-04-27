using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Item.Save;
using System.Threading.Tasks;

namespace Net_Experience.UseCases.Item.V1
{
    public partial class EmployeeController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveItemResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveItemAsync(SaveItemRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSaveItemRequest());
            
            return Ok(response);
        }
    }
}
