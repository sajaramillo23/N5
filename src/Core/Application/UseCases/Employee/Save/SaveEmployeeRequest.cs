using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.Employee.Save
{
    public class SaveEmployeeRequest : IRequest<Response<SaveEmployeeResult>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
                
        public EmployeeDto ToEmployeeDto() 
        {
            return new EmployeeDto
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email
            };       
        }
    }
}
