using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SupplyOn.Services
{
    public class PersonService : IPersonService
    {
        private readonly DataContext context;

        public PersonService(DataContext context)
        {
            this.context = context;
            
        }
        public async Task<ServiceResponse<List<Person>>> GetAllPersons(){

            var serviceResponse = new ServiceResponse<List<Person>>();
            var dbPersons= await context.Persons.ToListAsync();

            serviceResponse.Data = dbPersons;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Person>> AddPerson(Person newPerson)
        {

            var serviceResponse = new ServiceResponse<Person>();
            context.Add<Person>(newPerson);
            await context.SaveChangesAsync();
            serviceResponse.Data = newPerson;
            return serviceResponse;
        }
    }
}