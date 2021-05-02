using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreLineLogin
{
    public static class LineDefaults
    {
        public const string AuthenticationScheme = "Line";

        public static readonly string DisplayName = "Line";

        // https://developers.line.biz/en/docs/line-login/integrate-line-login
        public static readonly string AuthorizationEndpoint = "https://access.line.me/oauth2/v2.1/authorize";

        public static readonly string TokenEndpoint = "https://api.line.me/oauth2/v2.1/token";

        // https://developers.line.biz/en/reference/social-api/#profile
        public static readonly string UserInformationEndpoint = "https://api.line.me/v2/profile";
    }
}
