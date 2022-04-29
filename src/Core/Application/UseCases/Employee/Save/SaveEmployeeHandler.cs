using MediatR;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Employee.Save
{
    public class SaveEmployeeHandler : IRequestHandler<SaveEmployeeRequest, Response<SaveEmployeeResult>>
    {
        private readonly IEmployeeService employeeService;

        public SaveEmployeeHandler(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public async Task<Response<SaveEmployeeResult>> Handle(SaveEmployeeRequest request, CancellationToken cancellationToken)
        {
           var employeeDto = await employeeService.SaveAsync(request.ToEmployeeDto());

            var employeeResult = new SaveEmployeeResult(employeeDto);

            return new Response<SaveEmployeeResult>(employeeResult);
        }
    }
}
