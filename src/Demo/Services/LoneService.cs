﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.ServiceRegistration.Dynamic.Interfaces;

namespace Demo.Services
{
    public class LoneService : IScopedService
    {
        public string GetString()
        {
            return "Hello! I am tanvir";
        }
    }
}
