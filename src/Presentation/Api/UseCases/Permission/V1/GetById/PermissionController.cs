using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N5.Application.UseCases.Permission.GetById;
using N5.Application.UseCases.Permission.Save;
using N5.Common.Helpers;
using N5.ElasticSearch;
using System;
using System.Threading.Tasks;

namespace N5.UseCases.Permission.V1
{
    public partial class PermissionController
    {
        [HttpGet]
        [Route("GetPermission/{id}")]
        [ProducesResponseType(typeof(GetPermissionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPermissionAsync(int id)
        {
            _logger.LogInformation($"Executing GetPermission operation with Id {id}",id);
            //query to elastic service first
            var elasticService = new ElasticSearchService<SavePermissionResult>(_elasticClient);
            var data = await elasticService.Get(id);
            if(data != null)
            {
                Response<GetPermissionResult> result = new Response<GetPermissionResult>(data.ToGetPermissionResult(), "");
                return Ok(result);
            }
            _logger.LogWarning($"Permission Id {id} was not found at the elastic serach index",id);
            //if no data, query to the database
            var response = await _mediator.Send(new GetPermissionRequest(id));
            return Ok(response);
        }
    }
}
