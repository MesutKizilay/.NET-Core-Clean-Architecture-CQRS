﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Encryption
{
    internal static class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey) =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
}