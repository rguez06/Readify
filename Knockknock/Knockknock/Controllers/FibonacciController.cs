using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;
namespace Knockknock.Controllers
{
    public class FibonacciController : ApiController
    {
        // GET: api/Fibonacci
        public int Get()
        {
            return 0;
        }

        // GET: api/Fibonacci/5
        public long Get(int n)
        {
            long result = 0;
            var client = new RestClient("http://knockknock.readify.net/api/Fibonacci?n=" + n.ToString());
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "9cff5628-6d5c-48e8-5bab-7788fe91378d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            long.TryParse(response.Content.ToString(), out result);
            return result;
        }

        // POST: api/Fibonacci
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fibonacci/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fibonacci/5
        public void Delete(int id)
        {
        }
    }
}
