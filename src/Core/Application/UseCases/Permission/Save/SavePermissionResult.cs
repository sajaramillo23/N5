using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Permission.Save
{
    public class  SavePermissionResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public SavePermissionResult(PermissionDto itemDto) 
        {
            Id = itemDto.Id;
            Name = itemDto.Name;
            PermissionTypeId = itemDto.PermissionTypeId;
        }
    }
}
