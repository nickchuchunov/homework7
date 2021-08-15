using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface ICustomerRepository
    {


        public Customer CustomerCreate(Customer _customer); // метод создания Customer


        public Contact ContractCreate(Customer _customer);// метод создания контракта


        public IList<Customer> CustomerReadingList(); // метод чтения всей таблици Customer 


        public List<Contact> ContractReagingIdOfCustomer(int Id); // метод чтнеиия контарктов по id Customer








    }
}
