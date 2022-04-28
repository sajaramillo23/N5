using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.Permission.GetById
{
    public class GetPermissionRequest : IRequest<Response<GetPermissionResult>>
    {
        public int Id { get; set; }

        public GetPermissionRequest(int id) 
        {
            Id = id;
        }
    }
}
