using N5.Domain.Entities;

namespace N5.Domain.Dtos
{
    public class PermissionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public PermissionDto() { }
        public PermissionDto(Permission permission)
        {
            Id = permission.Id;
            Name = permission.Name;
            PermissionTypeId = permission.PermissionTypeId;
        }
        public Permission ToPermission() { 
            return new Permission { Id = Id, Name = Name, PermissionTypeId = PermissionTypeId };
        }
    }
}
