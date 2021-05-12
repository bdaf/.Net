using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filters.Utils {
    public class CustomFilterAttributes : ResultFilterAttribute {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next) { 
            var result = context.Result;

            if(result is PageResult) {
                var page = ((PageResult)result);
                page.ViewData["Ipv4Address"] = context.HttpContext.Connection.LocalIpAddress.MapToIPv4();
                page.ViewData["Ipv6Address"] = context.HttpContext.Connection.RemoteIpAddress.MapToIPv6();
            }
            await next.Invoke();
        }
    }
}
