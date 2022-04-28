using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.EmployeePermission.Save
{
    public class SaveEmployeePermissionRequest : IRequest<Response<SaveEmployeePermissionResult>>
    {
        public int EmployeeId { get; set; }
        public int PermissionId { get; set; }

        public EmployeePermissionDto ToEmployeePermissionDto() 
        {
            return new EmployeePermissionDto
            {
                EmployeeId = EmployeeId,    
                PermissionId = PermissionId
            };       
        }
    }
}
