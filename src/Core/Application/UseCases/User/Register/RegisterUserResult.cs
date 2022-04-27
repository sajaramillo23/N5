using N5.Domain.Dtos;

namespace N5.Application.UseCases.User.Register
{
    public class RegisterUserResult
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public RegisterUserResult(UserDto userDto)
        {
            UserName = userDto.UserName;
            Email = userDto.Email;
        }
    }
}
