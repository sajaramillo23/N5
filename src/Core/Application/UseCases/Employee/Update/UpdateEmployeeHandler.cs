using MediatR;
using N5.Application.Exceptions;
using N5.Domain.Interfaces.Services;
using N5.Common.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.Employee.Update
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeRequest, Response<UpdateEmployeeResult>>
    {
        private readonly IEmployeeService _employeeService;

        public UpdateEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<Response<UpdateEmployeeResult>> Handle(UpdateEmployeeRequest request, CancellationToken cancellationToken)
        {
            await ValidateExistItemAsync(request);

            var item = await _employeeService.UpdateAsync(request.ToEmployeeDto());

            var itemResult = new UpdateEmployeeResult(item);

            return new Response<UpdateEmployeeResult>(itemResult);
        }

        private async Task ValidateExistItemAsync(UpdateEmployeeRequest request)
        {
            var itemEntity = await _employeeService.GetAsync(request.Id);

            if (itemEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
