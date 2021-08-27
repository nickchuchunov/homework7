using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class CustomerService : ICustomerRepository
    {
        ContractMenegerDatabaseContext _contractMenegerDatabaseContext;
      public  CustomerService(ContractMenegerDatabaseContext _contractMenegerDatabaseContext) { this._contractMenegerDatabaseContext = _contractMenegerDatabaseContext; }



        public void ContractCreate(CustomerDatabase _customer) // метод создания контракта
        {
            _contractMenegerDatabaseContext.ContractDatabases.Add(new ContractDatabase { CustomerID = _customer.Id });
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public List<ContractDatabase> ContractReagingIdOfCustomer(int Id) // метод чтнеиия контарктов по id ."Customer
        {
            return _contractMenegerDatabaseContext.ContractDatabases.Where(x => x.CustomerID == Id).ToList<ContractDatabase>();
           
        }

        public void CustomerCreate(CustomerDatabase _customer) // метод создания Customer
        {
            _contractMenegerDatabaseContext.CustomerDatabases.Add(_customer);
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public IList<CustomerDatabase> CustomerReadingList() // метод чтения всей таблици Customer 
        {
           return _contractMenegerDatabaseContext.CustomerDatabases.ToList<CustomerDatabase>();
        }
    }
}
