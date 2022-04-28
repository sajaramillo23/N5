using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.PermissionType.Save;

namespace Net_Experience.UseCases.PermissionType.V1
{
    public class SavePermissionTypeRequest
    {
        [Required]
        public string Name { get; set; }
        

        public R.SavePermissionTypeRequest ToSavePermissionTypeRequest()
        {
            return new R.SavePermissionTypeRequest()
            {
                Name = this.Name
                
            };
        }
    }
}
