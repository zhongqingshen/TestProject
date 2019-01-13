using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public IAcationResult Get()
        {
            return View();
        }
    }
}
