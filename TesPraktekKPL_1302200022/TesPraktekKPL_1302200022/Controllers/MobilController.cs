using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesPraktekKPL_1302200022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilController : ControllerBase
    {
        private static List<Mobil> MobilList = new List<Mobil>()
        {
            new Mobil("Toyota", "Prius", "Red"),
            new Mobil("BMW", "i7", "White"),
            new Mobil("Honda", "NSX", "Purple")
        };
        // GET: api/<MobilController>
        [HttpGet]
        public IEnumerable<Mobil> Get()
        {
            return MobilList;
        }

        // GET api/<MobilController>/5
        [HttpGet("{id}")]
        public Mobil Get(int id)
        {
            return MobilList[id];
        }

        // POST api/<MobilController>
        [HttpPost]
        public void Post([FromBody] Mobil value)
        {
            MobilList.Add(value);
        }

        // PUT api/<MobilController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MobilController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MobilList.RemoveAt(id);
        }
    }
}
