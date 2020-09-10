using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleProjectSahil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesCheckController : ControllerBase
    {
        [HttpGet]
        [Route("getVal")]

        public string getdetails()
            {
            return "My FullName is Sahil Kumar Singh and I am checking code change in solution is mapping to DevOps project or not";
            }
    }
}
