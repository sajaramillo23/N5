using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Permission.GetById
{
    public class GetPermissionResult 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public GetPermissionResult(PermissionDto dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            PermissionTypeId = dto.PermissionTypeId;
        }
    }
}
