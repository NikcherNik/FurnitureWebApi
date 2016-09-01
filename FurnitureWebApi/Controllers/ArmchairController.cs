using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using FurnitureWebApi.Models;
using log4net;

namespace FurnitureWebApi.Controllers
{
    public class ArmchairController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Armchair GetArmchair()
        {
            Armchair armchair = new Armchair { Name = "Офисное кресло", Size = 40};

            if ((armchair.Name == null) && (armchair.Size == 0))
            {
                Log.Info("Нет данных");
            }

            return armchair;
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
