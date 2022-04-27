﻿using MediatR;
using N5.Common.Helpers;
using N5.Domain.Dtos;

namespace N5.Application.UseCases.User.Register
{
    public class RegisterUserRequest : IRequest<Response<RegisterUserResult>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string IdentificationDocument { get; set; }

        public UserDto ToUserDto()
        {
            return new UserDto()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                UserName = this.UserName,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                Password = this.Password,
                IdentificationDocument = this.IdentificationDocument
            };
        }
    }
}
