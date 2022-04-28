using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.Permission.Save;

namespace Net_Experience.UseCases.Permission.V1
{
    public class SavePermissionRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int PermissionTypeId { get; set; }

        public R.SavePermissionRequest ToSavePermissionRequest()
        {
            return new R.SavePermissionRequest()
            {
                Name = this.Name,
                PermissionTypeId = this.PermissionTypeId,
            };
        }
    }
}
