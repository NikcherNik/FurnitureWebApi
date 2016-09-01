using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FurnitureWebApi.Models;
using log4net;

namespace FurnitureWebApi.Controllers
{
    public class TableController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Table Get()
        {
            Table table = new Table { };

            if((table.Name == null) && (table.Size == 0)){
                Log.Info("моя высота до 60см");
            }
            return table;
        }

        
        public string Get(int id)
        {
            return "value";
        }

        
        public void Post([FromBody]string value)
        {
        }

        
        public void Put(int id, [FromBody]string value)
        {
        }

        
        public void Delete(int id)
        {
        }
    }
}
