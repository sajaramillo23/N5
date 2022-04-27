using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Employee.Update
{
    public class UpdateEmployeeRequest : IRequest<Response<UpdateEmployeeResult>>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EmployeeDto ToEmployeeDto()
        {
            return new EmployeeDto()
            {                
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email
                
            };
        }
    }
}
