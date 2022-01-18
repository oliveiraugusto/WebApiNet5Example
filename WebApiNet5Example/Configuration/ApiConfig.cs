using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNet5Example.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseURL { get; set; }
    }
}
