using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("di")]
    public class DIController : Controller
    {
        private readonly ISingletonService _singletonSrvice;
        private readonly IScopedService _scopedService;
        private readonly ITraisientService _traisientService;
        public DIController(ISingletonService singletonSrvice, 
            IScopedService scopedService, 
            ITraisientService traisientService)
        {
            _singletonSrvice = singletonSrvice;
            _scopedService = scopedService;
            _traisientService = traisientService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
