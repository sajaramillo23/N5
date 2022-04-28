using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Permission.GetById
{
    public class GetPermissionHandler : IRequestHandler<GetPermissionRequest, Response<GetPermissionResult>>
    {
        private readonly IPermissionService _permissionService;

        public GetPermissionHandler(IPermissionService itemService)
        {
            _permissionService = itemService;
        }
        public async Task<Response<GetPermissionResult>> Handle(GetPermissionRequest request, CancellationToken cancellationToken)
        {
            var item = await _permissionService.GetAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetPermissionResult(item);

            return new Response<GetPermissionResult>(itemResult);
        }
    }
}
