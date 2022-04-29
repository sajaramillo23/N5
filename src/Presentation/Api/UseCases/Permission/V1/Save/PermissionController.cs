using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.Permission.Save;
using N5.ElasticSearch;
using System.Threading.Tasks;

namespace N5.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpPost]
        [Route("RequestPermission")]
        [ProducesResponseType(typeof(SavePermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> savePermissionAsync(SavePermissionRequest itemRequest)
        {
            _logger.LogInformation($"Executing RequestPermission operation with Id", itemRequest);
            var response = await _mediator.Send(itemRequest.ToSavePermissionRequest());
            var elasticService = new ElasticSearchService<SavePermissionResult>(_elasticClient);
            await elasticService.Post(response.Data);
            
            return Ok(response);
        }
    }
}
