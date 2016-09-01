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
    public class NightstandController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Nightstand  Get()
        {
            Nightstand nightstand = new Nightstand { };

            if ((nightstand.Name == null) && (nightstand.Size == 0))
            {
                Log.Info("моя высота до 60см");
            }

            return nightstand;
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
