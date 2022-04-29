using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Employee.Update
{
    public class UpdateEmployeeResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public UpdateEmployeeResult(EmployeeDto employeeDto)
        {
            Id = employeeDto.Id;
            FirstName = employeeDto.FirstName;
            LastName = employeeDto.LastName;
            Email = employeeDto.Email;
        }
    }
}
