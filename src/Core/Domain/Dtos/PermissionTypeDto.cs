using N5.Domain.Entities;

namespace N5.Domain.Dtos
{
    public class PermissionTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PermissionTypeDto() { }
        public PermissionTypeDto(PermissionType permissionType)
        {
            Id = permissionType.Id;
            Name = permissionType.Name;
        }

        public PermissionType ToPermissionType()
        {
            return new PermissionType
            { Id = Id, Name = Name };
        }
    }
}
