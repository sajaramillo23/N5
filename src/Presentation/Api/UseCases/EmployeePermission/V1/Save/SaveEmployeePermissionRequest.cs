using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.EmployeePermission.Save;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public class SaveEmployeePermissionRequest
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int PermissionId { get; set; }

        public R.SaveEmployeePermissionRequest ToSaveEmployeePermissionRequest()
        {
            return new R.SaveEmployeePermissionRequest()
            {
                EmployeeId = EmployeeId,
                PermissionId = PermissionId
            };
        }
    }
}
