using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
   

    public class InvoiceTaskDatabaseId<TUniqueId> where TUniqueId : struct
    {
       public InvoiceTaskDatabaseId() { }

        public TUniqueId Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
