using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Controllers
{
    [Route("di")]
    public class DIController : Controller
    {
        private readonly ISingletonService _singletonSrvice;
        private readonly IScopedService _scopedService;
        private readonly ITraisientService _traisientService;
        //public DIController(ISingletonService singletonSrvice,
        //    IScopedService scopedService,
        //    ITraisientService traisientService)
        //{
        //    _singletonSrvice = singletonSrvice;
        //    _scopedService = scopedService;
        //    _traisientService = traisientService;
        //}

        public DIController(IServiceProvider serviceProvider)
        {
            _singletonSrvice = serviceProvider.GetRequiredService<ISingletonService>();
            _scopedService = serviceProvider.GetRequiredService<IScopedService>();
            _traisientService = serviceProvider.GetRequiredService<ITraisientService>();
        }
        public IActionResult Index()
        {
            var model = new DIModel()
            {
                ScopedTime = _scopedService.Time,
                SingletonTime = _singletonSrvice.Time,
                TransientTime = _traisientService.Time

            };
            return View(model);
        }
    }
}
