using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Employee.GetById
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeRequest, Response<GetEmployeeResult>>
    {
        private readonly IEmployeeService _employeeService;

        public GetEmployeeHandler(IEmployeeService itemService)
        {
            _employeeService = itemService;
        }
        public async Task<Response<GetEmployeeResult>> Handle(GetEmployeeRequest request, CancellationToken cancellationToken)
        {
            var item = await _employeeService.GetAsync(request.Id);

            if (item is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var itemResult = new GetEmployeeResult(item);

            return new Response<GetEmployeeResult>(itemResult);
        }
    }
}
