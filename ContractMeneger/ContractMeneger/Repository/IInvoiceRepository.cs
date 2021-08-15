using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface IInvoiceRepository
    {




       
        public Invoice InvoiceCreateOfIdContract(int Id); //метод создания Invoice с Id Contract




        public List<Invoice> InvoiceReadingOfIdContract(int Id); //метод чтения invoice по id contracta



    }
}
