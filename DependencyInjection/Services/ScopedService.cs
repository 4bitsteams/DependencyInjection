using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class ScopedService : IScopedService
    {
        public string Time { get; set; }

        public ScopedService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");
        }
    }
}
