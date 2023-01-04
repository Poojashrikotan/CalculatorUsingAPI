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
        Entities2 db = new Entities2();

        //Add post request
     
        public string Post(Calculator calc)
        {
            db.Calculators.Add(calc);
            db.SaveChanges();
            return "Data Added";
          

        }
      
        //Get all HistoryData
        public IEnumerable<Calculator> Get()
        {
           
            return db.Calculators.ToList();
         
        }
    }
}
