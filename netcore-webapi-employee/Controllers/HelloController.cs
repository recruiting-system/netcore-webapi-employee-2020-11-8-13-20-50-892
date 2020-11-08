using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace netcore_webapi_employee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : Controller
    {
        [HttpGet("")]
        public String HelloWorld()
        {
            return "Hello World!";
        }

        [HttpGet("{userName}")]
        public String Hello(String userName)
        {
            return "Hello " + userName;
        }
    }
}
