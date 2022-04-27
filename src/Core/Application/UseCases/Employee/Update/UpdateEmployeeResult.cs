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

        public UpdateEmployeeResult(EmployeeDto itemDto)
        {
            Id = itemDto.Id;
            FirstName = itemDto.FirstName;
            LastName = itemDto.LastName;
            Email = itemDto.Email;
        }
    }
}
