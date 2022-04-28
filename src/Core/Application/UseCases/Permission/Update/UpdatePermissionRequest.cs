using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.Permission.Update
{
    public class UpdatePermissionRequest : IRequest<Response<UpdatePermissionResult>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }
        public PermissionDto ToPermissionDto()
        {
            return new PermissionDto()
            {                
                Id = this.Id,
                Name = this.Name,
                PermissionTypeId = this.PermissionTypeId
                
            };
        }
    }
}
