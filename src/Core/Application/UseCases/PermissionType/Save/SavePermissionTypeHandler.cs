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

        public SavePermissionTypeHandler(IPermissionTypeService itemService)
        {
            permissionTypeService = itemService;
        }
        public async Task<Response<SavePermissionTypeResult>> Handle(SavePermissionTypeRequest request, CancellationToken cancellationToken)
        {
           var item = await permissionTypeService.SaveAsync(request.ToPermissionTypeDto());

            var itemResult = new SavePermissionTypeResult(item);

            return new Response<SavePermissionTypeResult>(itemResult);
        }
    }
}
