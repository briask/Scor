using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MatchEvents.Controllers
{
    public class MatchEventController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}
