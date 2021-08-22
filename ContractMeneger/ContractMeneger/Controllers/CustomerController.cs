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
        public void CustomerCreateController([FromRoute] string FirsName, [FromRoute] string LastName, [FromRoute] string Email, [FromRoute] string Company, [FromRoute] string Location, [FromRoute] string Telephone) // метод создания Customer
        {
            CustomerDatabase _customer = new CustomerDatabase { FirsName = FirsName, LastName = LastName, Email = Email, Company = Company, Location = Location, Telephone = Telephone };


             _CustomerService.CustomerCreate(_customer);

            
        }



        [HttpPost("POST/api/Customer/{Id}/Contract")]
        public void ContractCreateController([FromRoute] int Id) { CustomerDatabase _customer = new CustomerDatabase { Id = Id };   _CustomerService.ContractCreate(_customer); } // метод создания контракта предпологается что в дальнейшем можно будет передать полноценный Customer



        [HttpGet("GET/api/customer")]
        public IList<CustomerDatabase> CustomerReadingListController() { return _CustomerService.CustomerReadingList(); } // метод чтения всей таблици Customer 


        [HttpGet("GET/api/Customer/{id}/Contract")]
       public List<ContractDatabase> ContractReagingIdOfCustomerController( [FromRoute] int Id) { return _CustomerService.ContractReagingIdOfCustomer(Id); } // метод чтнеиия контарктов по id Customer







    }
}
