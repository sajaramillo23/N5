﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace N5.UseCases.EmployeePermission.V1
{
    [ApiController]
    
    [Route("EmployeePermissions")]
    public partial class EmployeePermissionController : ControllerBase 
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EmployeePermissionController> _logger;

        public EmployeePermissionController(IMediator mediator, ILogger<EmployeePermissionController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}
