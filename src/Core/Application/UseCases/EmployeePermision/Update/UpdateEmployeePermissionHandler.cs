using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.EmployeePermission.Update
{
    public class UpdateEmployeePermissionHandler : IRequestHandler<UpdateEmployeePermissionRequest, Response<UpdateEmployeePermissionResult>>
    {
        private readonly IEmployeePermissionService _EmployeePermissionService;

        public UpdateEmployeePermissionHandler(IEmployeePermissionService EmployeePermissionService)
        {
            _EmployeePermissionService = EmployeePermissionService;
        }
        public async Task<Response<UpdateEmployeePermissionResult>> Handle(UpdateEmployeePermissionRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistItemAsync(request);

            var item = await _EmployeePermissionService.UpdateAsync(request.ToEmployeePermissionDto());

            var itemResult = new UpdateEmployeePermissionResult(item);

            return new Response<UpdateEmployeePermissionResult>(itemResult);
        }

        private async Task ValidateExistItemAsync(UpdateEmployeePermissionRequest request)
        {
            var itemEntity = await _EmployeePermissionService.GetAsync(request.Id);

            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
