using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreLineLogin
{
    public static class LineExtension
    {
        public static AuthenticationBuilder AddLine(this AuthenticationBuilder builder)
            => builder.AddLine(LineDefaults.AuthenticationScheme, _ => { });

        public static AuthenticationBuilder AddLine(this AuthenticationBuilder builder, Action<LineOptions> configureOptions)
            => builder.AddLine(LineDefaults.AuthenticationScheme, configureOptions);

        public static AuthenticationBuilder AddLine(this AuthenticationBuilder builder, string authenticationScheme, Action<LineOptions> configureOptions)
            => builder.AddLine(authenticationScheme, LineDefaults.DisplayName, configureOptions);

        public static AuthenticationBuilder AddLine(this AuthenticationBuilder builder, string authenticationScheme, string displayName, Action<LineOptions> configureOptions)
            => builder.AddOAuth<LineOptions, LineHandler>(authenticationScheme, displayName, configureOptions);
    }
}
