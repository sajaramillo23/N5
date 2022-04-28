using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.EmployeePermission.Update
{
    public class UpdateEmployeePermissionResult
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }

        public UpdateEmployeePermissionResult(EmployeePermissionDto itemDto)
        {
            Id = itemDto.Id;
            EmployeeId = itemDto.EmployeeId;    
            PermissionId = itemDto.PermissionId;
        }
    }
}
