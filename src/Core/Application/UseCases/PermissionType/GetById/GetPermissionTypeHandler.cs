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

        public GetPermissionTypeHandler(IPermissionTypeService permissionTypeService)
        {
            _permissionTypeService = permissionTypeService;
        }
        public async Task<Response<GetPermissionTypeResult>> Handle(GetPermissionTypeRequest request, CancellationToken cancellationToken)
        {
            var permissionTypeDto = await _permissionTypeService.GetAsync(request.Id);

            if (permissionTypeDto is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var permissionTypeResult = new GetPermissionTypeResult(permissionTypeDto);

            return new Response<GetPermissionTypeResult>(permissionTypeResult);
        }
    }
}
