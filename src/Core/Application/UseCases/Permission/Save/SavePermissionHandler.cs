using MediatR;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Permission.Save
{
    public class SavePermissionHandler : IRequestHandler<SavePermissionRequest, Response<SavePermissionResult>>
    {
        private readonly IPermissionService permissionService;

        public SavePermissionHandler(IPermissionService permissionService)
        {
            this.permissionService = permissionService;
        }
        public async Task<Response<SavePermissionResult>> Handle(SavePermissionRequest request, CancellationToken cancellationToken)
        {
           var permissionDto = await permissionService.SaveAsync(request.ToPermissionDto());

            var permissionResult = new SavePermissionResult(permissionDto);

            return new Response<SavePermissionResult>(permissionResult);
        }
    }
}
