using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        public string Time { get; set; }

        public SingletonService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");
        }
    }
}
