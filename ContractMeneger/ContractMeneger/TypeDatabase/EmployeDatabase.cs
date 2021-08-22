using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    [Table("EmployeDatabase", Schema = "EmployeDatabase")]

    public class EmployeDatabase: EmployeDatabaseId<int>
    {
        public float Rate { get; set; }
    }
}
