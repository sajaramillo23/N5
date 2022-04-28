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

        public SavePermissionHandler(IPermissionService itemService)
        {
            permissionService = itemService;
        }
        public async Task<Response<SavePermissionResult>> Handle(SavePermissionRequest request, CancellationToken cancellationToken)
        {
           var item = await permissionService.SaveAsync(request.ToPermissionDto());

            var itemResult = new SavePermissionResult(item);

            return new Response<SavePermissionResult>(itemResult);
        }
    }
}
