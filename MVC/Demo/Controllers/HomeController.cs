/* Role of a controller - 
    - work with user input / browser request
    - handling incoming request and provide data to corresponding view or browser request.
    - 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello, this my first app";
        }
        
        public string Name()
        {
            return "My name is Odysseus";
        }
    }
}