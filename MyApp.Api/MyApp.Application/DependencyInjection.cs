﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicaitonDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
