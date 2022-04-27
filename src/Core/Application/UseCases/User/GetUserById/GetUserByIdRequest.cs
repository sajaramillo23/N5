using MediatR;
using N5.Common.Helpers;
using System;

namespace N5.Application.UseCases.User.GetUserById
{
    public class GetUserByIdRequest : IRequest<Response<GetUserByIdResult>>
    {
        public Guid UserId { get; set; }

        public GetUserByIdRequest(Guid userId)
        {
            UserId = userId;
        }
    }
}
