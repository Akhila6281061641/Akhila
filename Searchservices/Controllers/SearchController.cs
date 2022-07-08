using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Searchservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Searchservices.Controllers
{
    [Route("api/1.0/flight/Search")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        FlightDBContext dbAirline;
       
        public SearchController(FlightDBContext  _dbAirline)
        {
            dbAirline = _dbAirline;
        }
        
         [HttpGet]
         public IEnumerable<ScheduledTb> search(string fromplace,string toplace)
        {
            var data = dbAirline.ScheduledTbs;
            List<ScheduledTb> list = new List<ScheduledTb>();
            foreach(var db in data)
            {
                if(db.Fromplace== fromplace&&db.Toplace==toplace)
                {
                    list.Add(db);
                }
            }
            return list;
        }
    }
}
