using System.ComponentModel.DataAnnotations.Schema;

namespace N5.Domain.Entities
{
    public class EmployeePermission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }

    }
}