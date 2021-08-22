using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
    [Keyless]
    [Table("TaskDatabase", Schema = "TaskDatabase")]
    public class TaskDatabase: TaskDatabaseId<int>
    {
        public float Amount { get; set; }
    }
}
