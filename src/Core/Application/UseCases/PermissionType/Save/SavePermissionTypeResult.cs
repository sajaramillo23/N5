using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.PermissionType.Save
{
    public class  SavePermissionTypeResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public SavePermissionTypeResult(PermissionTypeDto itemDto) 
        {
            Id = itemDto.Id;
            Name = itemDto.Name;            
        }
    }
}
