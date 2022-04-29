using MediatR;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.PermissionType.Save
{
    public class SavePermissionTypeHandler : IRequestHandler<SavePermissionTypeRequest, Response<SavePermissionTypeResult>>
    {
        private readonly IPermissionTypeService permissionTypeService;

        public SavePermissionTypeHandler(IPermissionTypeService permissionTypeService)
        {
            this.permissionTypeService = permissionTypeService;
        }
        public async Task<Response<SavePermissionTypeResult>> Handle(SavePermissionTypeRequest request, CancellationToken cancellationToken)
        {
           var permissionTypeDto = await permissionTypeService.SaveAsync(request.ToPermissionTypeDto());

            var permissionTypeResult = new SavePermissionTypeResult(permissionTypeDto);

            return new Response<SavePermissionTypeResult>(permissionTypeResult);
        }
    }
}
