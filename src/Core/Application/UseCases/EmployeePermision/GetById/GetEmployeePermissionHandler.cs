using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.EmployeePermission.GetById
{
    public class GetEmployeePermissionHandler : IRequestHandler<GetEmployeePermissionRequest, Response<GetEmployeePermissionResult>>
    {
        private readonly IEmployeePermissionService _EmployeePermissionService;

        public GetEmployeePermissionHandler(IEmployeePermissionService employeePermissionService)
        {
            _EmployeePermissionService = employeePermissionService;
        }
        public async Task<Response<GetEmployeePermissionResult>> Handle(GetEmployeePermissionRequest request, CancellationToken cancellationToken)
        {
            var employeePermissionDto = await _EmployeePermissionService.GetAsync(request.Id);

            if (employeePermissionDto is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var employeePermissionResult = new GetEmployeePermissionResult(employeePermissionDto);

            return new Response<GetEmployeePermissionResult>(employeePermissionResult);
        }
    }
}
