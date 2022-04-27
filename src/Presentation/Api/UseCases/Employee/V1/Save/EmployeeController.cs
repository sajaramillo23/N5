using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N5.Application.UseCases.Employee.Save;

using System.Threading.Tasks;

namespace Net_Experience.UseCases.Employee.V1
{
    public partial class EmployeeController
    {
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(SaveEmployeeResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> saveEmployeeAsync(SaveEmployeeRequest itemRequest)
        {
            var response = await _mediator.Send(itemRequest.ToSaveEmployeeRequest());
            
            return Ok(response);
        }
    }
}
