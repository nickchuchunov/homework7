using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class Invoice
    {
      public  int Id { get; set; }
      public  int ContactId { get; set; }
      public   string  ServiceProduct { get; set; }
      public  DateTime EndDate { get; set; }

        public Invoice() { }
    }
}
