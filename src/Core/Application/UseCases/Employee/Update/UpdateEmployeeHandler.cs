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
            await ValidateExistEmployeeAsync(request);

            var employeeDto = await _employeeService.UpdateAsync(request.ToEmployeeDto());

            var employeeResult = new UpdateEmployeeResult(employeeDto);

            return new Response<UpdateEmployeeResult>(employeeResult);
        }

        private async Task ValidateExistEmployeeAsync(UpdateEmployeeRequest request)
        {
            var employeeEntity = await _employeeService.GetAsync(request.Id);

            if (employeeEntity is null)
            {
                throw new NotFoundException(MessageGeneral.DontExist);
            }
        }
    }
}
