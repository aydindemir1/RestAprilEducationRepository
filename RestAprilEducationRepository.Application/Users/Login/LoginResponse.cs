using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Application.Users.Login
{
    public record LoginResponse(string Token, DateTime Expiration);
}
