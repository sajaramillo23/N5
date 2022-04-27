using MediatR;
using N5.Application.Exceptions;
using N5.Common.Helpers;
using N5.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.User.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdRequest, Response<GetUserByIdResult>>
    {
        private readonly IUserService _userService;

        public GetUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Response<GetUserByIdResult>> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
           var userDto =  await _userService.GetUserAysnc(request.UserId);

            if(userDto == null) 
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            return new Response<GetUserByIdResult>(new GetUserByIdResult(userDto));
        }
    }
}
