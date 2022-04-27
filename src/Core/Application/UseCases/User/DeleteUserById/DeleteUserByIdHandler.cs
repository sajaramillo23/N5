using MediatR;
using N5.Application.Exceptions;
using N5.Common.Helpers;
using N5.Domain.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdHandler : IRequestHandler<DeleteUserByIdRequest, Response<DeleteUserByIdResult>>
    {
        private readonly IUserService _userService;
        public DeleteUserByIdHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<Response<DeleteUserByIdResult>> Handle(DeleteUserByIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Dtos.UserDto userDto = await ValidateUserExistAsync(request);

            await _userService.DeleteUserAysnc(userDto);

            return new Response<DeleteUserByIdResult>(new DeleteUserByIdResult(userDto));
        }

        private async Task<Domain.Dtos.UserDto> ValidateUserExistAsync(DeleteUserByIdRequest request)
        {
            var userDto = await _userService.GetUserAysnc(request.UserId);

            if (userDto == null)
            {
                throw new NotFoundException(MessageGeneral.NotFound, MessageGeneral.DontExist);
            }

            return userDto;
        }
    }
}
