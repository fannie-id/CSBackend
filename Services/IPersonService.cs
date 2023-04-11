using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyOn.Services
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetAllPersons();
        Task<ServiceResponse<Person>> AddPerson(Person newPerson);

    }
}