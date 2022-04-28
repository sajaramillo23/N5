using System;
using System.ComponentModel.DataAnnotations;
using R = N5.Application.UseCases.PermissionType.Update;

namespace Net_Experience.UseCases.PermissionType.V1
{
    public class UpdatePermissionTypeRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public R.UpdatePermissionTypeRequest ToUpdatePermissionTypeRequest()
        {
            return new R.UpdatePermissionTypeRequest()
            {                
                Id = this.Id,
                Name = this.Name
                
            };
        }
    }
}
