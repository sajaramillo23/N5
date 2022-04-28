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

        public SaveEmployeePermissionHandler(IEmployeePermissionService itemService)
        {
            EmployeePermissionService = itemService;
        }
        public async Task<Response<SaveEmployeePermissionResult>> Handle(SaveEmployeePermissionRequest request, CancellationToken cancellationToken)
        {
           var item = await EmployeePermissionService.SaveAsync(request.ToEmployeePermissionDto());

            var itemResult = new SaveEmployeePermissionResult(item);

            return new Response<SaveEmployeePermissionResult>(itemResult);
        }
    }
}
