using N5.Domain.Entities;

namespace N5.Domain.Dtos
{
    public class EmployeePermissionDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }
        public EmployeePermissionDto() { }
        public EmployeePermissionDto(EmployeePermission employeePermission)
        {
            Id = employeePermission.Id;
            EmployeeId = employeePermission.EmployeeId; 
            PermissionId = employeePermission.PermissionId;
        }
        public EmployeePermission ToEmployeePermission()
        {
            return new EmployeePermission { Id = Id, EmployeeId = EmployeeId, PermissionId = PermissionId };
        }
    }
}
