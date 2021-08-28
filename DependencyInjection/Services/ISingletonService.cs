using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public interface ISingletonService
    {
        public string Time { get; set; }
    }
}
