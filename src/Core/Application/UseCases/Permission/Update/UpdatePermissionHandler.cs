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

        public UpdatePermissionHandler(IPermissionService itemService)
        {
            _permissionService = itemService;
        }
        public async Task<Response<UpdatePermissionResult>> Handle(UpdatePermissionRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistItemAsync(request);

            var item = await _permissionService.UpdateAsync(request.ToPermissionDto());

            var itemResult = new UpdatePermissionResult(item);

            return new Response<UpdatePermissionResult>(itemResult);
        }

        private async Task ValidateExistItemAsync(UpdatePermissionRequest request)
        {
            var itemEntity = await _permissionService.GetAsync(request.Id);

            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
