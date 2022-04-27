using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Employee.GetById
{
    public class GetEmployeeResult 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public GetEmployeeResult(EmployeeDto dto)
        {
            Id = dto.Id;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            Email = dto.Email;

        }
    }
}
