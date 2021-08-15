using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class InvoiceService : IInvoiceRepository
    {
        public Invoice InvoiceCreateOfIdContract(int Id) //метод создания Invoice с Id Contract
        {
            return new Invoice { ContactId = Id };
        }

        public List<Invoice> InvoiceReadingOfIdContract(int Id) //метод чтения invoice по id contracta
        {
            return new List<Invoice>();
        }
    }
}
