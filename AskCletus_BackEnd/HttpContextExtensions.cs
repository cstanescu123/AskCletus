using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskCletus_BackEnd
{
    public static class HttpContextExtensions
    {
        public static async Task<IEnumerable<string>> GetExternalProvidersAsync(this HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var schemes = context.RequestServices.GetRequiredService<IAuthenticationSchemeProvider>();

            return (await schemes.GetAllSchemesAsync())
                .Where(scheme => !string.IsNullOrEmpty(scheme.DisplayName))
                .Select(scheme => scheme.Name);

        }

        public static async Task<bool> IsProviderSupportedAsync(this HttpContext context, string provider)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            return (await context.GetExternalProvidersAsync())
                .Where(scheme => string.Equals(scheme, provider, StringComparison.OrdinalIgnoreCase))
                .Any();
        }
    }
}