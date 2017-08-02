using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FestPay.Web.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/values
        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult("");
            //return new string[] { "value1", "value2" };
            // http://[url]/api/[controller/action -> http://azure.com/api/test/get/17
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("randomAction")]
        [HttpGet("{id}")]
        public string GetRandom(int id)
        {
            // http://[url]/api/[controller/randomAction -> http://azure.com/api/test/randomAction/17
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
