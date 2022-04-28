using System;
using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.EmployeePermission.Update;

namespace Net_Experience.UseCases.EmployeePermission.V1
{
    public class UpdateEmployeePermissionRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }

        public R.UpdateEmployeePermissionRequest ToUpdateEmployeePermissionRequest()
        {
            return new R.UpdateEmployeePermissionRequest()
            {                
                Id = this.Id,
                EmployeeId = this.EmployeeId,
                PermissionId = this.PermissionId

            };
        }
    }
}
