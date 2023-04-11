using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SupplyOn.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }
    

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetAllPersons()
        {
            return Ok(await personService.GetAllPersons());
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Person>>> AddPerson(Person newPerson)
        {
            return Ok(await personService.AddPerson(newPerson));
        }
    }
    
}