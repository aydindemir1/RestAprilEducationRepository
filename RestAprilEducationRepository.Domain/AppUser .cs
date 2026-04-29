using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAprilEducationRepository.Domain
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? City { get; set; }

        public UserDetail UserDetail { get; set; }
    }
}
