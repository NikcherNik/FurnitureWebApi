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
    public class BookcaseController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Bookcase Get()
        {

            Bookcase bookcase = new Bookcase { };
            
            if((bookcase.Name == null) && (bookcase.Size == 0) && (bookcase.ShelvesCount == 0)){
                Log.Info("до 200см высотой шкафы");
            }
            return bookcase;
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
