using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.Employee.Save;

namespace Net_Experience.UseCases.Employee.V1
{
    public class SaveEmployeeRequest
    {
        [Required]        
        public string FirstName { get; set; }
        [Required]        
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public R.SaveEmployeeRequest ToSaveEmployeeRequest()
        {
            return new R.SaveEmployeeRequest()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email
            };
        }
    }
}
