using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
   
    [Table("TaskDatabase")]
    public sealed class TaskDatabase: TaskDatabaseId<int>
    {
        public float Amount { get; set; }
    }
}
