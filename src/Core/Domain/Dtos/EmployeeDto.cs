using N5.Domain.Entities;

namespace N5.Domain.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public EmployeeDto() { }
        public EmployeeDto(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Email = employee.Email;
        }

        public Employee ToEmployee()
        {
            return new Employee {Id=Id ,Email = Email, FirstName = FirstName, LastName = LastName };
        }
    }
}
