using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface ICustomerRepository
    {


        public void CustomerCreate(CustomerDatabase _customer); // метод создания Customer


        public void ContractCreate(CustomerDatabase _customer);// метод создания контракта


        public IList<CustomerDatabase> CustomerReadingList(); // метод чтения всей таблици Customer 


        public List<ContractDatabase> ContractReagingIdOfCustomer(int Id); // метод чтнеиия контарктов по id Customer








    }
}
