using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupPractise
{
    public class StartupFilter1 : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<MiddleWare1>();
                builder.UseMiddleware<MiddleWare6>();
                next(builder);
            };

        }
    }
    public class StartupFilter2 : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<MiddleWare2>();
                next(builder);
            };
        }
    }
}
