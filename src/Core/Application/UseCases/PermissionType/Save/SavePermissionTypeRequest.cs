using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.PermissionType.Save
{
    public class SavePermissionTypeRequest : IRequest<Response<SavePermissionTypeResult>>
    {
        public string Name { get; set; }
        

        public PermissionTypeDto ToPermissionTypeDto() 
        {
            return new PermissionTypeDto
            {
                Name = this.Name                
            };       
        }
    }
}
