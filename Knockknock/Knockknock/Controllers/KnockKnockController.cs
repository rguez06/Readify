using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RestSharp;
namespace Knockknock.Controllers
{
    public class KnockKnockController : ApiController
    {
        [HttpGet]
        [Route("api/Token")]
        public IHttpActionResult Token()
        {
            return Ok(new Guid("ab14cceb-5e4f-4a34-8f86-ab5742d36ab5"));
        }

        [HttpGet]
        [Route("api/Fibonacci")]
        public IHttpActionResult Fibonacci(int n)
        {
            Int64 result = 0;
            if (n == 0) return Ok(0);
            if (n == 1) return Ok(1);
            if (n == 2) return Ok(1);
            if (n >= 92) throw new Exception("Out of range!");
            var client = new RestClient("http://knockknock.readify.net/api/Fibonacci?n=" + n.ToString());
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "9cff5628-6d5c-48e8-5bab-7788fe91378d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            long.TryParse(response.Content.ToString(), out result);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/TriangleType")]
        public IHttpActionResult TriangleType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return Ok("Error");
            }

            if (a == b && a == c)
            {
                return Ok("Equilateral");
            }
            else if (a == b || a == c || b == c)
            {
                return Ok("Isosceles");
            }
            else
            {
                return Ok("Scalene");
            }
        }

        [HttpGet]
        [Route("api/ReverseWords")]
        public IHttpActionResult ReverseWords(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return Ok(new string(chars));
        }
    }
}
