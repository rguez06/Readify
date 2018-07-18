using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;

namespace Knockknock.Controllers
{
    public class TriangleTypeController : ApiController
    {
        // GET: api/TriangleType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TriangleType/5
        public string Get(int a, int b, int c)
        {
            string result = string.Empty;
            var client = new RestClient(string.Format("http://knockknock.readify.net/api/TriangleType?a={0}&b={1}&c={2}", a.ToString(), b.ToString(), c.ToString()));
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "9cff5628-6d5c-48e8-5bab-7788fe91378d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);


            return response.Content.ToString();
        }

        // POST: api/TriangleType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TriangleType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TriangleType/5
        public void Delete(int id)
        {
        }
    }
}
