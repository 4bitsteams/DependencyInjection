using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class TTraisientService : ITraisientService
    {
        public string Time { get; set; }

        public TTraisientService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");
        }
    }
}
