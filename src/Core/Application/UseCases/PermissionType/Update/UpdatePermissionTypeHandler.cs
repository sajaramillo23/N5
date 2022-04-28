using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.PermissionType.Update
{
    public class UpdatePermissionTypeHandler : IRequestHandler<UpdatePermissionTypeRequest, Response<UpdatePermissionTypeResult>>
    {
        private readonly IPermissionTypeService _permissionTypeService;

        public UpdatePermissionTypeHandler(IPermissionTypeService itemService)
        {
            _permissionTypeService = itemService;
        }
        public async Task<Response<UpdatePermissionTypeResult>> Handle(UpdatePermissionTypeRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistItemAsync(request);

            var item = await _permissionTypeService.UpdateAsync(request.ToPermissionTypeDto());

            var itemResult = new UpdatePermissionTypeResult(item);

            return new Response<UpdatePermissionTypeResult>(itemResult);
        }

        private async Task ValidateExistItemAsync(UpdatePermissionTypeRequest request)
        {
            var itemEntity = await _permissionTypeService.GetAsync(request.Id);

            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
