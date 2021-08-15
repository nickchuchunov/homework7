using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractMeneger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace ContractMeneger.Controllers
{
    [Route("api/CustomerController/")]
    public class CustomerController : Controller // Не все реализованы методы CRUD - Update и Delete будут реализованы в соответсвии с потребностями приложения
    {

       


        [HttpPost("POST/api/Customer/{FirsName}/{LastName}/{Email}/{Company}/{Location}/{Telephone}")]
        public Customer CustomerCreate([FromRoute] string FirsName, [FromRoute] string LastName, [FromRoute] string Email, [FromRoute] string Company, [FromRoute] string Location, [FromRoute] string Telephone) // метод создания Customer
        {
            Customer _customer = new Customer { FirsName = FirsName, LastName = LastName, Email = Email, Company = Company, Location = Location, Telephone = Telephone };

            return _customer;
        }



        [HttpPost("POST/api/Customer/{Id}/Contract")]
        public Contact ContractCreate([FromRoute] int Id) { return new Contact { CustomerID = Id }; } // метод создания контракта



        [HttpGet("GET/api/customer")]
        public IList<Customer> CustomerReadingList() { return new List<Customer>(); } // метод чтения всей таблици Customer 


        [HttpGet("GET/api/Customer/{id}/Contract")]
       public List<Contact> ContractReagingIdOfCustomer( [FromRoute] int Id) { return new List<Contact>(); } // метод чтнеиия контарктов по id Customer







    }
}
