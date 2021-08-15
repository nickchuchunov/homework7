using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class CustomerService : ICustomerRepository
    {
        public Contact ContractCreate(Customer _customer) // метод создания Contract
        {
            return new Contact { CustomerID = _customer.Id };
        }

        public List<Contact> ContractReagingIdOfCustomer(int Id)  // метод чтнеиия контарктов по id Customer
        {
            return new List<Contact>();
        }

        public Customer CustomerCreate(Customer _customer) // метод создания Customer
        {
            return _customer;
        }

        public IList<Customer> CustomerReadingList() // метод чтения всей таблици Customer 
        {
            return new List<Customer>();
        }
    }
}
