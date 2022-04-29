using System;
using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.Permission.Update;

namespace N5.UseCases.Permission.V1
{
    public class UpdatePermissionRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public R.UpdatePermissionRequest ToUpdatePermissionRequest()
        {
            return new R.UpdatePermissionRequest()
            {                
                Id = this.Id,
                Name = this.Name,
                PermissionTypeId = this.PermissionTypeId
            };
        }
    }
}
