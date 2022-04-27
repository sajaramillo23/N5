using N5.Domain.Dtos;

namespace N5.Application.UseCases.User.DeleteUserById
{
    public class DeleteUserByIdResult
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DeleteUserByIdResult(UserDto userDto)
        {
            this.UserName = userDto.UserName;
            this.Email = userDto.Email;
        }
    }
}
