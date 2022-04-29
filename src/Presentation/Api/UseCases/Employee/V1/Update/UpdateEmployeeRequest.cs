using System;
using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.Employee.Update;

namespace N5.UseCases.Employee.V1
{
    public class UpdateEmployeeRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }        
        public string Email { get; set; }

        public R.UpdateEmployeeRequest ToUpdateEmployeeRequest()
        {
            return new R.UpdateEmployeeRequest()
            {                
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
            };
        }
    }
}
