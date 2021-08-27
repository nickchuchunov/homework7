using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
   
    [Table("EmployeDatabase")]

    public sealed class EmployeDatabase: EmployeDatabaseId<int>
    {
        public float Rate { get; set; }
    }
}
