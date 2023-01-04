using CalculatingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CalculatingApp.Controllers
{
    public class GetDataController : ApiController
    {
        Entities1 db = new Entities1();
       
        //Add post request
        public string Post(Calculation calc)
        {
            db.Calculations.Add(calc);
            db.SaveChanges();
            return "Data Added";

        }
        //Get all HistoryData
        public IEnumerable<Calculation> Get()
        {
           
            return db.Calculations.ToList();
         
        }
    }
}
