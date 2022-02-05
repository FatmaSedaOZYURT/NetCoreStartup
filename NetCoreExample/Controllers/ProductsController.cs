using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Controllers
{
    [Route("Products")]
    public class ProductsController : ControllerBase
    {
        [Route("Merhaba")]
        public string Merhaba()
        {
            return "Merhaba";
        }
        [Route("Hello")]
        public string Hello()
        {
            return "Hello";
        }
    }
}
