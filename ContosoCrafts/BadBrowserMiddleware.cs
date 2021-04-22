using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts {
    public class BadBrowserMiddleware {
        private readonly RequestDelegate _next;
        public BadBrowserMiddleware(RequestDelegate next) {
            this._next = next;
        }
        public Task Invoke(HttpContext context, IBrowserDetector browserDetector) {
            var browser = browserDetector.Browser;
            List<string> browsers = new List<string>();
            browsers.Add(BrowserNames.Edge);
            browsers.Add(BrowserNames.EdgeChromium);
            browsers.Add(BrowserNames.InternetExplorer);
            if(browsers.Contains<string>(browser.Name)) 
                context.Response.WriteAsync("Przegladarka nie jest obslugiwana");
            return _next(context);
        }
    }
}
