using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class InvoiceService : IInvoiceRepository
    {
        ContractMenegerDatabaseContext _contractMenegerDatabaseContext;
        public InvoiceService(ContractMenegerDatabaseContext _contractMenegerDatabaseContext) { this._contractMenegerDatabaseContext = _contractMenegerDatabaseContext; }

        public void InvoiceCreateOfIdContract(int Id) //метод создания Invoice с Id Contract
        {
            _contractMenegerDatabaseContext.InvoiceDatabases.Add(new InvoiceDatabase { ContractId = Id });
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public List<InvoiceDatabase> InvoiceReadingOfIdContract(int Id) //метод чтения invoice по id contracta
        {
            
           return _contractMenegerDatabaseContext.InvoiceDatabases.Where(x => x.ContractId == Id).ToList<InvoiceDatabase>();
        }
    }
}