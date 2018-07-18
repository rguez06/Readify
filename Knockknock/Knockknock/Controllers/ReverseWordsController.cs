using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;

namespace Knockknock.Controllers
{
    public class ReverseWordsController : ApiController
    {
        // GET: api/ReverseWords
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ReverseWords/5
        public string Get(string sentence)
        {
            string result = string.Empty;
            var client = new RestClient("http://knockknock.readify.net/api/ReverseWords?sentence=" + sentence.Trim());
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "9cff5628-6d5c-48e8-5bab-7788fe91378d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            
            return response.Content.ToString();
        }

        // POST: api/ReverseWords
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ReverseWords/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ReverseWords/5
        public void Delete(int id)
        {
        }
    }
}
