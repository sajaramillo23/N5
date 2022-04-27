using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdRequest : IRequest<Response<DeleteUserByIdResult>>
    {
        public Guid UserId { get; set; }

        public DeleteUserByIdRequest(Guid userId)
        {
            UserId = userId;
        }
    }
}
