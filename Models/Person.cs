using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyOn.Models
{
    public class Person
    {
        //The Person table should contain the following fields: "PersonId, FirstName, LastName, Age".
        public int PersonId { get; set; }
        public string FirstName { get; set;} = "";
        public string LastName { get; set;} = "";
        public int Age { get; set;}
    }
}