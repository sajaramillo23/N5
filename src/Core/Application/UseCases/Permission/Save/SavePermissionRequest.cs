using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.Permission.Save
{
    public class SavePermissionRequest : IRequest<Response<SavePermissionResult>>
    {
        public string Name { get; set; }
        public int PermissionTypeId { get; set; }

        public PermissionDto ToPermissionDto() 
        {
            return new PermissionDto
            {
                Name = this.Name,
                PermissionTypeId = this.PermissionTypeId,
            };       
        }
    }
}
