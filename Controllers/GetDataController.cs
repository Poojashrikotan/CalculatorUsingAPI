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
        Entities3 db = new Entities3();

        //Add post request

        public string Post(CalculatingData calc)
        {
            try
            {
                if (calc.firstnumber != null && calc.secondnumber != null)
                {
                    db.CalculatingDatas.Add(calc);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return "Data Added";
        }

        //Get all HistoryData
        public IEnumerable<CalculatingData> Get()
        {
               return db.CalculatingDatas.ToList();
           
        }
    }
}
