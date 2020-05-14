using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SwaggerRMQTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleValuesController : ControllerBase
    {
        public SampleValuesController()
        {
            SampleValues.Init();
        }

        [HttpGet]
        public ActionResult<List<string>> Get()
        {
            return SampleValues.Values;
        }

        [HttpGet("{value}")]
        public ActionResult<bool> Get(string value)
        {
            return SampleValues.Values.Contains(value);
        }

        [HttpPost]
        public void Post(string value)
        {
            SampleValues.Values.Add(value);
        }


        [HttpDelete("{value}")]
        public void Delete(string value)
        {
            SampleValues.Values.Remove(value);
        }
    }
}
