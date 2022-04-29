using MediatR;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.EmployeePermission.Save
{
    public class SaveEmployeePermissionHandler : IRequestHandler<SaveEmployeePermissionRequest, Response<SaveEmployeePermissionResult>>
    {
        private readonly IEmployeePermissionService EmployeePermissionService;

        public SaveEmployeePermissionHandler(IEmployeePermissionService employeePermissionService)
        {
            EmployeePermissionService = employeePermissionService;
        }
        public async Task<Response<SaveEmployeePermissionResult>> Handle(SaveEmployeePermissionRequest request, CancellationToken cancellationToken)
        {
           var employeePermissionDto = await EmployeePermissionService.SaveAsync(request.ToEmployeePermissionDto());

            var employeeResult = new SaveEmployeePermissionResult(employeePermissionDto);

            return new Response<SaveEmployeePermissionResult>(employeeResult);
        }
    }
}
