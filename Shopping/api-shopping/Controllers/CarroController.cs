using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        // GET: api/<CarroController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public IActionResult Post([FromBody] Models.Carro value)
        {
            using (SqliteConnection conn = new SqliteConnection("Data Source=garagem.db"))
            {
                conn.Open();

                string insert = $"insert into carro (name) values ('{value.Name}')";
                SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
            }

            return Ok();
        }

        // PUT api/<CarroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
