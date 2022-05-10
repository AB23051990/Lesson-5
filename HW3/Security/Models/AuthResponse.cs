using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW3.Security
{
    public class AuthResponse
    {
        public string Password { get; set; }

        public RefreshToken LatestRefreshToken { get; set; }
    }
}
