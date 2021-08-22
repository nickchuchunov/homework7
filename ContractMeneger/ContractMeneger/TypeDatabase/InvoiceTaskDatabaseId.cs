using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    public class InvoiceTaskDatabaseId<T> where T : struct
    {
        public T Id { get; set; }
    }
}
