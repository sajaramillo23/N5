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

        public GetEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Response<GetEmployeeResult>> Handle(GetEmployeeRequest request, CancellationToken cancellationToken)
        {
            var employeeDto = await _employeeService.GetAsync(request.Id);

            if (employeeDto is null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            var employeeResult = new GetEmployeeResult(employeeDto);

            return new Response<GetEmployeeResult>(employeeResult);
        }
    }
}
