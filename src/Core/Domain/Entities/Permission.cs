using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace N5.Domain.Entities
{
    public class Permission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }
        public ICollection<EmployeePermission> EmployeePermissions { get; set; }

    }
}
