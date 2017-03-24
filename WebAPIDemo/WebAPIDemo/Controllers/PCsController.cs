using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class PCsController : ApiController
    {
        // GET: api/PCs
        public IEnumerable<string> Get()
        {
            return new string[] { "Pc1", "Pc2" };
        }

        // GET: api/PCs/5
        public string Get(int id)
        {
            return "Some Pc";
        }

        // POST: api/PCs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PCs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PCs/5
        public void Delete(int id)
        {
        }
    }
}
