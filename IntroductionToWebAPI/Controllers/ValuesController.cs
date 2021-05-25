using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroductionToWebAPI.Controllers
{
    // Routing System
    // Localhost/api/data
    // API => https://localhost:44356/api/data => Not Values
    [Route("api/data")]
    public class ValuesController : ApiController
    {
        // https://localhost:44356/api/values/archive/2020/10/20
        [HttpGet]
        public HttpResponseMessage Archive(int year, int month, int day)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // GET api/values
        // API => https://localhost:44356/api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        // API => https://localhost:44356/api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // befor Route API => https://localhost:44356/api/values/AddCustomer
        [Route("api/data/AddCustomer")]
        // after Route API => https://localhost:44356/api/data/AddCustomer
        [HttpPost]
        public void AddCustomer()
        {

        }
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
