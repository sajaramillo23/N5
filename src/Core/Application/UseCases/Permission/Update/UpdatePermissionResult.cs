using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Permission.Update
{
    public class UpdatePermissionResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public UpdatePermissionResult(PermissionDto itemDto)
        {
            Id = itemDto.Id;
            Name = itemDto.Name;
            PermissionTypeId = itemDto.PermissionTypeId;
        }
    }
}
