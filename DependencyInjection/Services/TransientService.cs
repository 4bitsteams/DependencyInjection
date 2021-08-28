using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class TraisientService : ITraisientService
    {
        public string Time { get; set; }

        public TraisientService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");
        }
    }
}
