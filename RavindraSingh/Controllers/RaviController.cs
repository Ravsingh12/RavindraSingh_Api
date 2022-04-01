using RavindraSingh.DB_Contex;
using RavindraSingh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RavindraSingh.Controllers
{
    public class RaviController : ApiController
    {
        [HttpGet]
        
        [Route("Ravi/GetEmployee")]
           public List<EMP_Entry> GetRavi()
           {

            List<EMP_Entry> ListRavi = new List<EMP_Entry>();
            Emp_DetailsEntities obj1 = new Emp_DetailsEntities();
            var res = obj1.EMP_Entry.ToList();
            
        
               return res;
             }
        [HttpPost]
        public HttpResponseMessage saveRavi(EMP_Entry tab)
        {
            Emp_DetailsEntities obj1 = new Emp_DetailsEntities();
            EMP_Entry obj = new EMP_Entry();
            if (tab.Id == 0)
            {
                obj1.EMP_Entry.Add(tab);
                obj1.SaveChanges();
            }
            else
            {
                obj1.Entry(tab).State = System.Data.Entity.EntityState.Modified;
                obj1.SaveChanges();

            }

            HttpResponseMessage res = new HttpResponseMessage(HttpStatusCode.OK);
            return res;


        }
        
        

    }
}