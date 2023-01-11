using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatingApp.Controllers
{
    public class FindSumController : ApiController
    {
        [HttpGet]
        public string GetNumber(string  firstnumber, string secondnumber)
        {
            Double res = 0;
            try
            {
                 res = Convert.ToDouble(firstnumber) + Convert.ToDouble(secondnumber);
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (res.ToString());
        }

    }
}
