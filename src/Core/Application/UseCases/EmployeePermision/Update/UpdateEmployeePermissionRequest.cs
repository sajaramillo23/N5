using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.EmployeePermission.Update
{
    public class UpdateEmployeePermissionRequest : IRequest<Response<UpdateEmployeePermissionResult>>
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }
        public EmployeePermissionDto ToEmployeePermissionDto()
        {
            return new EmployeePermissionDto()
            {                
                Id = this.Id,
                EmployeeId = this.EmployeeId,
                PermissionId = this.PermissionId
                
            };
        }
    }
}
