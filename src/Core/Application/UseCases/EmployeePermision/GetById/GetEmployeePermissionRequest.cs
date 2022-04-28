using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.EmployeePermission.GetById
{
    public class GetEmployeePermissionRequest : IRequest<Response<GetEmployeePermissionResult>>
    {
        public int Id { get; set; }

        public GetEmployeePermissionRequest(int id) 
        {
            Id = id;
        }
    }
}
