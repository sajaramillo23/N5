using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.Employee.Save;

using System.Threading.Tasks;

namespace N5.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveEmployeeAsync(SaveEmployeeRequest itemRequest)
        {
            _logger.LogInformation($"Calling method Employee/save ", itemRequest);
            var response = await _mediator.Send(itemRequest.ToSaveEmployeeRequest());
            
            return Ok(response);
        }
    }
}
