using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.PermissionType.GetById
{
    public class GetPermissionTypeRequest : IRequest<Response<GetPermissionTypeResult>>
    {
        public int Id { get; set; }

        public GetPermissionTypeRequest(int id) 
        {
            Id = id;
        }
    }
}
