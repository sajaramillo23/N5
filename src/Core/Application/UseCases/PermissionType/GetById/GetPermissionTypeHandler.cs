using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.PermissionType.GetById
{
    public class GetPermissionTypeHandler : IRequestHandler<GetPermissionTypeRequest, Response<GetPermissionTypeResult>>
    {
        private readonly IPermissionTypeService _permissionTypeService;

        public GetPermissionTypeHandler(IPermissionTypeService itemService)
        {
            _permissionTypeService = itemService;
        }
        public async Task<Response<GetPermissionTypeResult>> Handle(GetPermissionTypeRequest request, CancellationToken cancellationToken)
        {
            var item = await _permissionTypeService.GetAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetPermissionTypeResult(item);

            return new Response<GetPermissionTypeResult>(itemResult);
        }
    }
}
