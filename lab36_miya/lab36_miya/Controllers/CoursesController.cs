using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab36_miya.Controllers
{
    //below is a route token inside of attribute routing - curly braces make the routing more dynamic
    [Route("api/{controller}")]
    //we are using ControllerBase instead of Controller here because this will not be a front-facing app
    public class CoursesController : ControllerBase
    {
        public CoursesController(lab36_miyaDbContext context)
        {

        }

        //Get
        [HttpGet]
        public IActionResult Get()
        {

        }

        //Post

        //Put

        //Delete
    }
}
