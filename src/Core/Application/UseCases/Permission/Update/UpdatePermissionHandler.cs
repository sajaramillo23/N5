using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Permission.Update
{
    public class UpdatePermissionHandler : IRequestHandler<UpdatePermissionRequest, Response<UpdatePermissionResult>>
    {
        private readonly IPermissionService _permissionService;

        public UpdatePermissionHandler(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public async Task<Response<UpdatePermissionResult>> Handle(UpdatePermissionRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistPermissionAsync(request);

            var permissionDto = await _permissionService.UpdateAsync(request.ToPermissionDto());

            var permissionResult = new UpdatePermissionResult(permissionDto);

            return new Response<UpdatePermissionResult>(permissionResult);
        }

        private async Task ValidateExistPermissionAsync(UpdatePermissionRequest request)
        {
            var permissionEntity = await _permissionService.GetAsync(request.Id);

            if (permissionEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
