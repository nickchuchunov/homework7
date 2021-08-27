using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    
    [Table("InvoiceTaskDatabase")]
    public sealed class InvoiceTaskDatabase: InvoiceTaskDatabaseId<int>
    {
        public int TaskId { get; set; }
        public int InvoiceId { get; set; }
    }
}
