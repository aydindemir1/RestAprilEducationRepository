using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Application.Users.Create
{
    public record CreateUserRequest(string UserName, string Email, string Password);
}
