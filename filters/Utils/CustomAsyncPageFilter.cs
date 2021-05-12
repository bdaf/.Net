﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filters.Utils {
    public class CustomAsyncPageFilter : IAsyncPageFilter {
        private readonly IConfiguration _config;

        public CustomAsyncPageFilter(IConfiguration config) {
            _config = config;
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context) {
            //var key = _config["UserAgentID"];
            //context.HttpContext.Request.Headers.TryGetValue("user-agent",
            //                                                out StringValues value);
            //ProcessUserAgent.Write(context.ActionDescriptor.DisplayName,
            //                       "SampleAsyncPageFilter.OnPageHandlerSelectionAsync",
            //                       value, key.ToString());

            return Task.CompletedTask;
        }

        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context,
                                                      PageHandlerExecutionDelegate next) {
            // Do post work.
            await next.Invoke();
        }
    }
}

