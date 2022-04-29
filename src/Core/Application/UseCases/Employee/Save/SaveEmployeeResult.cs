using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Employee.Save
{
    public class  SaveEmployeeResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public SaveEmployeeResult(EmployeeDto employeeDto) 
        {
            Id = employeeDto.Id;
            FirstName = employeeDto.FirstName;
            LastName = employeeDto.LastName;
            Email = employeeDto.Email;
        }
    }
}
