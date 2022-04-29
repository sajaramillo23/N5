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

        public UpdatePermissionTypeHandler(IPermissionTypeService permissionTypeService)
        {
            _permissionTypeService = permissionTypeService;
        }
        public async Task<Response<UpdatePermissionTypeResult>> Handle(UpdatePermissionTypeRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistPermissionTypeAsync(request);

            var permissionTypeDto = await _permissionTypeService.UpdateAsync(request.ToPermissionTypeDto());

            var permissionTypeResult = new UpdatePermissionTypeResult(permissionTypeDto);

            return new Response<UpdatePermissionTypeResult>(permissionTypeResult);
        }

        private async Task ValidateExistPermissionTypeAsync(UpdatePermissionTypeRequest request)
        {
            var permissionTypeEntity = await _permissionTypeService.GetAsync(request.Id);

            if (permissionTypeEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
