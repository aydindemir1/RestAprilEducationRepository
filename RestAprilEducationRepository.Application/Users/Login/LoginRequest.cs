using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Application.Users.Login
{
    public record LoginRequest(string Email, string Password);
}
