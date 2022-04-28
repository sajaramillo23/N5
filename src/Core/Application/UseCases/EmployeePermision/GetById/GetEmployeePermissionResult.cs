using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.EmployeePermission.GetById
{
    public class GetEmployeePermissionResult 
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }

        public GetEmployeePermissionResult(EmployeePermissionDto dto)
        {
            Id = dto.Id;
            EmployeeId = dto.EmployeeId;
            PermissionId = dto.PermissionId;

        }
    }
}
