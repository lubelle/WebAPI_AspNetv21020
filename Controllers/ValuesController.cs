using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_ASP.NET_v2._10._20.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>
        {
            "value0", "value1", "value2"
        };
        
        public IEnumerable<string> GetFullList()
        {
            return strings;
        }

        
        public string GetValueById(int id)
        {
            return strings[id];
        }

        
        public void Post([FromBody]string value)
        {
            strings.Add(value);
            
        }

        
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
