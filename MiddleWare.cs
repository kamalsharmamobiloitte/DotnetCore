using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StartupPractise
{
    public class MiddleWare1
    {
        private readonly RequestDelegate _next;

        public MiddleWare1(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare1";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

           await _next(httpContext);
        }

    }

    public class MiddleWare2
    {
        private readonly RequestDelegate _next;

        public MiddleWare2(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare2";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

            await _next(httpContext);
        }
    }

    public class MiddleWare3
    {
        private readonly RequestDelegate _next;

        public MiddleWare3(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare3";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

            await _next(httpContext);
        }
    }

    public class MiddleWare4
    {
        private readonly RequestDelegate _next;

        public MiddleWare4(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare4";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

           await _next(httpContext);
        }
    }

    public class MiddleWare5
    {
        private readonly RequestDelegate _next;

        public MiddleWare5(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare5";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

            await _next(httpContext);
        }
    }


    public class MiddleWare6
    {
        private readonly RequestDelegate _next;

        public MiddleWare6(RequestDelegate next)
        {
            _next = next;
        }

        // Test with https://localhost:5001/Privacy/?option=Hello
        public async Task Invoke(HttpContext httpContext)
        {
            var text = "MiddleWare6";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            await httpContext.Response.Body.WriteAsync(data, 0, data.Length);

            await _next(httpContext);
        }
    }
}



