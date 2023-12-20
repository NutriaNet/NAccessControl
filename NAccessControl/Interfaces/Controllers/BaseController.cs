using Microsoft.AspNetCore.Http;
using NAccessControl.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NAccessControl.Interfaces.Controllers
{
    public class BaseController
    {
        public static IHttpContextAccessor? httpContextAccessor;

        public static HttpContext? GetContext() => httpContextAccessor?.HttpContext;

        public string? GetRoleId()
        {
            return GetValueByClaimTypes(ClaimTypes.Role);
        }

        public string? GetUserId()
        {
            return GetValueByClaimTypes(ClaimTypes.NameIdentifier);
        }

        private string? GetValueByClaimTypes(string claimTypes)
        {
            var userClaims = GetContext()?.User.Claims;
            var claim = userClaims?.FirstOrDefault(c => c.Type == claimTypes);
            if (claim == null)
            {
                return null;
            }
            return claim?.Value;
        }
    }
}
