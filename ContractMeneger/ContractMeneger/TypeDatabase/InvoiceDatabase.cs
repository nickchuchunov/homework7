﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    [Table("InvoiceDatabase", Schema = "InvoiceDatabase")]
    public class InvoiceDatabase: InvoiceDatabaseId<int>
    {
        public InvoiceDatabase() { }

        public int ContractId { get; set; }
        public string ServiceProduct { get; set; }
        public DateTime EndDate { get; set; }
    }
}
