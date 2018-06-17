using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Polygon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get(int matricula, double valorHora, double horasTrabalhadas)
        {
            Funcionario f = new Funcionario(matricula, valorHora, horasTrabalhadas);
            Calculo calc = new Calculo(f);

            double SalarioBruto = calc.CalcularSalarioBruto(f.ValorHora, f.HorasTrabalhadas);

            return new string[] { "value" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
