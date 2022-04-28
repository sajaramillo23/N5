using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.EmployeePermission.GetById
{
    public class GetEmployeePermissionHandler : IRequestHandler<GetEmployeePermissionRequest, Response<GetEmployeePermissionResult>>
    {
        private readonly IEmployeePermissionService _EmployeePermissionService;

        public GetEmployeePermissionHandler(IEmployeePermissionService itemService)
        {
            _EmployeePermissionService = itemService;
        }
        public async Task<Response<GetEmployeePermissionResult>> Handle(GetEmployeePermissionRequest request, CancellationToken cancellationToken)
        {
            var item = await _EmployeePermissionService.GetAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetEmployeePermissionResult(item);

            return new Response<GetEmployeePermissionResult>(itemResult);
        }
    }
}
