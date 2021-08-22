using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    [Table("InvoiceTaskDatabase", Schema = "InvoiceTaskDatabase")]
    public class InvoiceTaskDatabase: InvoiceTaskDatabaseId<int>
    {
        public int TaskId { get; set; }
        public int InvoiceId { get; set; }
    }
}
