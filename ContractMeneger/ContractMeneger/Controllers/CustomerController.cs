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
        CustomerService _CustomerService;

        CustomerController(CustomerService _CustomerService) { this._CustomerService = _CustomerService; }


        [HttpPost("POST/api/Customer/{FirsName}/{LastName}/{Email}/{Company}/{Location}/{Telephone}")]
        public Customer CustomerCreateController([FromRoute] string FirsName, [FromRoute] string LastName, [FromRoute] string Email, [FromRoute] string Company, [FromRoute] string Location, [FromRoute] string Telephone) // метод создания Customer
        {
            Customer _customer = new Customer { FirsName = FirsName, LastName = LastName, Email = Email, Company = Company, Location = Location, Telephone = Telephone };


            return _CustomerService.CustomerCreate(_customer);

            
        }



        [HttpPost("POST/api/Customer/{Id}/Contract")]
        public Contact ContractCreateController([FromRoute] int Id) { Customer _customer = new Customer { Id = Id };  return _CustomerService.ContractCreate(_customer); } // метод создания контракта предпологается что в дальнейшем можно будет передать полноценный Customer



        [HttpGet("GET/api/customer")]
        public IList<Customer> CustomerReadingListController() { return _CustomerService.CustomerReadingList(); } // метод чтения всей таблици Customer 


        [HttpGet("GET/api/Customer/{id}/Contract")]
       public List<Contact> ContractReagingIdOfCustomerController( [FromRoute] int Id) { return _CustomerService.ContractReagingIdOfCustomer(Id); } // метод чтнеиия контарктов по id Customer







    }
}
