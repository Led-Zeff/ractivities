using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAction() {
            return new[] {"Value 1", "Value 2", "Value 3"};
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetAction(int id) {
            return "Value " + id;
        }

        [HttpPost]
        public void Post([FromBody] string value) {

        }
    }
}