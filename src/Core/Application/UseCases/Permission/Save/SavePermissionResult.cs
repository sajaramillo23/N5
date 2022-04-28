using N5.Application.Abstractions;
using N5.Application.UseCases.Permission.GetById;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Permission.Save
{
    public class  SavePermissionResult: SearchResult
    {
        public int Id { get; set; }        
        public int PermissionTypeId { get; set; }

        public SavePermissionResult(PermissionDto itemDto) 
        {
            Id = itemDto.Id;
            Name = itemDto.Name;
            PermissionTypeId = itemDto.PermissionTypeId;
        }

        public GetPermissionResult ToGetPermissionResult()
        {
            return new GetPermissionResult
            {
                Id = this.Id,
                PermissionTypeId = this.PermissionTypeId,
                Name = this.Name
            };
        }
    }
}
