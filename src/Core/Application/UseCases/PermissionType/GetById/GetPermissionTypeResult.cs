using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.PermissionType.GetById
{
    public class GetPermissionTypeResult 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public GetPermissionTypeResult(PermissionTypeDto dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            
        }
    }
}
