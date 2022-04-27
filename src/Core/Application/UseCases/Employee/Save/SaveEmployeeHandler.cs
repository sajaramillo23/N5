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

        public SaveEmployeeHandler(IEmployeeService itemService)
        {
            employeeService = itemService;
        }
        public async Task<Response<SaveEmployeeResult>> Handle(SaveEmployeeRequest request, CancellationToken cancellationToken)
        {
           var item = await employeeService.SaveAsync(request.ToEmployeeDto());

            var itemResult = new SaveEmployeeResult(item);

            return new Response<SaveEmployeeResult>(itemResult);
        }
    }
}
