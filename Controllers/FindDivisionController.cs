using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatingApp.Controllers
{
    public class FindDivisionController : ApiController
    {
        [HttpGet]
        public string GetNumber(string firstnum, string secondnum)
        {
            int c = Convert.ToInt16(firstnum) / Convert.ToInt16(secondnum);
            return (c.ToString());
        }
    }
}
