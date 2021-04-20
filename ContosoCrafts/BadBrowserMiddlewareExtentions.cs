using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts {
    public static class BadBrowserMiddlewareExtentions {
        public static IApplicationBuilder UseBadBrowserMiddleware(this IApplicationBuilder builder) {
            return builder.UseMiddleware<BadBrowserMiddleware>();
        }
    }
}
