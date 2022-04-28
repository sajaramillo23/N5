using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.PermissionType.Update
{
    public class UpdatePermissionTypeRequest : IRequest<Response<UpdatePermissionTypeResult>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public PermissionTypeDto ToPermissionTypeDto()
        {
            return new PermissionTypeDto()
            {                
                Id = this.Id,
                Name = this.Name                
                
            };
        }
    }
}
