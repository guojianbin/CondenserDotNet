﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CondenserDotNet.Client;
using CondenserDotNet.Middleware.TrailingHeaders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceRegistration
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        { 
            app.UseMiddleware<TrailingHeadersMiddleware>();
            app.UseMvcWithDefaultRoute();
        }
    }
}
