using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContractMeneger
{
   
    [Table("TaskEmployeeDatabase")]
    public sealed class TaskEmployeeDatabase: TaskEmployeeDatabaseId<int>
    {
        public int TaskId { get; set; }
        public int EmployeId { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
    }
}
