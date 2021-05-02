using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreLineLogin
{
    public class LineOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new <see cref="LineOptions"/>.
        /// </summary>
        public LineOptions()
        {
            CallbackPath = new PathString("/signin-line");
            AuthorizationEndpoint = LineDefaults.AuthorizationEndpoint;
            TokenEndpoint = LineDefaults.TokenEndpoint;
            UserInformationEndpoint = LineDefaults.UserInformationEndpoint;
            Scope.Add("openid");
            Scope.Add("profile");

            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "userId");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "displayName");
        }

        /// <summary>
        /// access_type. Set to 'offline' to request a refresh token.
        /// </summary>
        public string AccessType { get; set; }
    }
}
