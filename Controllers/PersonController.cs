using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPerson.

namespace CalculadoraCurso.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
       
        private readonly ILogger<PersonController> _logger;

        private IPersonService _personService;


        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.findAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.findById(id);
            if(person == null) return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if(person == null) return BadRequest();
            return Ok(_personService.Create(person);
        }

        [HttpPost]
        public IActionResult Put([FromBody] Person person)
        {
            if(person == null) return BadRequest();
            return Ok(_personService.Update(person);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            if(person == null) return NotFound();
            return NoContent();
        }
        
    }
}
