using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace filters.Utils {
    public class CustomFilterAttributesDns : ResultFilterAttribute {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next) {

            var addlist = Dns.GetHostEntry(Dns.GetHostName());
            string GetHostName = addlist.HostName.ToString();
            string GetIPV6 = addlist.AddressList[0].ToString();
            string GetIPV4 = addlist.AddressList[1].ToString();

            var result = context.Result;

            if(result is PageResult) {
                var page = ((PageResult)result);
                page.ViewData["Ipv4Address"] = GetIPV4;
                page.ViewData["Ipv6Address"] = GetIPV6;
            }
            await next.Invoke();
        }
    }
}
