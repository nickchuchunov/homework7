using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface IInvoiceRepository
    {




       
        public void InvoiceCreateOfIdContract(int Id); //метод создания Invoice с Id Contract




        public List<InvoiceDatabase> InvoiceReadingOfIdContract(int Id); //метод чтения invoice по id contracta



    }
}
